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
	public partial class KategorijeLekovaForm : Form
	{
		public KategorijeLekovaForm()
		{
			InitializeComponent();
		}

		

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void lekovi_idLabel_Click_1(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.kategorije_lekovabindingSource1.AddNew();


		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			this.Validate();
			this.kategorije_lekovabindingSource1.EndEdit();
			this.tableAdapterManager.UpdateAll(this.apotekaDataSet);


		}

		private void KategorijeLekovaForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'apotekaDataSet.kategorije_lekova' table. You can move, or remove it, as needed.
			this.kategorije_lekovaTableAdapter1.Fill(this.apotekaDataSet.kategorije_lekova);

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			this.kategorije_lekovabindingSource1.RemoveCurrent();
		}
	}
}
