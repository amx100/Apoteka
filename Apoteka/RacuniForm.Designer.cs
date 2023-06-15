namespace Apoteka
{
	partial class RacuniForm
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
			System.Windows.Forms.Label racuni_idLabel;
			System.Windows.Forms.Label narudzbine_idLabel;
			System.Windows.Forms.Label ukupan_iznosLabel;
			System.Windows.Forms.Label datumLabel;
			this.apotekaDataSet = new Apoteka.apotekaDataSet();
			this.racuniBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.racuniTableAdapter = new Apoteka.apotekaDataSetTableAdapters.racuniTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSetTableAdapters.TableAdapterManager();
			this.racuniDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.racuni_idTextBox = new System.Windows.Forms.TextBox();
			this.narudzbine_idTextBox = new System.Windows.Forms.TextBox();
			this.ukupan_iznosTextBox = new System.Windows.Forms.TextBox();
			this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			racuni_idLabel = new System.Windows.Forms.Label();
			narudzbine_idLabel = new System.Windows.Forms.Label();
			ukupan_iznosLabel = new System.Windows.Forms.Label();
			datumLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.racuniBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.racuniDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// racuni_idLabel
			// 
			racuni_idLabel.AutoSize = true;
			racuni_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			racuni_idLabel.Location = new System.Drawing.Point(187, 166);
			racuni_idLabel.Name = "racuni_idLabel";
			racuni_idLabel.Size = new System.Drawing.Size(77, 19);
			racuni_idLabel.TabIndex = 2;
			racuni_idLabel.Text = "racuni id:";
			// 
			// narudzbine_idLabel
			// 
			narudzbine_idLabel.AutoSize = true;
			narudzbine_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			narudzbine_idLabel.Location = new System.Drawing.Point(428, 166);
			narudzbine_idLabel.Name = "narudzbine_idLabel";
			narudzbine_idLabel.Size = new System.Drawing.Size(111, 19);
			narudzbine_idLabel.TabIndex = 4;
			narudzbine_idLabel.Text = "narudzbine id:";
			// 
			// ukupan_iznosLabel
			// 
			ukupan_iznosLabel.AutoSize = true;
			ukupan_iznosLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			ukupan_iznosLabel.Location = new System.Drawing.Point(666, 166);
			ukupan_iznosLabel.Name = "ukupan_iznosLabel";
			ukupan_iznosLabel.Size = new System.Drawing.Size(106, 19);
			ukupan_iznosLabel.TabIndex = 6;
			ukupan_iznosLabel.Text = "ukupan iznos:";
			// 
			// datumLabel
			// 
			datumLabel.AutoSize = true;
			datumLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			datumLabel.Location = new System.Drawing.Point(909, 167);
			datumLabel.Name = "datumLabel";
			datumLabel.Size = new System.Drawing.Size(59, 19);
			datumLabel.TabIndex = 8;
			datumLabel.Text = "datum:";
			// 
			// apotekaDataSet
			// 
			this.apotekaDataSet.DataSetName = "apotekaDataSet";
			this.apotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// racuniBindingSource
			// 
			this.racuniBindingSource.DataMember = "racuni";
			this.racuniBindingSource.DataSource = this.apotekaDataSet;
			// 
			// racuniTableAdapter
			// 
			this.racuniTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.narudzbineTableAdapter = null;
			this.tableAdapterManager.promocije_popustiTableAdapter = null;
			this.tableAdapterManager.racuniTableAdapter = this.racuniTableAdapter;
			this.tableAdapterManager.skladistenjeTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Apoteka.apotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// racuniDataGridView
			// 
			this.racuniDataGridView.AutoGenerateColumns = false;
			this.racuniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.racuniDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.racuniDataGridView.DataSource = this.racuniBindingSource;
			this.racuniDataGridView.Location = new System.Drawing.Point(152, 226);
			this.racuniDataGridView.Name = "racuniDataGridView";
			this.racuniDataGridView.Size = new System.Drawing.Size(1002, 260);
			this.racuniDataGridView.TabIndex = 1;
			this.racuniDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.racuniDataGridView_CellContentClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "racuni_id";
			this.dataGridViewTextBoxColumn1.HeaderText = "racuni_id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "narudzbine_id";
			this.dataGridViewTextBoxColumn2.HeaderText = "narudzbine_id";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "ukupan_iznos";
			this.dataGridViewTextBoxColumn3.HeaderText = "ukupan_iznos";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "datum";
			this.dataGridViewTextBoxColumn4.HeaderText = "datum";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// racuni_idTextBox
			// 
			this.racuni_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racuniBindingSource, "racuni_id", true));
			this.racuni_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.racuni_idTextBox.Location = new System.Drawing.Point(191, 188);
			this.racuni_idTextBox.Name = "racuni_idTextBox";
			this.racuni_idTextBox.Size = new System.Drawing.Size(73, 22);
			this.racuni_idTextBox.TabIndex = 3;
			// 
			// narudzbine_idTextBox
			// 
			this.narudzbine_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racuniBindingSource, "narudzbine_id", true));
			this.narudzbine_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.narudzbine_idTextBox.Location = new System.Drawing.Point(432, 188);
			this.narudzbine_idTextBox.Name = "narudzbine_idTextBox";
			this.narudzbine_idTextBox.Size = new System.Drawing.Size(106, 22);
			this.narudzbine_idTextBox.TabIndex = 5;
			// 
			// ukupan_iznosTextBox
			// 
			this.ukupan_iznosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racuniBindingSource, "ukupan_iznos", true));
			this.ukupan_iznosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ukupan_iznosTextBox.Location = new System.Drawing.Point(670, 189);
			this.ukupan_iznosTextBox.Name = "ukupan_iznosTextBox";
			this.ukupan_iznosTextBox.Size = new System.Drawing.Size(119, 22);
			this.ukupan_iznosTextBox.TabIndex = 7;
			// 
			// datumDateTimePicker
			// 
			this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.racuniBindingSource, "datum", true));
			this.datumDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datumDateTimePicker.Location = new System.Drawing.Point(913, 187);
			this.datumDateTimePicker.Name = "datumDateTimePicker";
			this.datumDateTimePicker.Size = new System.Drawing.Size(220, 22);
			this.datumDateTimePicker.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(378, 545);
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
			this.button4.Location = new System.Drawing.Point(820, 545);
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
			this.button3.Location = new System.Drawing.Point(670, 545);
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
			this.button2.Location = new System.Drawing.Point(523, 545);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 45);
			this.button2.TabIndex = 38;
			this.button2.Text = "Obrisi ";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(497, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 35);
			this.label1.TabIndex = 42;
			this.label1.Text = "Podaci o racunima";
			// 
			// RacuniForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1297, 619);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(racuni_idLabel);
			this.Controls.Add(this.racuni_idTextBox);
			this.Controls.Add(narudzbine_idLabel);
			this.Controls.Add(this.narudzbine_idTextBox);
			this.Controls.Add(ukupan_iznosLabel);
			this.Controls.Add(this.ukupan_iznosTextBox);
			this.Controls.Add(datumLabel);
			this.Controls.Add(this.datumDateTimePicker);
			this.Controls.Add(this.racuniDataGridView);
			this.Name = "RacuniForm";
			this.Text = "RacuniForm";
			this.Load += new System.EventHandler(this.RacuniForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.racuniBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.racuniDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private apotekaDataSet apotekaDataSet;
		private System.Windows.Forms.BindingSource racuniBindingSource;
		private apotekaDataSetTableAdapters.racuniTableAdapter racuniTableAdapter;
		private apotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView racuniDataGridView;
		private System.Windows.Forms.TextBox racuni_idTextBox;
		private System.Windows.Forms.TextBox narudzbine_idTextBox;
		private System.Windows.Forms.TextBox ukupan_iznosTextBox;
		private System.Windows.Forms.DateTimePicker datumDateTimePicker;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.Label label1;
	}
}