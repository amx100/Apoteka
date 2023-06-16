using Apoteka.ViewForme;
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
	public partial class KorisnikLoginForm : Form
	{
		public KorisnikLoginForm()
		{
			InitializeComponent();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			VwStanjeLekovaForm Stanje = new VwStanjeLekovaForm();
			Stanje.Show();
		}

		private void btnRacuni_Click(object sender, EventArgs e)
		{
			RacuniForm Racuni = new RacuniForm();
			Racuni.Show();
		}

		private void btnZatvori_Click(object sender, EventArgs e)
		{
			DialogResult iExit;
			iExit = MessageBox.Show("Potvrdite ukoliko zelite zatvoriti ovaj program.", "Apoteka MG Pharm",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (iExit == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btnKupci_Click(object sender, EventArgs e)
		{
			KupciForm Kupci = new KupciForm();
			Kupci.Show();
		}

		private void btnNarudzbine_Click(object sender, EventArgs e)
		{
			NarudzbineForm Narudzbine = new NarudzbineForm();
			Narudzbine.Show();
		}

		private void btnIstorijaProdaje_Click(object sender, EventArgs e)
		{
			HistorijaProdajeForm Historija = new HistorijaProdajeForm();
			Historija.Show();
		}

		private void KorisnikLoginForm_Load(object sender, EventArgs e)
		{

		}

		private void button9_Click(object sender, EventArgs e)
		{
			VwSumaProdajeForm Suma = new VwSumaProdajeForm();
			Suma.Show();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			VwProdajaPoKupcimaForm ProdajaPK = new VwProdajaPoKupcimaForm();
			ProdajaPK.Show();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			VwLekoviPoKategorijiForm LekoviPK = new VwLekoviPoKategorijiForm();
			LekoviPK.Show();
		}

		private void button13_Click(object sender, EventArgs e)
		{
			VwLekoviForm Lekovi = new VwLekoviForm();
			Lekovi.Show();
		}
	}
}
