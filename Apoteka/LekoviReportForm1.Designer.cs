namespace Apoteka
{
	partial class LekoviReportForm1
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
			this.CrystalReport31 = new Apoteka.CrystalReport3();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// crystalReportViewer1
			// 
			this.crystalReportViewer1.ActiveViewIndex = 0;
			this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.crystalReportViewer1.Location = new System.Drawing.Point(37, 75);
			this.crystalReportViewer1.Name = "crystalReportViewer1";
			this.crystalReportViewer1.ReportSource = this.CrystalReport31;
			this.crystalReportViewer1.Size = new System.Drawing.Size(1163, 421);
			this.crystalReportViewer1.TabIndex = 0;
			this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(463, 511);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(227, 37);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// LekoviReportForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1266, 566);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.crystalReportViewer1);
			this.Name = "LekoviReportForm1";
			this.Text = "LekoviReportForm1";
			this.ResumeLayout(false);

		}

		#endregion

		private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
		private CrystalReport3 CrystalReport31;
		private System.Windows.Forms.Button button1;
	}
}