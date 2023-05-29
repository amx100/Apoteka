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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void lekoviBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.lekoviBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apotekaDataSet);

        }

		private void Form2_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'apotekaDataSet.lekovi' table. You can move, or remove it, as needed.
            this.lekoviTableAdapter.Fill(this.apotekaDataSet.lekovi);

        }
    }
}
