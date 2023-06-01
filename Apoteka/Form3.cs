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
	public partial class Form3 : Form
	{
		public Form3()
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





		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (lekoviDataGridView.SelectedRows.Count > 0)
			{
				int selectedIndex = lekoviDataGridView.SelectedRows[0].Index;
				lekoviDataGridView.Rows.RemoveAt(selectedIndex);
			}
		}




		private void btnSave_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.lekoviBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.apotekaDataSet);
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
	}
}
