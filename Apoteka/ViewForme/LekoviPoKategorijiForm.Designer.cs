namespace Apoteka.ViewForme
{
	partial class LekoviPoKategorijiForm
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
			this.vw_lekovi_kategorijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.vw_lekovi_kategorijeTableAdapter = new Apoteka.apotekaDataSet1TableAdapters.vw_lekovi_kategorijeTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSet1TableAdapters.TableAdapterManager();
			this.vw_lekovi_kategorijeDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vw_lekovi_kategorijeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vw_lekovi_kategorijeDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(457, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 35);
			this.label1.TabIndex = 40;
			this.label1.Text = "Lekovi po kategoriji";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// apotekaDataSet1
			// 
			this.apotekaDataSet1.DataSetName = "apotekaDataSet1";
			this.apotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// vw_lekovi_kategorijeBindingSource
			// 
			this.vw_lekovi_kategorijeBindingSource.DataMember = "vw_lekovi_kategorije";
			this.vw_lekovi_kategorijeBindingSource.DataSource = this.apotekaDataSet1;
			// 
			// vw_lekovi_kategorijeTableAdapter
			// 
			this.vw_lekovi_kategorijeTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.UpdateOrder = Apoteka.apotekaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// vw_lekovi_kategorijeDataGridView
			// 
			this.vw_lekovi_kategorijeDataGridView.AutoGenerateColumns = false;
			this.vw_lekovi_kategorijeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.vw_lekovi_kategorijeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1});
			this.vw_lekovi_kategorijeDataGridView.DataSource = this.vw_lekovi_kategorijeBindingSource;
			this.vw_lekovi_kategorijeDataGridView.Location = new System.Drawing.Point(151, 158);
			this.vw_lekovi_kategorijeDataGridView.Name = "vw_lekovi_kategorijeDataGridView";
			this.vw_lekovi_kategorijeDataGridView.Size = new System.Drawing.Size(1014, 387);
			this.vw_lekovi_kategorijeDataGridView.TabIndex = 41;
			// 
			// dataGridViewTextBoxColumn2
			// 
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
			this.dataGridViewTextBoxColumn4.DataPropertyName = "kategorija";
			this.dataGridViewTextBoxColumn4.HeaderText = "kategorija";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "lekovi_id";
			this.dataGridViewTextBoxColumn1.HeaderText = "lekovi_id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// LekoviPoKategorijiForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1280, 687);
			this.Controls.Add(this.vw_lekovi_kategorijeDataGridView);
			this.Controls.Add(this.label1);
			this.Name = "LekoviPoKategorijiForm";
			this.Text = "LekoviPoKategorijiForm";
			this.Load += new System.EventHandler(this.LekoviPoKategorijiForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vw_lekovi_kategorijeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vw_lekovi_kategorijeDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private apotekaDataSet1 apotekaDataSet1;
		private System.Windows.Forms.BindingSource vw_lekovi_kategorijeBindingSource;
		private apotekaDataSet1TableAdapters.vw_lekovi_kategorijeTableAdapter vw_lekovi_kategorijeTableAdapter;
		private apotekaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView vw_lekovi_kategorijeDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
	}
}