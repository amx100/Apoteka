namespace Apoteka
{
	partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.apotekaDataSet = new Apoteka.apotekaDataSet();
			this.lekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lekoviTableAdapter = new Apoteka.apotekaDataSetTableAdapters.lekoviTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSetTableAdapters.TableAdapterManager();
			this.nazivTextBox = new System.Windows.Forms.TextBox();
			this.sastavTextBox = new System.Windows.Forms.TextBox();
			this.doziranje_mgTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lekoviDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.lekoviBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.lekoviBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.lekovi_idTextBox = new System.Windows.Forms.TextBox();
			this.promocije_popusti_idTextBox = new System.Windows.Forms.TextBox();
			this.kategorije_lekova_idTextBox = new System.Windows.Forms.TextBox();
			this.rok_trajanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.uputstvoTextBox = new System.Windows.Forms.TextBox();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
			nazivLabel = new System.Windows.Forms.Label();
			sastavLabel = new System.Windows.Forms.Label();
			doziranje_mgLabel = new System.Windows.Forms.Label();
			lekovi_idLabel = new System.Windows.Forms.Label();
			promocije_popusti_idLabel = new System.Windows.Forms.Label();
			uputstvoLabel = new System.Windows.Forms.Label();
			rok_trajanjaLabel = new System.Windows.Forms.Label();
			kategorije_lekova_idLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lekoviBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lekoviDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lekoviBindingNavigator)).BeginInit();
			this.lekoviBindingNavigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// nazivLabel
			// 
			nazivLabel.AutoSize = true;
			nazivLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nazivLabel.Location = new System.Drawing.Point(108, 99);
			nazivLabel.Name = "nazivLabel";
			nazivLabel.Size = new System.Drawing.Size(50, 19);
			nazivLabel.TabIndex = 3;
			nazivLabel.Text = "naziv:";
			// 
			// sastavLabel
			// 
			sastavLabel.AutoSize = true;
			sastavLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			sastavLabel.Location = new System.Drawing.Point(254, 99);
			sastavLabel.Name = "sastavLabel";
			sastavLabel.Size = new System.Drawing.Size(57, 19);
			sastavLabel.TabIndex = 5;
			sastavLabel.Text = "sastav:";
			// 
			// doziranje_mgLabel
			// 
			doziranje_mgLabel.AutoSize = true;
			doziranje_mgLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			doziranje_mgLabel.Location = new System.Drawing.Point(380, 99);
			doziranje_mgLabel.Name = "doziranje_mgLabel";
			doziranje_mgLabel.Size = new System.Drawing.Size(100, 19);
			doziranje_mgLabel.TabIndex = 7;
			doziranje_mgLabel.Text = "doziranje mg:";
			// 
			// lekovi_idLabel
			// 
			lekovi_idLabel.AutoSize = true;
			lekovi_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F);
			lekovi_idLabel.Location = new System.Drawing.Point(12, 100);
			lekovi_idLabel.Name = "lekovi_idLabel";
			lekovi_idLabel.Size = new System.Drawing.Size(72, 19);
			lekovi_idLabel.TabIndex = 23;
			lekovi_idLabel.Text = "lekovi id:";
			lekovi_idLabel.Click += new System.EventHandler(this.lekovi_idLabel_Click_1);
			// 
			// promocije_popusti_idLabel
			// 
			promocije_popusti_idLabel.AutoSize = true;
			promocije_popusti_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			promocije_popusti_idLabel.Location = new System.Drawing.Point(861, 101);
			promocije_popusti_idLabel.Name = "promocije_popusti_idLabel";
			promocije_popusti_idLabel.Size = new System.Drawing.Size(65, 19);
			promocije_popusti_idLabel.TabIndex = 15;
			promocije_popusti_idLabel.Text = "prom id:";
			// 
			// uputstvoLabel
			// 
			uputstvoLabel.AutoSize = true;
			uputstvoLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			uputstvoLabel.Location = new System.Drawing.Point(498, 99);
			uputstvoLabel.Name = "uputstvoLabel";
			uputstvoLabel.Size = new System.Drawing.Size(71, 19);
			uputstvoLabel.TabIndex = 9;
			uputstvoLabel.Text = "uputstvo:";
			// 
			// rok_trajanjaLabel
			// 
			rok_trajanjaLabel.AutoSize = true;
			rok_trajanjaLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			rok_trajanjaLabel.Location = new System.Drawing.Point(612, 100);
			rok_trajanjaLabel.Name = "rok_trajanjaLabel";
			rok_trajanjaLabel.Size = new System.Drawing.Size(93, 19);
			rok_trajanjaLabel.TabIndex = 11;
			rok_trajanjaLabel.Text = "rok trajanja:";
			// 
			// kategorije_lekova_idLabel
			// 
			kategorije_lekova_idLabel.AutoSize = true;
			kategorije_lekova_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			kategorije_lekova_idLabel.Location = new System.Drawing.Point(942, 101);
			kategorije_lekova_idLabel.Name = "kategorije_lekova_idLabel";
			kategorije_lekova_idLabel.Size = new System.Drawing.Size(100, 19);
			kategorije_lekova_idLabel.TabIndex = 13;
			kategorije_lekova_idLabel.Text = "kat lekova id:";
			// 
			// apotekaDataSet
			// 
			this.apotekaDataSet.DataSetName = "apotekaDataSet";
			this.apotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lekoviBindingSource
			// 
			this.lekoviBindingSource.DataMember = "lekovi";
			this.lekoviBindingSource.DataSource = this.apotekaDataSet;
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
			// nazivTextBox
			// 
			this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "naziv", true));
			this.nazivTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nazivTextBox.Location = new System.Drawing.Point(112, 126);
			this.nazivTextBox.Name = "nazivTextBox";
			this.nazivTextBox.Size = new System.Drawing.Size(115, 24);
			this.nazivTextBox.TabIndex = 4;
			// 
			// sastavTextBox
			// 
			this.sastavTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "sastav", true));
			this.sastavTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sastavTextBox.Location = new System.Drawing.Point(258, 126);
			this.sastavTextBox.Name = "sastavTextBox";
			this.sastavTextBox.Size = new System.Drawing.Size(97, 24);
			this.sastavTextBox.TabIndex = 6;
			// 
			// doziranje_mgTextBox
			// 
			this.doziranje_mgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "doziranje_mg", true));
			this.doziranje_mgTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.doziranje_mgTextBox.Location = new System.Drawing.Point(384, 127);
			this.doziranje_mgTextBox.Name = "doziranje_mgTextBox";
			this.doziranje_mgTextBox.Size = new System.Drawing.Size(55, 24);
			this.doziranje_mgTextBox.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(410, 53);
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
			this.lekoviDataGridView.Location = new System.Drawing.Point(150, 175);
			this.lekoviDataGridView.Name = "lekoviDataGridView";
			this.lekoviDataGridView.Size = new System.Drawing.Size(846, 238);
			this.lekoviDataGridView.TabIndex = 18;
			this.lekoviDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lekoviDataGridView_CellContentClick_1);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "lekovi_id";
			this.dataGridViewTextBoxColumn1.HeaderText = "lekovi_id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "naziv";
			this.dataGridViewTextBoxColumn2.HeaderText = "naziv";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "sastav";
			this.dataGridViewTextBoxColumn3.HeaderText = "sastav";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "doziranje_mg";
			this.dataGridViewTextBoxColumn4.HeaderText = "doziranje_mg";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "uputstvo";
			this.dataGridViewTextBoxColumn5.HeaderText = "uputstvo";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "rok_trajanja";
			this.dataGridViewTextBoxColumn6.HeaderText = "rok_trajanja";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "kategorije_lekova_id";
			this.dataGridViewTextBoxColumn7.HeaderText = "kategorije_lekova_id";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "promocije_popusti_id";
			this.dataGridViewTextBoxColumn8.HeaderText = "promocije_popusti_id";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 28);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(58, 28);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 28);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 28);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
			// 
			// lekoviBindingNavigatorSaveItem
			// 
			this.lekoviBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.lekoviBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lekoviBindingNavigatorSaveItem.Image")));
			this.lekoviBindingNavigatorSaveItem.Name = "lekoviBindingNavigatorSaveItem";
			this.lekoviBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 28);
			this.lekoviBindingNavigatorSaveItem.Text = "Save Data";
			this.lekoviBindingNavigatorSaveItem.Click += new System.EventHandler(this.lekoviBindingNavigatorSaveItem_Click);
			// 
			// lekoviBindingNavigator
			// 
			this.lekoviBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.lekoviBindingNavigator.BindingSource = this.lekoviBindingSource;
			this.lekoviBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.lekoviBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.lekoviBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
			this.lekoviBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.lekoviBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.toolStripLabel2,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel5,
            this.bindingNavigatorAddNewItem,
            this.toolStripLabel4,
            this.bindingNavigatorDeleteItem,
            this.toolStripLabel6,
            this.lekoviBindingNavigatorSaveItem});
			this.lekoviBindingNavigator.Location = new System.Drawing.Point(243, 438);
			this.lekoviBindingNavigator.MoveFirstItem = null;
			this.lekoviBindingNavigator.MoveLastItem = null;
			this.lekoviBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.lekoviBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.lekoviBindingNavigator.Name = "lekoviBindingNavigator";
			this.lekoviBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.lekoviBindingNavigator.Size = new System.Drawing.Size(546, 31);
			this.lekoviBindingNavigator.TabIndex = 0;
			this.lekoviBindingNavigator.Text = "bindingNavigator1";
			this.lekoviBindingNavigator.RefreshItems += new System.EventHandler(this.lekoviBindingNavigator_RefreshItems);
			// 
			// lekovi_idTextBox
			// 
			this.lekovi_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "lekovi_id", true));
			this.lekovi_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F);
			this.lekovi_idTextBox.Location = new System.Drawing.Point(16, 128);
			this.lekovi_idTextBox.Name = "lekovi_idTextBox";
			this.lekovi_idTextBox.Size = new System.Drawing.Size(53, 24);
			this.lekovi_idTextBox.TabIndex = 24;
			// 
			// promocije_popusti_idTextBox
			// 
			this.promocije_popusti_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "promocije_popusti_id", true));
			this.promocije_popusti_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.promocije_popusti_idTextBox.Location = new System.Drawing.Point(863, 128);
			this.promocije_popusti_idTextBox.Name = "promocije_popusti_idTextBox";
			this.promocije_popusti_idTextBox.Size = new System.Drawing.Size(63, 24);
			this.promocije_popusti_idTextBox.TabIndex = 16;
			// 
			// kategorije_lekova_idTextBox
			// 
			this.kategorije_lekova_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "kategorije_lekova_id", true));
			this.kategorije_lekova_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kategorije_lekova_idTextBox.Location = new System.Drawing.Point(945, 129);
			this.kategorije_lekova_idTextBox.Name = "kategorije_lekova_idTextBox";
			this.kategorije_lekova_idTextBox.Size = new System.Drawing.Size(65, 24);
			this.kategorije_lekova_idTextBox.TabIndex = 14;
			// 
			// rok_trajanjaDateTimePicker
			// 
			this.rok_trajanjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lekoviBindingSource, "rok_trajanja", true));
			this.rok_trajanjaDateTimePicker.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rok_trajanjaDateTimePicker.Location = new System.Drawing.Point(616, 127);
			this.rok_trajanjaDateTimePicker.Name = "rok_trajanjaDateTimePicker";
			this.rok_trajanjaDateTimePicker.Size = new System.Drawing.Size(229, 24);
			this.rok_trajanjaDateTimePicker.TabIndex = 12;
			// 
			// uputstvoTextBox
			// 
			this.uputstvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "uputstvo", true));
			this.uputstvoTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uputstvoTextBox.Location = new System.Drawing.Point(496, 127);
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
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 28);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(57, 28);
			this.toolStripLabel2.Text = "Sledeci";
			this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(73, 28);
			this.toolStripLabel3.Text = "Prethodni";
			// 
			// toolStripLabel4
			// 
			this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.toolStripLabel4.Name = "toolStripLabel4";
			this.toolStripLabel4.Size = new System.Drawing.Size(52, 28);
			this.toolStripLabel4.Text = "Izbirisi";
			// 
			// toolStripLabel5
			// 
			this.toolStripLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.toolStripLabel5.Name = "toolStripLabel5";
			this.toolStripLabel5.Size = new System.Drawing.Size(50, 28);
			this.toolStripLabel5.Text = "Dodaj";
			// 
			// toolStripLabel6
			// 
			this.toolStripLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.toolStripLabel6.Name = "toolStripLabel6";
			this.toolStripLabel6.Size = new System.Drawing.Size(59, 28);
			this.toolStripLabel6.Text = "Sacuvaj";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1201, 541);
			this.Controls.Add(lekovi_idLabel);
			this.Controls.Add(this.lekovi_idTextBox);
			this.Controls.Add(this.lekoviDataGridView);
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
			this.Controls.Add(this.lekoviBindingNavigator);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lekoviBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lekoviDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lekoviBindingNavigator)).EndInit();
			this.lekoviBindingNavigator.ResumeLayout(false);
			this.lekoviBindingNavigator.PerformLayout();
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
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton lekoviBindingNavigatorSaveItem;
		private System.Windows.Forms.BindingNavigator lekoviBindingNavigator;
		private System.Windows.Forms.TextBox lekovi_idTextBox;
		private System.Windows.Forms.TextBox promocije_popusti_idTextBox;
		private System.Windows.Forms.TextBox kategorije_lekova_idTextBox;
		private System.Windows.Forms.DateTimePicker rok_trajanjaDateTimePicker;
		private System.Windows.Forms.TextBox uputstvoTextBox;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripLabel toolStripLabel5;
		private System.Windows.Forms.ToolStripLabel toolStripLabel4;
		private System.Windows.Forms.ToolStripLabel toolStripLabel6;
	}
}