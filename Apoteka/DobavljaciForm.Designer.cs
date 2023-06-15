namespace Apoteka
{
	partial class DobavljaciForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label dobavljaci_idLabel;
			System.Windows.Forms.Label nazivLabel;
			System.Windows.Forms.Label adresaLabel;
			System.Windows.Forms.Label telefonLabel;
			System.Windows.Forms.Label emailLabel;
			this.apotekaDataSet = new Apoteka.apotekaDataSet();
			this.dobavljaciBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dobavljaciTableAdapter = new Apoteka.apotekaDataSetTableAdapters.dobavljaciTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSetTableAdapters.TableAdapterManager();
			this.dobavljaciDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dobavljaci_idTextBox = new System.Windows.Forms.TextBox();
			this.nazivTextBox = new System.Windows.Forms.TextBox();
			this.adresaTextBox = new System.Windows.Forms.TextBox();
			this.telefonTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			dobavljaci_idLabel = new System.Windows.Forms.Label();
			nazivLabel = new System.Windows.Forms.Label();
			adresaLabel = new System.Windows.Forms.Label();
			telefonLabel = new System.Windows.Forms.Label();
			emailLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dobavljaciDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dobavljaci_idLabel
			// 
			dobavljaci_idLabel.AutoSize = true;
			dobavljaci_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dobavljaci_idLabel.Location = new System.Drawing.Point(236, 139);
			dobavljaci_idLabel.Name = "dobavljaci_idLabel";
			dobavljaci_idLabel.Size = new System.Drawing.Size(103, 19);
			dobavljaci_idLabel.TabIndex = 2;
			dobavljaci_idLabel.Text = "dobavljaci id:";
			dobavljaci_idLabel.Click += new System.EventHandler(this.dobavljaci_idLabel_Click);
			// 
			// nazivLabel
			// 
			nazivLabel.AutoSize = true;
			nazivLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nazivLabel.Location = new System.Drawing.Point(398, 139);
			nazivLabel.Name = "nazivLabel";
			nazivLabel.Size = new System.Drawing.Size(51, 19);
			nazivLabel.TabIndex = 4;
			nazivLabel.Text = "naziv:";
			nazivLabel.Click += new System.EventHandler(this.nazivLabel_Click);
			// 
			// adresaLabel
			// 
			adresaLabel.AutoSize = true;
			adresaLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			adresaLabel.Location = new System.Drawing.Point(571, 139);
			adresaLabel.Name = "adresaLabel";
			adresaLabel.Size = new System.Drawing.Size(61, 19);
			adresaLabel.TabIndex = 6;
			adresaLabel.Text = "adresa:";
			adresaLabel.Click += new System.EventHandler(this.adresaLabel_Click);
			// 
			// telefonLabel
			// 
			telefonLabel.AutoSize = true;
			telefonLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			telefonLabel.Location = new System.Drawing.Point(755, 139);
			telefonLabel.Name = "telefonLabel";
			telefonLabel.Size = new System.Drawing.Size(64, 19);
			telefonLabel.TabIndex = 8;
			telefonLabel.Text = "telefon:";
			telefonLabel.Click += new System.EventHandler(this.telefonLabel_Click);
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			emailLabel.Location = new System.Drawing.Point(916, 139);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new System.Drawing.Size(53, 19);
			emailLabel.TabIndex = 10;
			emailLabel.Text = "email:";
			emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
			// 
			// apotekaDataSet
			// 
			this.apotekaDataSet.DataSetName = "apotekaDataSet";
			this.apotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dobavljaciBindingSource
			// 
			this.dobavljaciBindingSource.DataMember = "dobavljaci";
			this.dobavljaciBindingSource.DataSource = this.apotekaDataSet;
			// 
			// dobavljaciTableAdapter
			// 
			this.dobavljaciTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.ceneTableAdapter = null;
			this.tableAdapterManager.dobavljaciTableAdapter = this.dobavljaciTableAdapter;
			this.tableAdapterManager.historija_prodajeTableAdapter = null;
			this.tableAdapterManager.kategorije_lekovaTableAdapter = null;
			this.tableAdapterManager.kupciTableAdapter = null;
			this.tableAdapterManager.lekoviTableAdapter = null;
			this.tableAdapterManager.narudzbineTableAdapter = null;
			this.tableAdapterManager.promocije_popustiTableAdapter = null;
			this.tableAdapterManager.racuniTableAdapter = null;
			this.tableAdapterManager.skladistenjeTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Apoteka.apotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// dobavljaciDataGridView
			// 
			this.dobavljaciDataGridView.AutoGenerateColumns = false;
			this.dobavljaciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dobavljaciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.dobavljaciDataGridView.DataSource = this.dobavljaciBindingSource;
			this.dobavljaciDataGridView.Location = new System.Drawing.Point(101, 202);
			this.dobavljaciDataGridView.Name = "dobavljaciDataGridView";
			this.dobavljaciDataGridView.Size = new System.Drawing.Size(1096, 285);
			this.dobavljaciDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "dobavljaci_id";
			this.dataGridViewTextBoxColumn1.HeaderText = "dobavljaci_id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "naziv";
			this.dataGridViewTextBoxColumn2.HeaderText = "naziv";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "adresa";
			this.dataGridViewTextBoxColumn3.HeaderText = "adresa";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "telefon";
			this.dataGridViewTextBoxColumn4.HeaderText = "telefon";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "email";
			this.dataGridViewTextBoxColumn5.HeaderText = "email";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dobavljaci_idTextBox
			// 
			this.dobavljaci_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "dobavljaci_id", true));
			this.dobavljaci_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dobavljaci_idTextBox.Location = new System.Drawing.Point(239, 161);
			this.dobavljaci_idTextBox.Name = "dobavljaci_idTextBox";
			this.dobavljaci_idTextBox.Size = new System.Drawing.Size(141, 22);
			this.dobavljaci_idTextBox.TabIndex = 3;
			// 
			// nazivTextBox
			// 
			this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "naziv", true));
			this.nazivTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nazivTextBox.Location = new System.Drawing.Point(401, 161);
			this.nazivTextBox.Name = "nazivTextBox";
			this.nazivTextBox.Size = new System.Drawing.Size(141, 22);
			this.nazivTextBox.TabIndex = 5;
			// 
			// adresaTextBox
			// 
			this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "adresa", true));
			this.adresaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adresaTextBox.Location = new System.Drawing.Point(575, 161);
			this.adresaTextBox.Name = "adresaTextBox";
			this.adresaTextBox.Size = new System.Drawing.Size(141, 22);
			this.adresaTextBox.TabIndex = 7;
			// 
			// telefonTextBox
			// 
			this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "telefon", true));
			this.telefonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.telefonTextBox.Location = new System.Drawing.Point(758, 161);
			this.telefonTextBox.Name = "telefonTextBox";
			this.telefonTextBox.Size = new System.Drawing.Size(141, 22);
			this.telefonTextBox.TabIndex = 9;
			// 
			// emailTextBox
			// 
			this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dobavljaciBindingSource, "email", true));
			this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailTextBox.Location = new System.Drawing.Point(919, 161);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(141, 22);
			this.emailTextBox.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(509, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(285, 35);
			this.label1.TabIndex = 18;
			this.label1.Text = "Podaci o dobavljacima";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(370, 521);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 45);
			this.button1.TabIndex = 41;
			this.button1.Text = "Dodaj ";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(812, 521);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 45);
			this.button4.TabIndex = 40;
			this.button4.Text = "Stampaj";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(662, 521);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 45);
			this.button3.TabIndex = 39;
			this.button3.Text = "Sacuvaj";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(515, 521);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 45);
			this.button2.TabIndex = 38;
			this.button2.Text = "Obrisi ";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// DobavljaciForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1293, 631);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(dobavljaci_idLabel);
			this.Controls.Add(this.dobavljaci_idTextBox);
			this.Controls.Add(nazivLabel);
			this.Controls.Add(this.nazivTextBox);
			this.Controls.Add(adresaLabel);
			this.Controls.Add(this.adresaTextBox);
			this.Controls.Add(telefonLabel);
			this.Controls.Add(this.telefonTextBox);
			this.Controls.Add(emailLabel);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.dobavljaciDataGridView);
			this.Name = "DobavljaciForm";
			this.Text = "DobavljaciForm";
			this.Load += new System.EventHandler(this.DobavljaciForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dobavljaciBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dobavljaciDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private apotekaDataSet apotekaDataSet;
		private System.Windows.Forms.BindingSource dobavljaciBindingSource;
		private apotekaDataSetTableAdapters.dobavljaciTableAdapter dobavljaciTableAdapter;
		private apotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView dobavljaciDataGridView;
		private System.Windows.Forms.TextBox dobavljaci_idTextBox;
		private System.Windows.Forms.TextBox nazivTextBox;
		private System.Windows.Forms.TextBox adresaTextBox;
		private System.Windows.Forms.TextBox telefonTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
	}
}