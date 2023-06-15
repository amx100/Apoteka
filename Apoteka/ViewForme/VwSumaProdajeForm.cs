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
	public partial class VwSumaProdajeForm : Form
	{
		public VwSumaProdajeForm()
		{
			InitializeComponent();
		}

		private void VwSumaProdajeForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'apotekaDataSet1.vw_suma_prodaje' table. You can move, or remove it, as needed.
            this.vw_suma_prodajeTableAdapter.Fill(this.apotekaDataSet1.vw_suma_prodaje);

        }

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
