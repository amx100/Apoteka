namespace Apoteka
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnZatvori = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tableAdapterManager1 = new Apoteka.apotekaDataSet1TableAdapters.TableAdapterManager();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnZatvori
			// 
			this.btnZatvori.Location = new System.Drawing.Point(31, 404);
			this.btnZatvori.Name = "btnZatvori";
			this.btnZatvori.Size = new System.Drawing.Size(116, 30);
			this.btnZatvori.TabIndex = 21;
			this.btnZatvori.Text = "Zatvori";
			this.btnZatvori.UseVisualStyleBackColor = true;
			this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(31, 368);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(116, 30);
			this.btnLogin.TabIndex = 15;
			this.btnLogin.Text = "Uloguj se";
			this.btnLogin.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnZatvori);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(52);
			this.panel1.Size = new System.Drawing.Size(183, 500);
			this.panel1.TabIndex = 22;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(11, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(76, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(110, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "MG Pharm";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(227, 300);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(52);
			this.panel2.Size = new System.Drawing.Size(771, 188);
			this.panel2.TabIndex = 23;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(234, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(233, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Financijiska situacija";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(64, 57);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 92);
			this.panel3.TabIndex = 1;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// panel4
			// 
			this.panel4.Location = new System.Drawing.Point(514, 57);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(200, 92);
			this.panel4.TabIndex = 2;
			this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(510, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Rashodi";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(60, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Prihodi";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tableAdapterManager1
			// 
			this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager1.Connection = null;
			this.tableAdapterManager1.UpdateOrder = Apoteka.apotekaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1222, 500);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnZatvori;
		private System.Windows.Forms.Button btnLogin;
		private apotekaDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
	}
}