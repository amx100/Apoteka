namespace Apoteka.ViewForme
{
	partial class VwSumaProdajeForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.apotekaDataSet1 = new Apoteka.apotekaDataSet1();
			this.vw_suma_prodajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.vw_suma_prodajeTableAdapter = new Apoteka.apotekaDataSet1TableAdapters.vw_suma_prodajeTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSet1TableAdapters.TableAdapterManager();
			this.vw_suma_prodajeDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vw_suma_prodajeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vw_suma_prodajeDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(492, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(274, 35);
			this.label1.TabIndex = 40;
			this.label1.Text = "Suma prodaje Lekova";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// apotekaDataSet1
			// 
			this.apotekaDataSet1.DataSetName = "apotekaDataSet1";
			this.apotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// vw_suma_prodajeBindingSource
			// 
			this.vw_suma_prodajeBindingSource.DataMember = "vw_suma_prodaje";
			this.vw_suma_prodajeBindingSource.DataSource = this.apotekaDataSet1;
			// 
			// vw_suma_prodajeTableAdapter
			// 
			this.vw_suma_prodajeTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.UpdateOrder = Apoteka.apotekaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// vw_suma_prodajeDataGridView
			// 
			this.vw_suma_prodajeDataGridView.AutoGenerateColumns = false;
			this.vw_suma_prodajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vw_suma_prodajeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.vw_suma_prodajeDataGridView.DataSource = this.vw_suma_prodajeBindingSource;
			this.vw_suma_prodajeDataGridView.Location = new System.Drawing.Point(150, 173);
			this.vw_suma_prodajeDataGridView.Name = "vw_suma_prodajeDataGridView";
			this.vw_suma_prodajeDataGridView.Size = new System.Drawing.Size(1014, 387);
			this.vw_suma_prodajeDataGridView.TabIndex = 41;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "naziv";
			this.dataGridViewTextBoxColumn1.HeaderText = "naziv";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "ukupna_cena";
			this.dataGridViewTextBoxColumn2.HeaderText = "ukupna_cena";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "datum";
			this.dataGridViewTextBoxColumn3.HeaderText = "datum";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// VwSumaProdajeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1259, 679);
			this.Controls.Add(this.vw_suma_prodajeDataGridView);
			this.Controls.Add(this.label1);
			this.Name = "VwSumaProdajeForm";
			this.Text = "VwSumaProdaje";
			this.Load += new System.EventHandler(this.VwSumaProdajeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vw_suma_prodajeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vw_suma_prodajeDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private apotekaDataSet1 apotekaDataSet1;
		private System.Windows.Forms.BindingSource vw_suma_prodajeBindingSource;
		private apotekaDataSet1TableAdapters.vw_suma_prodajeTableAdapter vw_suma_prodajeTableAdapter;
		private apotekaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView vw_suma_prodajeDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	}
}