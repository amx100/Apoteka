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
	public partial class SkladistenjeForm : Form
	{
		public SkladistenjeForm()
		{
			InitializeComponent();
		}

		private void skladistenjeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
       

        }

		private void SkladistenjeForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'apotekaDataSet.skladistenje' table. You can move, or remove it, as needed.
            this.skladistenjeTableAdapter.Fill(this.apotekaDataSet.skladistenje);
		

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.skladistenjeBindingSource.AddNew();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			
			if (lekovi_idTextBox.Text.Trim() != "" && Convert.ToInt32(lekovi_idTextBox.Text) <= 0)
			{
				MessageBox.Show("Pogrešan unos vrednosti za ID. Molimo unesite vrednost veću od 0.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				lekovi_idTextBox.Focus(); // Fokusirajte se na polje za unos skladistenje_id
				return;
			}

			this.Validate();
			this.skladistenjeBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.apotekaDataSet);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.skladistenjeBindingSource.RemoveCurrent();
		}

		private void skladistenjeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void skladistenje_idTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void lekovi_idTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
