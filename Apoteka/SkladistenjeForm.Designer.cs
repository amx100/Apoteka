namespace Apoteka
{
	partial class SkladistenjeForm
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
			System.Windows.Forms.Label skladistenje_idLabel;
			System.Windows.Forms.Label lekovi_idLabel;
			System.Windows.Forms.Label kolicinaLabel;
			System.Windows.Forms.Label datumLabel;
			System.Windows.Forms.Label dobavljaci_idLabel;
			this.apotekaDataSet = new Apoteka.apotekaDataSet();
			this.skladistenjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.skladistenjeTableAdapter = new Apoteka.apotekaDataSetTableAdapters.skladistenjeTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSetTableAdapters.TableAdapterManager();
			this.skladistenjeDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skladistenje_idTextBox = new System.Windows.Forms.TextBox();
			this.lekovi_idTextBox = new System.Windows.Forms.TextBox();
			this.kolicinaTextBox = new System.Windows.Forms.TextBox();
			this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.dobavljaci_idTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			skladistenje_idLabel = new System.Windows.Forms.Label();
			lekovi_idLabel = new System.Windows.Forms.Label();
			kolicinaLabel = new System.Windows.Forms.Label();
			datumLabel = new System.Windows.Forms.Label();
			dobavljaci_idLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.skladistenjeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.skladistenjeDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// skladistenje_idLabel
			// 
			skladistenje_idLabel.AutoSize = true;
			skladistenje_idLabel.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			skladistenje_idLabel.Location = new System.Drawing.Point(150, 158);
			skladistenje_idLabel.Name = "skladistenje_idLabel";
			skladistenje_idLabel.Size = new System.Drawing.Size(135, 23);
			skladistenje_idLabel.TabIndex = 2;
			skladistenje_idLabel.Text = "skladistenje id:";
			// 
			// lekovi_idLabel
			// 
			lekovi_idLabel.AutoSize = true;
			lekovi_idLabel.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lekovi_idLabel.Location = new System.Drawing.Point(361, 158);
			lekovi_idLabel.Name = "lekovi_idLabel";
			lekovi_idLabel.Size = new System.Drawing.Size(87, 23);
			lekovi_idLabel.TabIndex = 4;
			lekovi_idLabel.Text = "lekovi id:";
			// 
			// kolicinaLabel
			// 
			kolicinaLabel.AutoSize = true;
			kolicinaLabel.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			kolicinaLabel.Location = new System.Drawing.Point(574, 158);
			kolicinaLabel.Name = "kolicinaLabel";
			kolicinaLabel.Size = new System.Drawing.Size(81, 23);
			kolicinaLabel.TabIndex = 6;
			kolicinaLabel.Text = "kolicina:";
			// 
			// datumLabel
			// 
			datumLabel.AutoSize = true;
			datumLabel.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			datumLabel.Location = new System.Drawing.Point(783, 158);
			datumLabel.Name = "datumLabel";
			datumLabel.Size = new System.Drawing.Size(67, 23);
			datumLabel.TabIndex = 8;
			datumLabel.Text = "datum:";
			// 
			// dobavljaci_idLabel
			// 
			dobavljaci_idLabel.AutoSize = true;
			dobavljaci_idLabel.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dobavljaci_idLabel.Location = new System.Drawing.Point(1088, 158);
			dobavljaci_idLabel.Name = "dobavljaci_idLabel";
			dobavljaci_idLabel.Size = new System.Drawing.Size(120, 23);
			dobavljaci_idLabel.TabIndex = 10;
			dobavljaci_idLabel.Text = "dobavljaci id:";
			// 
			// apotekaDataSet
			// 
			this.apotekaDataSet.DataSetName = "apotekaDataSet";
			this.apotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// skladistenjeBindingSource
			// 
			this.skladistenjeBindingSource.DataMember = "skladistenje";
			this.skladistenjeBindingSource.DataSource = this.apotekaDataSet;
			// 
			// skladistenjeTableAdapter
			// 
			this.skladistenjeTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.racuniTableAdapter = null;
			this.tableAdapterManager.skladistenjeTableAdapter = this.skladistenjeTableAdapter;
			this.tableAdapterManager.UpdateOrder = Apoteka.apotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// skladistenjeDataGridView
			// 
			this.skladistenjeDataGridView.AutoGenerateColumns = false;
			this.skladistenjeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.skladistenjeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.skladistenjeDataGridView.DataSource = this.skladistenjeBindingSource;
			this.skladistenjeDataGridView.Location = new System.Drawing.Point(134, 213);
			this.skladistenjeDataGridView.Name = "skladistenjeDataGridView";
			this.skladistenjeDataGridView.Size = new System.Drawing.Size(1096, 285);
			this.skladistenjeDataGridView.TabIndex = 1;
			this.skladistenjeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.skladistenjeDataGridView_CellContentClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "skladistenje_id";
			this.dataGridViewTextBoxColumn1.HeaderText = "skladistenje_id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "lekovi_id";
			this.dataGridViewTextBoxColumn2.HeaderText = "lekovi_id";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "kolicina";
			this.dataGridViewTextBoxColumn3.HeaderText = "kolicina";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "datum";
			this.dataGridViewTextBoxColumn4.HeaderText = "datum";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "dobavljaci_id";
			this.dataGridViewTextBoxColumn5.HeaderText = "dobavljaci_id";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// skladistenje_idTextBox
			// 
			this.skladistenje_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladistenjeBindingSource, "skladistenje_id", true));
			this.skladistenje_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F);
			this.skladistenje_idTextBox.Location = new System.Drawing.Point(153, 181);
			this.skladistenje_idTextBox.Name = "skladistenje_idTextBox";
			this.skladistenje_idTextBox.Size = new System.Drawing.Size(101, 24);
			this.skladistenje_idTextBox.TabIndex = 3;
			this.skladistenje_idTextBox.TextChanged += new System.EventHandler(this.skladistenje_idTextBox_TextChanged);
			// 
			// lekovi_idTextBox
			// 
			this.lekovi_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladistenjeBindingSource, "lekovi_id", true));
			this.lekovi_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F);
			this.lekovi_idTextBox.Location = new System.Drawing.Point(364, 181);
			this.lekovi_idTextBox.Name = "lekovi_idTextBox";
			this.lekovi_idTextBox.Size = new System.Drawing.Size(100, 24);
			this.lekovi_idTextBox.TabIndex = 5;
			this.lekovi_idTextBox.TextChanged += new System.EventHandler(this.lekovi_idTextBox_TextChanged);
			// 
			// kolicinaTextBox
			// 
			this.kolicinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladistenjeBindingSource, "kolicina", true));
			this.kolicinaTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F);
			this.kolicinaTextBox.Location = new System.Drawing.Point(577, 179);
			this.kolicinaTextBox.Name = "kolicinaTextBox";
			this.kolicinaTextBox.Size = new System.Drawing.Size(100, 24);
			this.kolicinaTextBox.TabIndex = 7;
			// 
			// datumDateTimePicker
			// 
			this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.skladistenjeBindingSource, "datum", true));
			this.datumDateTimePicker.Font = new System.Drawing.Font("Sitka Small", 9.75F);
			this.datumDateTimePicker.Location = new System.Drawing.Point(786, 179);
			this.datumDateTimePicker.Name = "datumDateTimePicker";
			this.datumDateTimePicker.Size = new System.Drawing.Size(238, 24);
			this.datumDateTimePicker.TabIndex = 9;
			// 
			// dobavljaci_idTextBox
			// 
			this.dobavljaci_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.skladistenjeBindingSource, "dobavljaci_id", true));
			this.dobavljaci_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F);
			this.dobavljaci_idTextBox.Location = new System.Drawing.Point(1092, 181);
			this.dobavljaci_idTextBox.Name = "dobavljaci_idTextBox";
			this.dobavljaci_idTextBox.Size = new System.Drawing.Size(101, 24);
			this.dobavljaci_idTextBox.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(397, 519);
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
			this.button4.Location = new System.Drawing.Point(839, 519);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 45);
			this.button4.TabIndex = 36;
			this.button4.Text = "Stampaj";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(689, 519);
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
			this.button2.Location = new System.Drawing.Point(542, 519);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 45);
			this.button2.TabIndex = 34;
			this.button2.Text = "Obrisi ";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(536, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 35);
			this.label1.TabIndex = 39;
			this.label1.Text = "Podaci o skladistenju";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// SkladistenjeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1369, 698);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(skladistenje_idLabel);
			this.Controls.Add(this.skladistenje_idTextBox);
			this.Controls.Add(lekovi_idLabel);
			this.Controls.Add(this.lekovi_idTextBox);
			this.Controls.Add(kolicinaLabel);
			this.Controls.Add(this.kolicinaTextBox);
			this.Controls.Add(datumLabel);
			this.Controls.Add(this.datumDateTimePicker);
			this.Controls.Add(dobavljaci_idLabel);
			this.Controls.Add(this.dobavljaci_idTextBox);
			this.Controls.Add(this.skladistenjeDataGridView);
			this.Name = "SkladistenjeForm";
			this.Text = "SkladistenjeForm";
			this.Load += new System.EventHandler(this.SkladistenjeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.skladistenjeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.skladistenjeDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private apotekaDataSet apotekaDataSet;
		private System.Windows.Forms.BindingSource skladistenjeBindingSource;
		private apotekaDataSetTableAdapters.skladistenjeTableAdapter skladistenjeTableAdapter;
		private apotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView skladistenjeDataGridView;
		private System.Windows.Forms.TextBox skladistenje_idTextBox;
		private System.Windows.Forms.TextBox lekovi_idTextBox;
		private System.Windows.Forms.TextBox kolicinaTextBox;
		private System.Windows.Forms.DateTimePicker datumDateTimePicker;
		private System.Windows.Forms.TextBox dobavljaci_idTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
	}
}