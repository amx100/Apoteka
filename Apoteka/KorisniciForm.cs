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
	public partial class KorisniciForm : Form
	{
		public KorisniciForm()
		{
			InitializeComponent();
		}

		private void prijavaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.prijavaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apotekaDataSet2);

        }

		private void KorisniciForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'apotekaDataSet2.prijava' table. You can move, or remove it, as needed.
            this.prijavaTableAdapter.Fill(this.apotekaDataSet2.prijava);

        }
    }
}
