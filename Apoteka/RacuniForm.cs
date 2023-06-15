using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Apoteka
{
	public partial class RacuniForm : Form
	{
		
		public RacuniForm()
		{
			InitializeComponent();
		}

		private void racuniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.racuniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apotekaDataSet);


        }

		private void RacuniForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'apotekaDataSet.racuni' table. You can move, or remove it, as needed.
            this.racuniTableAdapter.Fill(this.apotekaDataSet.racuni);

			
		
			
        }

		private void racuniDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.racuniBindingSource.AddNew();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.racuniBindingSource.RemoveCurrent();
		}

		private void button3_Click(object sender, EventArgs e)
		{

			this.Validate();
			this.racuniBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.apotekaDataSet);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			
		}
	}
}
