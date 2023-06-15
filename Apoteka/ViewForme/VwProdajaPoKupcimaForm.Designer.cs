namespace Apoteka.ViewForme
{
	partial class VwProdajaPoKupcimaForm
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
			this.vw_prodajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.vw_prodajaTableAdapter = new Apoteka.apotekaDataSet1TableAdapters.vw_prodajaTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSet1TableAdapters.TableAdapterManager();
			this.vw_prodajaDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vw_prodajaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vw_prodajaDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(494, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(255, 35);
			this.label1.TabIndex = 40;
			this.label1.Text = "Prodaja po kupcima";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// apotekaDataSet1
			// 
			this.apotekaDataSet1.DataSetName = "apotekaDataSet1";
			this.apotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// vw_prodajaBindingSource
			// 
			this.vw_prodajaBindingSource.DataMember = "vw_prodaja";
			this.vw_prodajaBindingSource.DataSource = this.apotekaDataSet1;
			// 
			// vw_prodajaTableAdapter
			// 
			this.vw_prodajaTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.UpdateOrder = Apoteka.apotekaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// vw_prodajaDataGridView
			// 
			this.vw_prodajaDataGridView.AutoGenerateColumns = false;
			this.vw_prodajaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vw_prodajaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.vw_prodajaDataGridView.DataSource = this.vw_prodajaBindingSource;
			this.vw_prodajaDataGridView.Location = new System.Drawing.Point(159, 149);
			this.vw_prodajaDataGridView.Name = "vw_prodajaDataGridView";
			this.vw_prodajaDataGridView.Size = new System.Drawing.Size(1014, 387);
			this.vw_prodajaDataGridView.TabIndex = 41;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ime";
			this.dataGridViewTextBoxColumn1.HeaderText = "ime";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "prezime";
			this.dataGridViewTextBoxColumn2.HeaderText = "prezime";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "naziv";
			this.dataGridViewTextBoxColumn3.HeaderText = "naziv";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "kolicina";
			this.dataGridViewTextBoxColumn4.HeaderText = "kolicina";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "datum";
			this.dataGridViewTextBoxColumn5.HeaderText = "datum";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "ukupna_cena";
			this.dataGridViewTextBoxColumn6.HeaderText = "ukupna_cena";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// VwProdajaPoKupcimaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1277, 693);
			this.Controls.Add(this.vw_prodajaDataGridView);
			this.Controls.Add(this.label1);
			this.Name = "VwProdajaPoKupcimaForm";
			this.Text = "VwProdajaPoKupcimaForm";
			this.Load += new System.EventHandler(this.VwProdajaPoKupcimaForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vw_prodajaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vw_prodajaDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private apotekaDataSet1 apotekaDataSet1;
		private System.Windows.Forms.BindingSource vw_prodajaBindingSource;
		private apotekaDataSet1TableAdapters.vw_prodajaTableAdapter vw_prodajaTableAdapter;
		private apotekaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView vw_prodajaDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
	}
}