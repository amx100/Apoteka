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
	public partial class VwStanjeLekovaForm : Form
	{
		public VwStanjeLekovaForm()
		{
			InitializeComponent();
		}

		private void VwStanjeLekovaForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'apotekaDataSet1.stanje_lekova' table. You can move, or remove it, as needed.
            this.stanje_lekovaTableAdapter.Fill(this.apotekaDataSet1.stanje_lekova);

        }
    }
}
