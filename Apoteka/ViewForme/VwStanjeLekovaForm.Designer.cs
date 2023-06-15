namespace Apoteka.ViewForme
{
	partial class VwStanjeLekovaForm
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
			this.apotekaDataSet1 = new Apoteka.apotekaDataSet1();
			this.stanje_lekovaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.stanje_lekovaTableAdapter = new Apoteka.apotekaDataSet1TableAdapters.stanje_lekovaTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSet1TableAdapters.TableAdapterManager();
			this.stanje_lekovaDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stanje_lekovaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.stanje_lekovaDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// apotekaDataSet1
			// 
			this.apotekaDataSet1.DataSetName = "apotekaDataSet1";
			this.apotekaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// stanje_lekovaBindingSource
			// 
			this.stanje_lekovaBindingSource.DataMember = "stanje_lekova";
			this.stanje_lekovaBindingSource.DataSource = this.apotekaDataSet1;
			// 
			// stanje_lekovaTableAdapter
			// 
			this.stanje_lekovaTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.UpdateOrder = Apoteka.apotekaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// stanje_lekovaDataGridView
			// 
			this.stanje_lekovaDataGridView.AutoGenerateColumns = false;
			this.stanje_lekovaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.stanje_lekovaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.stanje_lekovaDataGridView.DataSource = this.stanje_lekovaBindingSource;
			this.stanje_lekovaDataGridView.Location = new System.Drawing.Point(174, 136);
			this.stanje_lekovaDataGridView.Name = "stanje_lekovaDataGridView";
			this.stanje_lekovaDataGridView.Size = new System.Drawing.Size(1014, 387);
			this.stanje_lekovaDataGridView.TabIndex = 1;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(484, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(308, 35);
			this.label1.TabIndex = 39;
			this.label1.Text = "Negativno stanje lekova";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// VwStanjeLekovaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1319, 627);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.stanje_lekovaDataGridView);
			this.Name = "VwStanjeLekovaForm";
			this.Text = "VwStanjeLekovaForm";
			this.Load += new System.EventHandler(this.VwStanjeLekovaForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stanje_lekovaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.stanje_lekovaDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private apotekaDataSet1 apotekaDataSet1;
		private System.Windows.Forms.BindingSource stanje_lekovaBindingSource;
		private apotekaDataSet1TableAdapters.stanje_lekovaTableAdapter stanje_lekovaTableAdapter;
		private apotekaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView stanje_lekovaDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.Label label1;
	}
}