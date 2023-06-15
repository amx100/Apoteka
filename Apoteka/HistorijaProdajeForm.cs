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
	public partial class HistorijaProdajeForm : Form
	{
		public HistorijaProdajeForm()
		{
			InitializeComponent();
		}

		private void historija_prodajeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.historija_prodajeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apotekaDataSet);

        }

		private void HistorijaProdajeForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'apotekaDataSet.historija_prodaje' table. You can move, or remove it, as needed.
            this.historija_prodajeTableAdapter.Fill(this.apotekaDataSet.historija_prodaje);

        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.historija_prodajeBindingSource.AddNew();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.historija_prodajeBindingSource.RemoveCurrent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.historija_prodajeBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.apotekaDataSet);
		}
	}
}
