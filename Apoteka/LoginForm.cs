using Devart.Data.MySql;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Apoteka
{
	public partial class LoginForm : Form
	{
		
		public LoginForm()
		{
			InitializeComponent();
		}
	

		private void btnZatvori_Click(object sender, EventArgs e)
		{
			DialogResult iExit;
			iExit = MessageBox.Show("Potvrdite ukoliko zelite zatvoriti ovaj program.","Apoteka MG Pharm",
				MessageBoxButtons.YesNo,MessageBoxIcon.Question);
			if (iExit == DialogResult.Yes)
			{
				Application.Exit();
			}

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			Panel panel = (Panel)sender;
			int borderRadius = 20; // Promenite vrednost kako biste prilagodili krivinu ivica
			GraphicsPath path = new GraphicsPath();
			path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
			path.AddArc(panel.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
			path.AddArc(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius, 0, 90);
			path.AddArc(0, panel.Height - borderRadius, borderRadius, borderRadius, 90, 90);
			path.CloseFigure();
			panel.Region = new Region(path);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{
			Panel panel = (Panel)sender;
			int borderRadius = 20; // Promenite vrednost kako biste prilagodili krivinu ivica
			GraphicsPath path = new GraphicsPath();
			path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
			path.AddArc(panel.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
			path.AddArc(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius, 0, 90);
			path.AddArc(0, panel.Height - borderRadius, borderRadius, borderRadius, 90, 90);
			path.CloseFigure();
			panel.Region = new Region(path);
		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{
			Panel panel = (Panel)sender;
			int borderRadius = 20; // Promenite vrednost kako biste prilagodili krivinu ivica
			GraphicsPath path = new GraphicsPath();
			path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
			path.AddArc(panel.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
			path.AddArc(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius, 0, 90);
			path.AddArc(0, panel.Height - borderRadius, borderRadius, borderRadius, 90, 90);
			path.CloseFigure();
			panel.Region = new Region(path);
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			Panel panel = (Panel)sender;
			int borderRadius = 20; // Promenite vrednost kako biste prilagodili krivinu ivica
			GraphicsPath path = new GraphicsPath();
			path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
			path.AddArc(panel.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
			path.AddArc(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius, 0, 90);
			path.AddArc(0, panel.Height - borderRadius, borderRadius, borderRadius, 90, 90);
			path.CloseFigure();
			panel.Region = new Region(path);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click_1(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		MySqlConnection conn = new MySqlConnection("User Id = root; Host = localhost; Database= apoteka");

		private void AdminLoginForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				btnLogin.PerformClick();
			}
		}

		private void AdminLoginForm_Load(object sender, EventArgs e)
		{
			boxNivo.SelectedIndex = 0;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{

			if (txtUsername.Text == "" && txtPassword.Text == "") //Error when all text box are not fill
			{
				MessageBox.Show("Niste uneli ni jedan podatak!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (txtUsername.Text == "") //Error when all text box are not fill
			{
				MessageBox.Show("Niste uneli Korisnicko ime!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (txtPassword.Text == "") //Error when all text box are not fill
			{
				MessageBox.Show("Niste uneli lozinku!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
			else
			{
				try
				{

					MySqlCommand SelectCommand = new MySqlCommand("select * from apoteka.prijava where korisnik='" + this.txtUsername.Text + "' and sifra='" + this.txtPassword.Text + "' ;", conn);

					MySqlDataReader myReader;

					conn.Open();
					myReader = SelectCommand.ExecuteReader();
					int count = 0;
					string nivo = string.Empty;
					while (myReader.Read())
					{
						count = count + 1;
						nivo = myReader["nivo"].ToString();
					}
					if (count == 1)
					{

						if (nivo == "admin" && nivo == boxNivo.SelectedItem.ToString())
						{
							this.Hide();
							MainForm admin_Forma = new MainForm();
							admin_Forma.Show();
							MessageBox.Show("Uspesno ste ulogovani.", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

						}

						else if (nivo == "korisnik" && nivo == boxNivo.SelectedItem.ToString())
						{
							this.Hide();
							KorisnikLoginForm korisnik_Forma = new KorisnikLoginForm();
							korisnik_Forma.Show();
							MessageBox.Show("Uspesno ste ulogovani.", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

						}
						else
						{
							MessageBox.Show("Profil nije na tom nivou.", "Greska!");
						}

					}
					else
					{
						MessageBox.Show("Uneti podaci su netacni!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						conn.Close();
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

			}
		}
	}
}

	



