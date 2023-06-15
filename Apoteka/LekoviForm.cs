using Devart.Common;
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
	public partial class LekoviForm : Form
	{
		
		public LekoviForm()
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

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void lekoviDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void lekovi_idTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void lekovi_idLabel_Click(object sender, EventArgs e)
		{

		}

		private void lekovi_idTextBox_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void lekoviDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{



		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{

		}

		private void lekovi_idLabel_Click_1(object sender, EventArgs e)
		{

		}

		private void lekoviBindingNavigator_RefreshItems(object sender, EventArgs e)
		{

		}

		private void toolStripLabel2_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

			this.lekoviBindingSource.AddNew();
		

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.lekoviBindingSource.RemoveCurrent();
			MessageBox.Show("Uspješno ste obrisali lek", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			// Provera da li su svi podaci uneti u odgovarajućim tipovima TextBox-ova
			if (!IsDataValid())
			{
				MessageBox.Show("Uneti podaci nisu validni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.Validate();
			this.lekoviBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.apotekaDataSet);

			MessageBox.Show("Uspješno ste sacuvali lek", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private bool IsDataValid()
		{
			// Provera da li su svi podaci uneti u odgovarajućim tipovima TextBox-ova
			int intValue;
			string stringValue;

			// Provera za TextBox1
			if (!int.TryParse(lekovi_idTextBox.Text, out intValue))
			{
				return false;
			}

			// Provera za TextBox2 (string tip)
			if (!string.IsNullOrEmpty(nazivTextBox.Text))
			{
				stringValue = nazivTextBox.Text;
			}
			else
			{
				return false;
			}
			return true;
		}



		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void nazivTextBox_TextChanged(object sender, EventArgs e)
		{
		}

		private void lekovi_idTextBox_TextChanged_2(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click_1(object sender, EventArgs e)
		{
		
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
	}


