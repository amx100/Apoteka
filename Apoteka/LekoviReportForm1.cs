using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Devart.Data.MySql;
using System;
using System.Data;
using System.Windows.Forms;


namespace Apoteka
{
	public partial class LekoviReportForm1 : Form
	{
		private MySqlConnection connection;
		public LekoviReportForm1()
		{
			InitializeComponent();
			connection = new MySqlConnection("User Id=root;Host=localhost;Database=apoteka");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MySqlCommand command = new MySqlCommand("SELECT * FROM apoteka.lekovi", connection);
			MySqlDataAdapter adapter = new MySqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);

			apotekaDataSet dataSet = new apotekaDataSet();
			dataSet.Tables["lekovi"].Merge(dt);

			ReportDocument reportDocument = new ReportDocument();
			reportDocument.Load("C:\\Users\\Ahmed\\source\\repos\\Apoteka\\Apoteka\\CrystalReport3.rpt");
			reportDocument.SetDataSource(dataSet);

			crystalReportViewer1.ReportSource = reportDocument;
			crystalReportViewer1.Refresh();
		}

		private void LekoviReportForm1_Load(object sender, EventArgs e)
		{

		}
	}
}
