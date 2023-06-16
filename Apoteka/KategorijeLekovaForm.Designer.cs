namespace Apoteka
{
	partial class KategorijeLekovaForm
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
			System.Windows.Forms.Label kategorije_lekova_idLabel;
			System.Windows.Forms.Label nazivLabel;
			System.Windows.Forms.Label opisLabel;
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.apotekaDataSet = new Apoteka.apotekaDataSet();
			this.kategorije_lekovabindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.tableAdapterManager = new Apoteka.apotekaDataSetTableAdapters.TableAdapterManager();
			this.kategorije_lekovaTableAdapter1 = new Apoteka.apotekaDataSetTableAdapters.kategorije_lekovaTableAdapter();
			this.kategorije_lekovaDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kategorije_lekova_idTextBox = new System.Windows.Forms.TextBox();
			this.nazivTextBox = new System.Windows.Forms.TextBox();
			this.opisTextBox = new System.Windows.Forms.TextBox();
			kategorije_lekova_idLabel = new System.Windows.Forms.Label();
			nazivLabel = new System.Windows.Forms.Label();
			opisLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kategorije_lekovabindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kategorije_lekovaDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// kategorije_lekova_idLabel
			// 
			kategorije_lekova_idLabel.AutoSize = true;
			kategorije_lekova_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			kategorije_lekova_idLabel.Location = new System.Drawing.Point(250, 134);
			kategorije_lekova_idLabel.Name = "kategorije_lekova_idLabel";
			kategorije_lekova_idLabel.Size = new System.Drawing.Size(30, 19);
			kategorije_lekova_idLabel.TabIndex = 38;
			kategorije_lekova_idLabel.Text = "ID:";
			// 
			// nazivLabel
			// 
			nazivLabel.AutoSize = true;
			nazivLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nazivLabel.Location = new System.Drawing.Point(559, 134);
			nazivLabel.Name = "nazivLabel";
			nazivLabel.Size = new System.Drawing.Size(51, 19);
			nazivLabel.TabIndex = 40;
			nazivLabel.Text = "naziv:";
			// 
			// opisLabel
			// 
			opisLabel.AutoSize = true;
			opisLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			opisLabel.Location = new System.Drawing.Point(902, 134);
			opisLabel.Name = "opisLabel";
			opisLabel.Size = new System.Drawing.Size(43, 19);
			opisLabel.TabIndex = 42;
			opisLabel.Text = "opis:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(403, 491);
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
			this.button4.Location = new System.Drawing.Point(845, 491);
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
			this.button3.Location = new System.Drawing.Point(695, 491);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 45);
			this.button3.TabIndex = 35;
			this.button3.Text = "Sacuvaj";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(548, 491);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 45);
			this.button2.TabIndex = 34;
			this.button2.Text = "Obrisi ";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(490, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(371, 35);
			this.label1.TabIndex = 38;
			this.label1.Text = "Podaci o kategorijama lekova";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// apotekaDataSet
			// 
			this.apotekaDataSet.DataSetName = "apotekaDataSet";
			this.apotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// kategorije_lekovabindingSource1
			// 
			this.kategorije_lekovabindingSource1.DataMember = "kategorije_lekova";
			this.kategorije_lekovabindingSource1.DataSource = this.apotekaDataSet;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.ceneTableAdapter = null;
			this.tableAdapterManager.dobavljaciTableAdapter = null;
			this.tableAdapterManager.historija_prodajeTableAdapter = null;
			this.tableAdapterManager.kategorije_lekovaTableAdapter = this.kategorije_lekovaTableAdapter1;
			this.tableAdapterManager.kupciTableAdapter = null;
			this.tableAdapterManager.lekoviTableAdapter = null;
			this.tableAdapterManager.narudzbineTableAdapter = null;
			this.tableAdapterManager.promocije_popustiTableAdapter = null;
			this.tableAdapterManager.racuniTableAdapter = null;
			this.tableAdapterManager.skladistenjeTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Apoteka.apotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// kategorije_lekovaTableAdapter1
			// 
			this.kategorije_lekovaTableAdapter1.ClearBeforeFill = true;
			// 
			// kategorije_lekovaDataGridView
			// 
			this.kategorije_lekovaDataGridView.AutoGenerateColumns = false;
			this.kategorije_lekovaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.kategorije_lekovaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.kategorije_lekovaDataGridView.DataSource = this.kategorije_lekovabindingSource1;
			this.kategorije_lekovaDataGridView.Location = new System.Drawing.Point(167, 199);
			this.kategorije_lekovaDataGridView.Name = "kategorije_lekovaDataGridView";
			this.kategorije_lekovaDataGridView.Size = new System.Drawing.Size(1002, 260);
			this.kategorije_lekovaDataGridView.TabIndex = 38;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "kategorije_lekova_id";
			this.dataGridViewTextBoxColumn1.HeaderText = "kategorije_lekova_id";
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
			this.dataGridViewTextBoxColumn3.DataPropertyName = "opis";
			this.dataGridViewTextBoxColumn3.HeaderText = "opis";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// kategorije_lekova_idTextBox
			// 
			this.kategorije_lekova_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategorije_lekovabindingSource1, "kategorije_lekova_id", true));
			this.kategorije_lekova_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F);
			this.kategorije_lekova_idTextBox.Location = new System.Drawing.Point(254, 156);
			this.kategorije_lekova_idTextBox.Name = "kategorije_lekova_idTextBox";
			this.kategorije_lekova_idTextBox.Size = new System.Drawing.Size(81, 24);
			this.kategorije_lekova_idTextBox.TabIndex = 39;
			// 
			// nazivTextBox
			// 
			this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategorije_lekovabindingSource1, "naziv", true));
			this.nazivTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F);
			this.nazivTextBox.Location = new System.Drawing.Point(563, 156);
			this.nazivTextBox.Name = "nazivTextBox";
			this.nazivTextBox.Size = new System.Drawing.Size(100, 24);
			this.nazivTextBox.TabIndex = 41;
			// 
			// opisTextBox
			// 
			this.opisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategorije_lekovabindingSource1, "opis", true));
			this.opisTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F);
			this.opisTextBox.Location = new System.Drawing.Point(906, 156);
			this.opisTextBox.Name = "opisTextBox";
			this.opisTextBox.Size = new System.Drawing.Size(227, 24);
			this.opisTextBox.TabIndex = 43;
			// 
			// KategorijeLekovaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1338, 596);
			this.Controls.Add(kategorije_lekova_idLabel);
			this.Controls.Add(this.kategorije_lekova_idTextBox);
			this.Controls.Add(nazivLabel);
			this.Controls.Add(this.nazivTextBox);
			this.Controls.Add(opisLabel);
			this.Controls.Add(this.opisTextBox);
			this.Controls.Add(this.kategorije_lekovaDataGridView);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Name = "KategorijeLekovaForm";
			this.Text = "KategorijeLekovaForm";
			this.Load += new System.EventHandler(this.KategorijeLekovaForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kategorije_lekovabindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kategorije_lekovaDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private apotekaDataSet apotekaDataSet;
		private System.Windows.Forms.BindingSource kategorije_lekovabindingSource1;
		private apotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView kategorije_lekovaDataGridView;
		private apotekaDataSetTableAdapters.kategorije_lekovaTableAdapter kategorije_lekovaTableAdapter1;
		private System.Windows.Forms.TextBox kategorije_lekova_idTextBox;
		private System.Windows.Forms.TextBox nazivTextBox;
		private System.Windows.Forms.TextBox opisTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	}
}