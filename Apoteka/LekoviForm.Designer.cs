﻿namespace Apoteka
{
	partial class LekoviForm
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
			System.Windows.Forms.Label nazivLabel;
			System.Windows.Forms.Label sastavLabel;
			System.Windows.Forms.Label doziranje_mgLabel;
			System.Windows.Forms.Label lekovi_idLabel;
			System.Windows.Forms.Label promocije_popusti_idLabel;
			System.Windows.Forms.Label uputstvoLabel;
			System.Windows.Forms.Label rok_trajanjaLabel;
			System.Windows.Forms.Label kategorije_lekova_idLabel;
			this.nazivTextBox = new System.Windows.Forms.TextBox();
			this.sastavTextBox = new System.Windows.Forms.TextBox();
			this.doziranje_mgTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lekoviDataGridView = new System.Windows.Forms.DataGridView();
			this.lekovi_idTextBox = new System.Windows.Forms.TextBox();
			this.promocije_popusti_idTextBox = new System.Windows.Forms.TextBox();
			this.kategorije_lekova_idTextBox = new System.Windows.Forms.TextBox();
			this.rok_trajanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.uputstvoTextBox = new System.Windows.Forms.TextBox();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.apotekaDataSet = new Apoteka.apotekaDataSet();
			this.lekoviTableAdapter = new Apoteka.apotekaDataSetTableAdapters.lekoviTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSetTableAdapters.TableAdapterManager();
			nazivLabel = new System.Windows.Forms.Label();
			sastavLabel = new System.Windows.Forms.Label();
			doziranje_mgLabel = new System.Windows.Forms.Label();
			lekovi_idLabel = new System.Windows.Forms.Label();
			promocije_popusti_idLabel = new System.Windows.Forms.Label();
			uputstvoLabel = new System.Windows.Forms.Label();
			rok_trajanjaLabel = new System.Windows.Forms.Label();
			kategorije_lekova_idLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.lekoviDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lekoviBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// nazivLabel
			// 
			nazivLabel.AutoSize = true;
			nazivLabel.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nazivLabel.Location = new System.Drawing.Point(259, 157);
			nazivLabel.Name = "nazivLabel";
			nazivLabel.Size = new System.Drawing.Size(58, 23);
			nazivLabel.TabIndex = 3;
			nazivLabel.Text = "naziv:";
			// 
			// sastavLabel
			// 
			sastavLabel.AutoSize = true;
			sastavLabel.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			sastavLabel.Location = new System.Drawing.Point(405, 157);
			sastavLabel.Name = "sastavLabel";
			sastavLabel.Size = new System.Drawing.Size(66, 23);
			sastavLabel.TabIndex = 5;
			sastavLabel.Text = "sastav:";
			// 
			// doziranje_mgLabel
			// 
			doziranje_mgLabel.AutoSize = true;
			doziranje_mgLabel.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			doziranje_mgLabel.Location = new System.Drawing.Point(531, 157);
			doziranje_mgLabel.Name = "doziranje_mgLabel";
			doziranje_mgLabel.Size = new System.Drawing.Size(121, 23);
			doziranje_mgLabel.TabIndex = 7;
			doziranje_mgLabel.Text = "doziranje mg:";
			// 
			// lekovi_idLabel
			// 
			lekovi_idLabel.AutoSize = true;
			lekovi_idLabel.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lekovi_idLabel.Location = new System.Drawing.Point(163, 159);
			lekovi_idLabel.Name = "lekovi_idLabel";
			lekovi_idLabel.Size = new System.Drawing.Size(87, 23);
			lekovi_idLabel.TabIndex = 23;
			lekovi_idLabel.Text = "lekovi id:";
			lekovi_idLabel.Click += new System.EventHandler(this.lekovi_idLabel_Click_1);
			// 
			// promocije_popusti_idLabel
			// 
			promocije_popusti_idLabel.AutoSize = true;
			promocije_popusti_idLabel.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			promocije_popusti_idLabel.Location = new System.Drawing.Point(1012, 159);
			promocije_popusti_idLabel.Name = "promocije_popusti_idLabel";
			promocije_popusti_idLabel.Size = new System.Drawing.Size(80, 23);
			promocije_popusti_idLabel.TabIndex = 15;
			promocije_popusti_idLabel.Text = "prom id:";
			// 
			// uputstvoLabel
			// 
			uputstvoLabel.AutoSize = true;
			uputstvoLabel.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			uputstvoLabel.Location = new System.Drawing.Point(649, 157);
			uputstvoLabel.Name = "uputstvoLabel";
			uputstvoLabel.Size = new System.Drawing.Size(87, 23);
			uputstvoLabel.TabIndex = 9;
			uputstvoLabel.Text = "uputstvo:";
			// 
			// rok_trajanjaLabel
			// 
			rok_trajanjaLabel.AutoSize = true;
			rok_trajanjaLabel.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			rok_trajanjaLabel.Location = new System.Drawing.Point(763, 158);
			rok_trajanjaLabel.Name = "rok_trajanjaLabel";
			rok_trajanjaLabel.Size = new System.Drawing.Size(113, 23);
			rok_trajanjaLabel.TabIndex = 11;
			rok_trajanjaLabel.Text = "rok trajanja:";
			// 
			// kategorije_lekova_idLabel
			// 
			kategorije_lekova_idLabel.AutoSize = true;
			kategorije_lekova_idLabel.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			kategorije_lekova_idLabel.Location = new System.Drawing.Point(1093, 159);
			kategorije_lekova_idLabel.Name = "kategorije_lekova_idLabel";
			kategorije_lekova_idLabel.Size = new System.Drawing.Size(121, 23);
			kategorije_lekova_idLabel.TabIndex = 13;
			kategorije_lekova_idLabel.Text = "kat lekova id:";
			// 
			// nazivTextBox
			// 
			this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "naziv", true));
			this.nazivTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nazivTextBox.Location = new System.Drawing.Point(263, 184);
			this.nazivTextBox.Name = "nazivTextBox";
			this.nazivTextBox.Size = new System.Drawing.Size(115, 24);
			this.nazivTextBox.TabIndex = 4;
			this.nazivTextBox.TextChanged += new System.EventHandler(this.nazivTextBox_TextChanged);
			// 
			// sastavTextBox
			// 
			this.sastavTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "sastav", true));
			this.sastavTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sastavTextBox.Location = new System.Drawing.Point(409, 184);
			this.sastavTextBox.Name = "sastavTextBox";
			this.sastavTextBox.Size = new System.Drawing.Size(97, 24);
			this.sastavTextBox.TabIndex = 6;
			// 
			// doziranje_mgTextBox
			// 
			this.doziranje_mgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "doziranje_mg", true));
			this.doziranje_mgTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.doziranje_mgTextBox.Location = new System.Drawing.Point(535, 185);
			this.doziranje_mgTextBox.Name = "doziranje_mgTextBox";
			this.doziranje_mgTextBox.Size = new System.Drawing.Size(55, 24);
			this.doziranje_mgTextBox.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(545, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 35);
			this.label1.TabIndex = 17;
			this.label1.Text = "Podaci o lekovima";
			// 
			// lekoviDataGridView
			// 
			this.lekoviDataGridView.AutoGenerateColumns = false;
			this.lekoviDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.lekoviDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
			this.lekoviDataGridView.DataSource = this.lekoviBindingSource;
			this.lekoviDataGridView.Location = new System.Drawing.Point(167, 234);
			this.lekoviDataGridView.Name = "lekoviDataGridView";
			this.lekoviDataGridView.Size = new System.Drawing.Size(1018, 278);
			this.lekoviDataGridView.TabIndex = 18;
			this.lekoviDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lekoviDataGridView_CellContentClick_1);
			// 
			// lekovi_idTextBox
			// 
			this.lekovi_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "lekovi_id", true));
			this.lekovi_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F);
			this.lekovi_idTextBox.Location = new System.Drawing.Point(167, 186);
			this.lekovi_idTextBox.Name = "lekovi_idTextBox";
			this.lekovi_idTextBox.Size = new System.Drawing.Size(53, 24);
			this.lekovi_idTextBox.TabIndex = 24;
			this.lekovi_idTextBox.TextChanged += new System.EventHandler(this.lekovi_idTextBox_TextChanged_2);
			// 
			// promocije_popusti_idTextBox
			// 
			this.promocije_popusti_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "promocije_popusti_id", true));
			this.promocije_popusti_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.promocije_popusti_idTextBox.Location = new System.Drawing.Point(1014, 186);
			this.promocije_popusti_idTextBox.Name = "promocije_popusti_idTextBox";
			this.promocije_popusti_idTextBox.Size = new System.Drawing.Size(63, 24);
			this.promocije_popusti_idTextBox.TabIndex = 16;
			// 
			// kategorije_lekova_idTextBox
			// 
			this.kategorije_lekova_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "kategorije_lekova_id", true));
			this.kategorije_lekova_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kategorije_lekova_idTextBox.Location = new System.Drawing.Point(1096, 187);
			this.kategorije_lekova_idTextBox.Name = "kategorije_lekova_idTextBox";
			this.kategorije_lekova_idTextBox.Size = new System.Drawing.Size(65, 24);
			this.kategorije_lekova_idTextBox.TabIndex = 14;
			// 
			// rok_trajanjaDateTimePicker
			// 
			this.rok_trajanjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lekoviBindingSource, "rok_trajanja", true));
			this.rok_trajanjaDateTimePicker.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rok_trajanjaDateTimePicker.Location = new System.Drawing.Point(767, 185);
			this.rok_trajanjaDateTimePicker.Name = "rok_trajanjaDateTimePicker";
			this.rok_trajanjaDateTimePicker.Size = new System.Drawing.Size(229, 24);
			this.rok_trajanjaDateTimePicker.TabIndex = 12;
			// 
			// uputstvoTextBox
			// 
			this.uputstvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "uputstvo", true));
			this.uputstvoTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uputstvoTextBox.Location = new System.Drawing.Point(647, 185);
			this.uputstvoTextBox.Name = "uputstvoTextBox";
			this.uputstvoTextBox.Size = new System.Drawing.Size(94, 24);
			this.uputstvoTextBox.TabIndex = 10;
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
			this.toolStripLabel1.Text = "Dodaj ";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(551, 535);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 45);
			this.button2.TabIndex = 30;
			this.button2.Text = "Obrisi ";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(698, 535);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 45);
			this.button3.TabIndex = 31;
			this.button3.Text = "Sacuvaj";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(848, 535);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 45);
			this.button4.TabIndex = 32;
			this.button4.Text = "Stampaj";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(406, 535);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 45);
			this.button1.TabIndex = 33;
			this.button1.Text = "Dodaj ";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button5_Click);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "lekovi_id";
			this.dataGridViewTextBoxColumn1.HeaderText = "lekovi_id";
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
			this.dataGridViewTextBoxColumn3.DataPropertyName = "sastav";
			this.dataGridViewTextBoxColumn3.HeaderText = "sastav";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "doziranje_mg";
			this.dataGridViewTextBoxColumn4.HeaderText = "doziranje_mg";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "uputstvo";
			this.dataGridViewTextBoxColumn5.HeaderText = "uputstvo";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "rok_trajanja";
			this.dataGridViewTextBoxColumn6.HeaderText = "rok_trajanja";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "kategorije_lekova_id";
			this.dataGridViewTextBoxColumn7.HeaderText = "kategorije_lekova_id";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn8.DataPropertyName = "promocije_popusti_id";
			this.dataGridViewTextBoxColumn8.HeaderText = "promocije_popusti_id";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// lekoviBindingSource
			// 
			this.lekoviBindingSource.DataMember = "lekovi";
			this.lekoviBindingSource.DataSource = this.apotekaDataSet;
			// 
			// apotekaDataSet
			// 
			this.apotekaDataSet.DataSetName = "apotekaDataSet";
			this.apotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lekoviTableAdapter
			// 
			this.lekoviTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.ceneTableAdapter = null;
			this.tableAdapterManager.dobavljaciTableAdapter = null;
			this.tableAdapterManager.historija_prodajeTableAdapter = null;
			this.tableAdapterManager.kategorije_lekovaTableAdapter = null;
			this.tableAdapterManager.kupciTableAdapter = null;
			this.tableAdapterManager.lekoviTableAdapter = this.lekoviTableAdapter;
			this.tableAdapterManager.narudzbineTableAdapter = null;
			this.tableAdapterManager.promocije_popustiTableAdapter = null;
			this.tableAdapterManager.racuniTableAdapter = null;
			this.tableAdapterManager.skladistenjeTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Apoteka.apotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// LekoviForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1331, 631);
			this.Controls.Add(this.lekoviDataGridView);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(lekovi_idLabel);
			this.Controls.Add(this.lekovi_idTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(nazivLabel);
			this.Controls.Add(this.nazivTextBox);
			this.Controls.Add(sastavLabel);
			this.Controls.Add(this.sastavTextBox);
			this.Controls.Add(doziranje_mgLabel);
			this.Controls.Add(this.doziranje_mgTextBox);
			this.Controls.Add(uputstvoLabel);
			this.Controls.Add(this.uputstvoTextBox);
			this.Controls.Add(rok_trajanjaLabel);
			this.Controls.Add(this.rok_trajanjaDateTimePicker);
			this.Controls.Add(kategorije_lekova_idLabel);
			this.Controls.Add(this.kategorije_lekova_idTextBox);
			this.Controls.Add(promocije_popusti_idLabel);
			this.Controls.Add(this.promocije_popusti_idTextBox);
			this.Name = "LekoviForm";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.lekoviDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lekoviBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private apotekaDataSet apotekaDataSet;
		private System.Windows.Forms.BindingSource lekoviBindingSource;
		private apotekaDataSetTableAdapters.lekoviTableAdapter lekoviTableAdapter;
		private apotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox nazivTextBox;
		private System.Windows.Forms.TextBox sastavTextBox;
		private System.Windows.Forms.TextBox doziranje_mgTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView lekoviDataGridView;
		private System.Windows.Forms.TextBox lekovi_idTextBox;
		private System.Windows.Forms.TextBox promocije_popusti_idTextBox;
		private System.Windows.Forms.TextBox kategorije_lekova_idTextBox;
		private System.Windows.Forms.DateTimePicker rok_trajanjaDateTimePicker;
		private System.Windows.Forms.TextBox uputstvoTextBox;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
	}
}