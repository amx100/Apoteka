namespace Apoteka
{
	partial class NarudzbineForm
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
			System.Windows.Forms.Label narudzbine_idLabel;
			System.Windows.Forms.Label lekovi_idLabel;
			System.Windows.Forms.Label kupci_idLabel;
			System.Windows.Forms.Label kolicinaLabel;
			System.Windows.Forms.Label datumLabel;
			this.apotekaDataSet = new Apoteka.apotekaDataSet();
			this.narudzbineBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.narudzbineTableAdapter = new Apoteka.apotekaDataSetTableAdapters.narudzbineTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSetTableAdapters.TableAdapterManager();
			this.narudzbineDataGridView = new System.Windows.Forms.DataGridView();
			this.narudzbineidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lekoviidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kupciidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.narudzbine_idTextBox = new System.Windows.Forms.TextBox();
			this.lekovi_idTextBox = new System.Windows.Forms.TextBox();
			this.kupci_idTextBox = new System.Windows.Forms.TextBox();
			this.kolicinaTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
			narudzbine_idLabel = new System.Windows.Forms.Label();
			lekovi_idLabel = new System.Windows.Forms.Label();
			kupci_idLabel = new System.Windows.Forms.Label();
			kolicinaLabel = new System.Windows.Forms.Label();
			datumLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.narudzbineBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.narudzbineDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// narudzbine_idLabel
			// 
			narudzbine_idLabel.AutoSize = true;
			narudzbine_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			narudzbine_idLabel.Location = new System.Drawing.Point(212, 151);
			narudzbine_idLabel.Name = "narudzbine_idLabel";
			narudzbine_idLabel.Size = new System.Drawing.Size(111, 19);
			narudzbine_idLabel.TabIndex = 2;
			narudzbine_idLabel.Text = "narudzbine id:";
			// 
			// lekovi_idLabel
			// 
			lekovi_idLabel.AutoSize = true;
			lekovi_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lekovi_idLabel.Location = new System.Drawing.Point(406, 149);
			lekovi_idLabel.Name = "lekovi_idLabel";
			lekovi_idLabel.Size = new System.Drawing.Size(74, 19);
			lekovi_idLabel.TabIndex = 4;
			lekovi_idLabel.Text = "lekovi id:";
			// 
			// kupci_idLabel
			// 
			kupci_idLabel.AutoSize = true;
			kupci_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			kupci_idLabel.Location = new System.Drawing.Point(595, 151);
			kupci_idLabel.Name = "kupci_idLabel";
			kupci_idLabel.Size = new System.Drawing.Size(70, 19);
			kupci_idLabel.TabIndex = 6;
			kupci_idLabel.Text = "kupci id:";
			// 
			// kolicinaLabel
			// 
			kolicinaLabel.AutoSize = true;
			kolicinaLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			kolicinaLabel.Location = new System.Drawing.Point(785, 151);
			kolicinaLabel.Name = "kolicinaLabel";
			kolicinaLabel.Size = new System.Drawing.Size(69, 19);
			kolicinaLabel.TabIndex = 8;
			kolicinaLabel.Text = "kolicina:";
			// 
			// datumLabel
			// 
			datumLabel.AutoSize = true;
			datumLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			datumLabel.Location = new System.Drawing.Point(950, 151);
			datumLabel.Name = "datumLabel";
			datumLabel.Size = new System.Drawing.Size(59, 19);
			datumLabel.TabIndex = 10;
			datumLabel.Text = "datum:";
			// 
			// apotekaDataSet
			// 
			this.apotekaDataSet.DataSetName = "apotekaDataSet";
			this.apotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// narudzbineBindingSource
			// 
			this.narudzbineBindingSource.DataMember = "narudzbine";
			this.narudzbineBindingSource.DataSource = this.apotekaDataSet;
			// 
			// narudzbineTableAdapter
			// 
			this.narudzbineTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.ceneTableAdapter = null;
			this.tableAdapterManager.dobavljaciTableAdapter = null;
			this.tableAdapterManager.historija_prodajeTableAdapter = null;
			this.tableAdapterManager.kategorije_lekovaTableAdapter = null;
			this.tableAdapterManager.kupciTableAdapter = null;
			this.tableAdapterManager.lekoviTableAdapter = null;
			this.tableAdapterManager.narudzbineTableAdapter = this.narudzbineTableAdapter;
			this.tableAdapterManager.promocije_popustiTableAdapter = null;
			this.tableAdapterManager.racuniTableAdapter = null;
			this.tableAdapterManager.skladistenjeTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Apoteka.apotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// narudzbineDataGridView
			// 
			this.narudzbineDataGridView.AutoGenerateColumns = false;
			this.narudzbineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.narudzbineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.narudzbineidDataGridViewTextBoxColumn,
            this.lekoviidDataGridViewTextBoxColumn,
            this.kupciidDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn});
			this.narudzbineDataGridView.DataSource = this.narudzbineBindingSource;
			this.narudzbineDataGridView.Location = new System.Drawing.Point(173, 222);
			this.narudzbineDataGridView.Name = "narudzbineDataGridView";
			this.narudzbineDataGridView.Size = new System.Drawing.Size(1002, 260);
			this.narudzbineDataGridView.TabIndex = 1;
			this.narudzbineDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.narudzbineDataGridView_CellContentClick);
			// 
			// narudzbineidDataGridViewTextBoxColumn
			// 
			this.narudzbineidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.narudzbineidDataGridViewTextBoxColumn.DataPropertyName = "narudzbine_id";
			this.narudzbineidDataGridViewTextBoxColumn.HeaderText = "narudzbine_id";
			this.narudzbineidDataGridViewTextBoxColumn.Name = "narudzbineidDataGridViewTextBoxColumn";
			// 
			// lekoviidDataGridViewTextBoxColumn
			// 
			this.lekoviidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.lekoviidDataGridViewTextBoxColumn.DataPropertyName = "lekovi_id";
			this.lekoviidDataGridViewTextBoxColumn.HeaderText = "lekovi_id";
			this.lekoviidDataGridViewTextBoxColumn.Name = "lekoviidDataGridViewTextBoxColumn";
			// 
			// kupciidDataGridViewTextBoxColumn
			// 
			this.kupciidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.kupciidDataGridViewTextBoxColumn.DataPropertyName = "kupci_id";
			this.kupciidDataGridViewTextBoxColumn.HeaderText = "kupci_id";
			this.kupciidDataGridViewTextBoxColumn.Name = "kupciidDataGridViewTextBoxColumn";
			// 
			// kolicinaDataGridViewTextBoxColumn
			// 
			this.kolicinaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
			this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
			this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
			// 
			// datumDataGridViewTextBoxColumn
			// 
			this.datumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
			this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
			this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
			// 
			// narudzbine_idTextBox
			// 
			this.narudzbine_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.narudzbineBindingSource, "narudzbine_id", true));
			this.narudzbine_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.narudzbine_idTextBox.Location = new System.Drawing.Point(216, 173);
			this.narudzbine_idTextBox.Name = "narudzbine_idTextBox";
			this.narudzbine_idTextBox.Size = new System.Drawing.Size(120, 22);
			this.narudzbine_idTextBox.TabIndex = 3;
			// 
			// lekovi_idTextBox
			// 
			this.lekovi_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.narudzbineBindingSource, "lekovi_id", true));
			this.lekovi_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lekovi_idTextBox.Location = new System.Drawing.Point(599, 173);
			this.lekovi_idTextBox.Name = "lekovi_idTextBox";
			this.lekovi_idTextBox.Size = new System.Drawing.Size(120, 22);
			this.lekovi_idTextBox.TabIndex = 5;
			// 
			// kupci_idTextBox
			// 
			this.kupci_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.narudzbineBindingSource, "kupci_id", true));
			this.kupci_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kupci_idTextBox.Location = new System.Drawing.Point(410, 173);
			this.kupci_idTextBox.Name = "kupci_idTextBox";
			this.kupci_idTextBox.Size = new System.Drawing.Size(120, 22);
			this.kupci_idTextBox.TabIndex = 7;
			// 
			// kolicinaTextBox
			// 
			this.kolicinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.narudzbineBindingSource, "kolicina", true));
			this.kolicinaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kolicinaTextBox.Location = new System.Drawing.Point(789, 173);
			this.kolicinaTextBox.Name = "kolicinaTextBox";
			this.kolicinaTextBox.Size = new System.Drawing.Size(125, 22);
			this.kolicinaTextBox.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(410, 515);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 45);
			this.button1.TabIndex = 45;
			this.button1.Text = "Dodaj ";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(852, 515);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 45);
			this.button4.TabIndex = 44;
			this.button4.Text = "Stampaj";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(702, 515);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 45);
			this.button3.TabIndex = 43;
			this.button3.Text = "Sacuvaj";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(555, 515);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 45);
			this.button2.TabIndex = 42;
			this.button2.Text = "Obrisi ";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(502, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(299, 35);
			this.label1.TabIndex = 46;
			this.label1.Text = "Podaci o narudzbinama";
			// 
			// datumDateTimePicker
			// 
			this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.narudzbineBindingSource, "datum", true));
			this.datumDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datumDateTimePicker.Location = new System.Drawing.Point(954, 171);
			this.datumDateTimePicker.Name = "datumDateTimePicker";
			this.datumDateTimePicker.Size = new System.Drawing.Size(221, 22);
			this.datumDateTimePicker.TabIndex = 11;
			this.datumDateTimePicker.Value = new System.DateTime(2023, 6, 15, 7, 13, 42, 0);
			// 
			// NarudzbineForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1326, 618);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(narudzbine_idLabel);
			this.Controls.Add(this.narudzbine_idTextBox);
			this.Controls.Add(lekovi_idLabel);
			this.Controls.Add(this.lekovi_idTextBox);
			this.Controls.Add(kupci_idLabel);
			this.Controls.Add(this.kupci_idTextBox);
			this.Controls.Add(kolicinaLabel);
			this.Controls.Add(this.kolicinaTextBox);
			this.Controls.Add(datumLabel);
			this.Controls.Add(this.datumDateTimePicker);
			this.Controls.Add(this.narudzbineDataGridView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.Name = "NarudzbineForm";
			this.Text = "--";
			this.Load += new System.EventHandler(this.NarudzbineForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.narudzbineBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.narudzbineDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private apotekaDataSet apotekaDataSet;
		private System.Windows.Forms.BindingSource narudzbineBindingSource;
		private apotekaDataSetTableAdapters.narudzbineTableAdapter narudzbineTableAdapter;
		private apotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView narudzbineDataGridView;
		private System.Windows.Forms.TextBox narudzbine_idTextBox;
		private System.Windows.Forms.TextBox lekovi_idTextBox;
		private System.Windows.Forms.TextBox kupci_idTextBox;
		private System.Windows.Forms.TextBox kolicinaTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker datumDateTimePicker;
		private System.Windows.Forms.DataGridViewTextBoxColumn narudzbineidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lekoviidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kupciidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
	}
}