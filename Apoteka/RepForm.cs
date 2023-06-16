using CrystalDecisions.CrystalReports.Engine;
using Devart.Data.MySql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Apoteka
{
	public partial class RepForm : Form
	{
	
		private MySqlConnection connection;

		public RepForm()
		{
			InitializeComponent();
			connection = new MySqlConnection("User Id=root;Host=localhost;Database=apoteka");
		}

		

		private void button1_Click_1(object sender, EventArgs e)
		{
			MySqlCommand command = new MySqlCommand("SELECT * FROM apoteka.kupci", connection);
			MySqlDataAdapter adapter = new MySqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);

			apotekaDataSet dataSet = new apotekaDataSet();
			dataSet.Tables["kupci"].Merge(dt);

			ReportDocument reportDocument = new ReportDocument();
			reportDocument.Load("C:\\Users\\Ahmed\\source\\repos\\Apoteka\\Apoteka\\CrystalReport1.rpt");
			reportDocument.SetDataSource(dataSet);

			crystalReportViewer1.ReportSource = reportDocument;
			crystalReportViewer1.Refresh();
		}

		private void RepForm_Load(object sender, EventArgs e)
		{

		}
	}
}

