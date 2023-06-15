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
	public partial class KupciForm : Form
	{
		public KupciForm()
		{
			InitializeComponent();
		}

		private void kupciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.kupciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apotekaDataSet);

        }

		private void KupciForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'apotekaDataSet.kupci' table. You can move, or remove it, as needed.
            this.kupciTableAdapter.Fill(this.apotekaDataSet.kupci);

        }

		private void kupciDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.kupciBindingSource.AddNew();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.kupciBindingSource.RemoveCurrent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.kupciBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.apotekaDataSet);
		}

		private void button4_Click(object sender, EventArgs e)
		{
	
		}
	}
}
