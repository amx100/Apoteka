namespace Apoteka
{
	partial class KorisniciForm
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
			System.Windows.Forms.Label korisnikLabel;
			System.Windows.Forms.Label sifraLabel;
			System.Windows.Forms.Label nivoLabel;
			this.apotekaDataSet2 = new Apoteka.apotekaDataSet2();
			this.prijavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.prijavaTableAdapter = new Apoteka.apotekaDataSet2TableAdapters.prijavaTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSet2TableAdapters.TableAdapterManager();
			this.prijavaDataGridView = new System.Windows.Forms.DataGridView();
			this.korisnikTextBox = new System.Windows.Forms.TextBox();
			this.sifraTextBox = new System.Windows.Forms.TextBox();
			this.nivoTextBox = new System.Windows.Forms.TextBox();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			korisnikLabel = new System.Windows.Forms.Label();
			sifraLabel = new System.Windows.Forms.Label();
			nivoLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prijavaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prijavaDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// apotekaDataSet2
			// 
			this.apotekaDataSet2.DataSetName = "apotekaDataSet2";
			this.apotekaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// prijavaBindingSource
			// 
			this.prijavaBindingSource.DataMember = "prijava";
			this.prijavaBindingSource.DataSource = this.apotekaDataSet2;
			// 
			// prijavaTableAdapter
			// 
			this.prijavaTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.prijavaTableAdapter = this.prijavaTableAdapter;
			this.tableAdapterManager.promocije_popustiTableAdapter = null;
			this.tableAdapterManager.racuniTableAdapter = null;
			this.tableAdapterManager.skladistenjeTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Apoteka.apotekaDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// prijavaDataGridView
			// 
			this.prijavaDataGridView.AutoGenerateColumns = false;
			this.prijavaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.prijavaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.prijavaDataGridView.DataSource = this.prijavaBindingSource;
			this.prijavaDataGridView.Location = new System.Drawing.Point(151, 228);
			this.prijavaDataGridView.Name = "prijavaDataGridView";
			this.prijavaDataGridView.Size = new System.Drawing.Size(1003, 260);
			this.prijavaDataGridView.TabIndex = 1;
			// 
			// korisnikLabel
			// 
			korisnikLabel.AutoSize = true;
			korisnikLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			korisnikLabel.Location = new System.Drawing.Point(185, 178);
			korisnikLabel.Name = "korisnikLabel";
			korisnikLabel.Size = new System.Drawing.Size(71, 19);
			korisnikLabel.TabIndex = 2;
			korisnikLabel.Text = "korisnik:";
			// 
			// korisnikTextBox
			// 
			this.korisnikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prijavaBindingSource, "korisnik", true));
			this.korisnikTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.korisnikTextBox.Location = new System.Drawing.Point(189, 200);
			this.korisnikTextBox.Name = "korisnikTextBox";
			this.korisnikTextBox.Size = new System.Drawing.Size(159, 22);
			this.korisnikTextBox.TabIndex = 3;
			// 
			// sifraLabel
			// 
			sifraLabel.AutoSize = true;
			sifraLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			sifraLabel.Location = new System.Drawing.Point(509, 178);
			sifraLabel.Name = "sifraLabel";
			sifraLabel.Size = new System.Drawing.Size(47, 19);
			sifraLabel.TabIndex = 4;
			sifraLabel.Text = "sifra:";
			// 
			// sifraTextBox
			// 
			this.sifraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prijavaBindingSource, "sifra", true));
			this.sifraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sifraTextBox.Location = new System.Drawing.Point(513, 200);
			this.sifraTextBox.Name = "sifraTextBox";
			this.sifraTextBox.Size = new System.Drawing.Size(159, 22);
			this.sifraTextBox.TabIndex = 5;
			// 
			// nivoLabel
			// 
			nivoLabel.AutoSize = true;
			nivoLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nivoLabel.Location = new System.Drawing.Point(830, 178);
			nivoLabel.Name = "nivoLabel";
			nivoLabel.Size = new System.Drawing.Size(44, 19);
			nivoLabel.TabIndex = 6;
			nivoLabel.Text = "nivo:";
			// 
			// nivoTextBox
			// 
			this.nivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prijavaBindingSource, "nivo", true));
			this.nivoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nivoTextBox.Location = new System.Drawing.Point(834, 200);
			this.nivoTextBox.Name = "nivoTextBox";
			this.nivoTextBox.Size = new System.Drawing.Size(159, 22);
			this.nivoTextBox.TabIndex = 7;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "korisnik";
			this.dataGridViewTextBoxColumn1.HeaderText = "korisnik";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "sifra";
			this.dataGridViewTextBoxColumn2.HeaderText = "sifra";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "nivo";
			this.dataGridViewTextBoxColumn3.HeaderText = "nivo";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(478, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(269, 35);
			this.label1.TabIndex = 39;
			this.label1.Text = "Podaci o korisnicima";
			// 
			// KorisniciForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1306, 558);
			this.Controls.Add(this.label1);
			this.Controls.Add(korisnikLabel);
			this.Controls.Add(this.korisnikTextBox);
			this.Controls.Add(sifraLabel);
			this.Controls.Add(this.sifraTextBox);
			this.Controls.Add(nivoLabel);
			this.Controls.Add(this.nivoTextBox);
			this.Controls.Add(this.prijavaDataGridView);
			this.Name = "KorisniciForm";
			this.Text = "KorisniciForm";
			this.Load += new System.EventHandler(this.KorisniciForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prijavaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prijavaDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private apotekaDataSet2 apotekaDataSet2;
		private System.Windows.Forms.BindingSource prijavaBindingSource;
		private apotekaDataSet2TableAdapters.prijavaTableAdapter prijavaTableAdapter;
		private apotekaDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView prijavaDataGridView;
		private System.Windows.Forms.TextBox korisnikTextBox;
		private System.Windows.Forms.TextBox sifraTextBox;
		private System.Windows.Forms.TextBox nivoTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Label label1;
	}
}