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
	public partial class VwProdajaPoKupcimaForm : Form
	{
		public VwProdajaPoKupcimaForm()
		{
			InitializeComponent();
		}

		private void VwProdajaPoKupcimaForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'apotekaDataSet1.vw_prodaja' table. You can move, or remove it, as needed.
            this.vw_prodajaTableAdapter.Fill(this.apotekaDataSet1.vw_prodaja);

        }
    }
}
