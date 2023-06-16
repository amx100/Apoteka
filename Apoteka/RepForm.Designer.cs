namespace Apoteka
{
	partial class RepForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.CrystalReport11 = new Apoteka.CrystalReport1();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = 0;
			this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.crystalReportViewer1.Location = new System.Drawing.Point(43, 76);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = this.CrystalReport11;
			this.crystalReportViewer1.Size = new System.Drawing.Size(1202, 399);
			this.crystalReportViewer1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(589, 495);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 47);
			this.button1.TabIndex = 1;
			this.button1.Text = "Ucitaj izvestaj";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(518, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(233, 35);
			this.label1.TabIndex = 43;
			this.label1.Text = "Podaci o izvestaju";
			// 
			// RepForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1287, 559);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.crystalReportViewer1);
			this.Name = "RepForm";
			this.Text = "RepForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private CrystalReport1 CrystalReport11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}