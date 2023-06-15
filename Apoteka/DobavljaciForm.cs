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
	public partial class DobavljaciForm : Form
	{
		public DobavljaciForm()
		{
			InitializeComponent();
		}

		private void dobavljaciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.dobavljaciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apotekaDataSet);

        }

		private void DobavljaciForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'apotekaDataSet.dobavljaci' table. You can move, or remove it, as needed.
            this.dobavljaciTableAdapter.Fill(this.apotekaDataSet.dobavljaci);

        }

		private void nazivLabel_Click(object sender, EventArgs e)
		{

		}

		private void adresaLabel_Click(object sender, EventArgs e)
		{

		}

		private void telefonLabel_Click(object sender, EventArgs e)
		{

		}

		private void dobavljaci_idLabel_Click(object sender, EventArgs e)
		{

		}

		private void emailLabel_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.dobavljaciBindingSource.AddNew();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.dobavljaciBindingSource.RemoveCurrent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
				this.Validate();
			this.dobavljaciBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.apotekaDataSet);

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}
	}
}
