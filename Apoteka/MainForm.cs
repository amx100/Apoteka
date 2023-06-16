using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Apoteka.apotekaDataSet;

namespace Apoteka
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}


			public void btnLekovi_Click(object sender, EventArgs e)
			{
				LekoviForm Lekovi = new LekoviForm();
				Lekovi.Show();
			}

		private void Form2_Load(object sender, EventArgs e)
		{
		

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

		private void btnKategorijeLekova_Click(object sender, EventArgs e)
		{
			KategorijeLekovaForm KategorijeLekova = new KategorijeLekovaForm();
			KategorijeLekova.Show();
		}

		private void btnSkladistenje_Click(object sender, EventArgs e)
		{
			SkladistenjeForm SkladistenjeLekova = new SkladistenjeForm();
			SkladistenjeLekova.Show();
		}

		private void btnDobavljaci_Click(object sender, EventArgs e)
		{
			DobavljaciForm DobavljanjeLekova = new DobavljaciForm();
			DobavljanjeLekova.Show();
		}

		private void btnRacuni_Click(object sender, EventArgs e)
		{
			RacuniForm Racuni = new RacuniForm();
			Racuni.Show();
		}

		private void btnNarudzbine_Click(object sender, EventArgs e)
		{
			NarudzbineForm Narudzbine = new NarudzbineForm();
			Narudzbine.Show();
		}

		private void btnKupci_Click(object sender, EventArgs e)
		{
			KupciForm Kupci = new KupciForm();
			Kupci.Show();
		}

		private void btnIstorijaProdaje_Click(object sender, EventArgs e)
		{
			HistorijaProdajeForm Historija = new HistorijaProdajeForm();
			Historija.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			KorisniciForm Korisnici = new KorisniciForm();
			Korisnici.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			RepForm Report = new RepForm();
			Report.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			LoginForm Login = new LoginForm();
			Login.Show();
			this.Close();
		}
	}
	}

