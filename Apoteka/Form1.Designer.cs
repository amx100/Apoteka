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
			this.tableAdapterManager1 = new Apoteka.apotekaDataSet1TableAdapters.TableAdapterManager();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.skladistenjeTableAdapter1 = new Apoteka.apotekaDataSetTableAdapters.skladistenjeTableAdapter();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableAdapterManager1
			// 
			this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager1.Connection = null;
			this.tableAdapterManager1.UpdateOrder = Apoteka.apotekaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1222, 113);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(593, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apoteka";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label2.Click += new System.EventHandler(this.label2_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(538, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "MG Pharm";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.White;
			this.panel5.Controls.Add(this.button1);
			this.panel5.Controls.Add(this.txtPassword);
			this.panel5.Controls.Add(this.txtUsername);
			this.panel5.Controls.Add(this.label6);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.btnLogin);
			this.panel5.Location = new System.Drawing.Point(380, 139);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(485, 332);
			this.panel5.TabIndex = 27;
			this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(332, 154);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(81, 30);
			this.button1.TabIndex = 29;
			this.button1.Text = "Obrisi";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(229, 82);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(184, 26);
			this.txtPassword.TabIndex = 28;
			// 
			// txtUsername
			// 
			this.txtUsername.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(229, 35);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(184, 26);
			this.txtUsername.TabIndex = 27;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(24, 82);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 26);
			this.label6.TabIndex = 25;
			this.label6.Text = "Sifra";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(24, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 26);
			this.label5.TabIndex = 24;
			this.label5.Text = "Korisnicko ime";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.LightSteelBlue;
			this.btnLogin.ForeColor = System.Drawing.Color.Black;
			this.btnLogin.Location = new System.Drawing.Point(229, 154);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(81, 30);
			this.btnLogin.TabIndex = 15;
			this.btnLogin.Text = "Uloguj se";
			this.btnLogin.UseVisualStyleBackColor = false;
			// 
			// skladistenjeTableAdapter1
			// 
			this.skladistenjeTableAdapter1.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1222, 500);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private apotekaDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnLogin;
		private apotekaDataSetTableAdapters.skladistenjeTableAdapter skladistenjeTableAdapter1;
	}
}