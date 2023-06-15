namespace Apoteka
{
	partial class KupciForm
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
			System.Windows.Forms.Label kupci_idLabel;
			System.Windows.Forms.Label imeLabel;
			System.Windows.Forms.Label prezimeLabel;
			System.Windows.Forms.Label adresaLabel;
			System.Windows.Forms.Label telefonLabel;
			this.apotekaDataSet = new Apoteka.apotekaDataSet();
			this.kupciBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.kupciTableAdapter = new Apoteka.apotekaDataSetTableAdapters.kupciTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSetTableAdapters.TableAdapterManager();
			this.kupci_idTextBox = new System.Windows.Forms.TextBox();
			this.imeTextBox = new System.Windows.Forms.TextBox();
			this.prezimeTextBox = new System.Windows.Forms.TextBox();
			this.adresaTextBox = new System.Windows.Forms.TextBox();
			this.telefonTextBox = new System.Windows.Forms.TextBox();
			this.kupciDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			kupci_idLabel = new System.Windows.Forms.Label();
			imeLabel = new System.Windows.Forms.Label();
			prezimeLabel = new System.Windows.Forms.Label();
			adresaLabel = new System.Windows.Forms.Label();
			telefonLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kupciDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// kupci_idLabel
			// 
			kupci_idLabel.AutoSize = true;
			kupci_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			kupci_idLabel.Location = new System.Drawing.Point(169, 157);
			kupci_idLabel.Name = "kupci_idLabel";
			kupci_idLabel.Size = new System.Drawing.Size(70, 19);
			kupci_idLabel.TabIndex = 2;
			kupci_idLabel.Text = "kupci id:";
			// 
			// imeLabel
			// 
			imeLabel.AutoSize = true;
			imeLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			imeLabel.Location = new System.Drawing.Point(369, 157);
			imeLabel.Name = "imeLabel";
			imeLabel.Size = new System.Drawing.Size(40, 19);
			imeLabel.TabIndex = 4;
			imeLabel.Text = "ime:";
			// 
			// prezimeLabel
			// 
			prezimeLabel.AutoSize = true;
			prezimeLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			prezimeLabel.Location = new System.Drawing.Point(558, 157);
			prezimeLabel.Name = "prezimeLabel";
			prezimeLabel.Size = new System.Drawing.Size(71, 19);
			prezimeLabel.TabIndex = 6;
			prezimeLabel.Text = "prezime:";
			// 
			// adresaLabel
			// 
			adresaLabel.AutoSize = true;
			adresaLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			adresaLabel.Location = new System.Drawing.Point(752, 157);
			adresaLabel.Name = "adresaLabel";
			adresaLabel.Size = new System.Drawing.Size(61, 19);
			adresaLabel.TabIndex = 8;
			adresaLabel.Text = "adresa:";
			// 
			// telefonLabel
			// 
			telefonLabel.AutoSize = true;
			telefonLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			telefonLabel.Location = new System.Drawing.Point(958, 157);
			telefonLabel.Name = "telefonLabel";
			telefonLabel.Size = new System.Drawing.Size(64, 19);
			telefonLabel.TabIndex = 10;
			telefonLabel.Text = "telefon:";
			// 
			// apotekaDataSet
			// 
			this.apotekaDataSet.DataSetName = "apotekaDataSet";
			this.apotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// kupciBindingSource
			// 
			this.kupciBindingSource.DataMember = "kupci";
			this.kupciBindingSource.DataSource = this.apotekaDataSet;
			// 
			// kupciTableAdapter
			// 
			this.kupciTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.ceneTableAdapter = null;
			this.tableAdapterManager.dobavljaciTableAdapter = null;
			this.tableAdapterManager.historija_prodajeTableAdapter = null;
			this.tableAdapterManager.kategorije_lekovaTableAdapter = null;
			this.tableAdapterManager.kupciTableAdapter = this.kupciTableAdapter;
			this.tableAdapterManager.lekoviTableAdapter = null;
			this.tableAdapterManager.narudzbineTableAdapter = null;
			this.tableAdapterManager.promocije_popustiTableAdapter = null;
			this.tableAdapterManager.racuniTableAdapter = null;
			this.tableAdapterManager.skladistenjeTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Apoteka.apotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// kupci_idTextBox
			// 
			this.kupci_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kupciBindingSource, "kupci_id", true));
			this.kupci_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kupci_idTextBox.Location = new System.Drawing.Point(173, 179);
			this.kupci_idTextBox.Name = "kupci_idTextBox";
			this.kupci_idTextBox.Size = new System.Drawing.Size(100, 22);
			this.kupci_idTextBox.TabIndex = 3;
			// 
			// imeTextBox
			// 
			this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kupciBindingSource, "ime", true));
			this.imeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.imeTextBox.Location = new System.Drawing.Point(373, 179);
			this.imeTextBox.Name = "imeTextBox";
			this.imeTextBox.Size = new System.Drawing.Size(153, 22);
			this.imeTextBox.TabIndex = 5;
			// 
			// prezimeTextBox
			// 
			this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kupciBindingSource, "prezime", true));
			this.prezimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.prezimeTextBox.Location = new System.Drawing.Point(562, 179);
			this.prezimeTextBox.Name = "prezimeTextBox";
			this.prezimeTextBox.Size = new System.Drawing.Size(157, 22);
			this.prezimeTextBox.TabIndex = 7;
			// 
			// adresaTextBox
			// 
			this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kupciBindingSource, "adresa", true));
			this.adresaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adresaTextBox.Location = new System.Drawing.Point(756, 180);
			this.adresaTextBox.Name = "adresaTextBox";
			this.adresaTextBox.Size = new System.Drawing.Size(162, 22);
			this.adresaTextBox.TabIndex = 9;
			// 
			// telefonTextBox
			// 
			this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kupciBindingSource, "telefon", true));
			this.telefonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.telefonTextBox.Location = new System.Drawing.Point(962, 180);
			this.telefonTextBox.Name = "telefonTextBox";
			this.telefonTextBox.Size = new System.Drawing.Size(129, 22);
			this.telefonTextBox.TabIndex = 11;
			// 
			// kupciDataGridView
			// 
			this.kupciDataGridView.AutoGenerateColumns = false;
			this.kupciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.kupciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.kupciDataGridView.DataSource = this.kupciBindingSource;
			this.kupciDataGridView.Location = new System.Drawing.Point(136, 230);
			this.kupciDataGridView.Name = "kupciDataGridView";
			this.kupciDataGridView.Size = new System.Drawing.Size(1018, 278);
			this.kupciDataGridView.TabIndex = 1;
			this.kupciDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kupciDataGridView_CellContentClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "kupci_id";
			this.dataGridViewTextBoxColumn1.HeaderText = "kupci_id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "ime";
			this.dataGridViewTextBoxColumn2.HeaderText = "ime";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "prezime";
			this.dataGridViewTextBoxColumn3.HeaderText = "prezime";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "adresa";
			this.dataGridViewTextBoxColumn4.HeaderText = "adresa";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "telefon";
			this.dataGridViewTextBoxColumn5.HeaderText = "telefon";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(514, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(227, 35);
			this.label1.TabIndex = 18;
			this.label1.Text = "Podaci o kupcima";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(375, 538);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 45);
			this.button1.TabIndex = 37;
			this.button1.Text = "Dodaj ";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(817, 538);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 45);
			this.button4.TabIndex = 36;
			this.button4.Text = "Stampaj";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(667, 538);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 45);
			this.button3.TabIndex = 35;
			this.button3.Text = "Sacuvaj";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(520, 538);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 45);
			this.button2.TabIndex = 34;
			this.button2.Text = "Obrisi ";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// KupciForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1320, 616);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(kupci_idLabel);
			this.Controls.Add(this.kupci_idTextBox);
			this.Controls.Add(imeLabel);
			this.Controls.Add(this.imeTextBox);
			this.Controls.Add(prezimeLabel);
			this.Controls.Add(this.prezimeTextBox);
			this.Controls.Add(adresaLabel);
			this.Controls.Add(this.adresaTextBox);
			this.Controls.Add(telefonLabel);
			this.Controls.Add(this.telefonTextBox);
			this.Controls.Add(this.kupciDataGridView);
			this.Name = "KupciForm";
			this.Text = "KupciForm";
			this.Load += new System.EventHandler(this.KupciForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kupciBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kupciDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private apotekaDataSet apotekaDataSet;
		private System.Windows.Forms.BindingSource kupciBindingSource;
		private apotekaDataSetTableAdapters.kupciTableAdapter kupciTableAdapter;
		private apotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox kupci_idTextBox;
		private System.Windows.Forms.TextBox imeTextBox;
		private System.Windows.Forms.TextBox prezimeTextBox;
		private System.Windows.Forms.TextBox adresaTextBox;
		private System.Windows.Forms.TextBox telefonTextBox;
		private System.Windows.Forms.DataGridView kupciDataGridView;
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