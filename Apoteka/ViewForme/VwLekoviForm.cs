using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apoteka.ViewForme
{
	public partial class VwLekoviForm : Form
	{
		public VwLekoviForm()
		{
			InitializeComponent();
		}

		private void VwLekoviForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'apotekaDataSet1.lekovi_view' table. You can move, or remove it, as needed.
            this.lekovi_viewTableAdapter.Fill(this.apotekaDataSet1.lekovi_view);

        }

		private void lekovi_viewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
