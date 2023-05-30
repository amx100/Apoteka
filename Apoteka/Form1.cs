﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Apoteka
{
	public partial class Form1 : Form
	{
		public Form1()
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
	}
}

