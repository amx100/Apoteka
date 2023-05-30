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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			System.Windows.Forms.Label lekovi_idLabel;
			System.Windows.Forms.Label nazivLabel;
			System.Windows.Forms.Label sastavLabel;
			System.Windows.Forms.Label doziranje_mgLabel;
			System.Windows.Forms.Label uputstvoLabel;
			System.Windows.Forms.Label rok_trajanjaLabel;
			System.Windows.Forms.Label kategorije_lekova_idLabel;
			System.Windows.Forms.Label promocije_popusti_idLabel;
			this.apotekaDataSet = new Apoteka.apotekaDataSet();
			this.lekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lekoviTableAdapter = new Apoteka.apotekaDataSetTableAdapters.lekoviTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSetTableAdapters.TableAdapterManager();
			this.lekoviBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.lekoviBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.lekovi_idTextBox = new System.Windows.Forms.TextBox();
			this.nazivTextBox = new System.Windows.Forms.TextBox();
			this.sastavTextBox = new System.Windows.Forms.TextBox();
			this.doziranje_mgTextBox = new System.Windows.Forms.TextBox();
			this.uputstvoTextBox = new System.Windows.Forms.TextBox();
			this.rok_trajanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.kategorije_lekova_idTextBox = new System.Windows.Forms.TextBox();
			this.promocije_popusti_idTextBox = new System.Windows.Forms.TextBox();
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			lekovi_idLabel = new System.Windows.Forms.Label();
			nazivLabel = new System.Windows.Forms.Label();
			sastavLabel = new System.Windows.Forms.Label();
			doziranje_mgLabel = new System.Windows.Forms.Label();
			uputstvoLabel = new System.Windows.Forms.Label();
			rok_trajanjaLabel = new System.Windows.Forms.Label();
			kategorije_lekova_idLabel = new System.Windows.Forms.Label();
			promocije_popusti_idLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lekoviBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lekoviBindingNavigator)).BeginInit();
			this.lekoviBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lekoviDataGridView)).BeginInit();
			this.SuspendLayout();
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
			// lekoviBindingNavigator
			// 
			this.lekoviBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.lekoviBindingNavigator.BindingSource = this.lekoviBindingSource;
			this.lekoviBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.lekoviBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.lekoviBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.lekoviBindingNavigatorSaveItem});
			this.lekoviBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.lekoviBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.lekoviBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.lekoviBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.lekoviBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.lekoviBindingNavigator.Name = "lekoviBindingNavigator";
			this.lekoviBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.lekoviBindingNavigator.Size = new System.Drawing.Size(1201, 25);
			this.lekoviBindingNavigator.TabIndex = 0;
			this.lekoviBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// lekoviBindingNavigatorSaveItem
			// 
			this.lekoviBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.lekoviBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lekoviBindingNavigatorSaveItem.Image")));
			this.lekoviBindingNavigatorSaveItem.Name = "lekoviBindingNavigatorSaveItem";
			this.lekoviBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.lekoviBindingNavigatorSaveItem.Text = "Save Data";
			this.lekoviBindingNavigatorSaveItem.Click += new System.EventHandler(this.lekoviBindingNavigatorSaveItem_Click);
			// 
			// lekovi_idLabel
			// 
			lekovi_idLabel.AutoSize = true;
			lekovi_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lekovi_idLabel.Location = new System.Drawing.Point(11, 99);
			lekovi_idLabel.Name = "lekovi_idLabel";
			lekovi_idLabel.Size = new System.Drawing.Size(72, 19);
			lekovi_idLabel.TabIndex = 1;
			lekovi_idLabel.Text = "lekovi id:";
			lekovi_idLabel.Click += new System.EventHandler(this.lekovi_idLabel_Click);
			// 
			// lekovi_idTextBox
			// 
			this.lekovi_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "lekovi_id", true));
			this.lekovi_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lekovi_idTextBox.Location = new System.Drawing.Point(21, 126);
			this.lekovi_idTextBox.Name = "lekovi_idTextBox";
			this.lekovi_idTextBox.Size = new System.Drawing.Size(60, 24);
			this.lekovi_idTextBox.TabIndex = 2;
			this.lekovi_idTextBox.TextChanged += new System.EventHandler(this.lekovi_idTextBox_TextChanged_1);
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
			// nazivTextBox
			// 
			this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "naziv", true));
			this.nazivTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nazivTextBox.Location = new System.Drawing.Point(112, 126);
			this.nazivTextBox.Name = "nazivTextBox";
			this.nazivTextBox.Size = new System.Drawing.Size(132, 24);
			this.nazivTextBox.TabIndex = 4;
			// 
			// sastavLabel
			// 
			sastavLabel.AutoSize = true;
			sastavLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			sastavLabel.Location = new System.Drawing.Point(269, 99);
			sastavLabel.Name = "sastavLabel";
			sastavLabel.Size = new System.Drawing.Size(57, 19);
			sastavLabel.TabIndex = 5;
			sastavLabel.Text = "sastav:";
			// 
			// sastavTextBox
			// 
			this.sastavTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "sastav", true));
			this.sastavTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sastavTextBox.Location = new System.Drawing.Point(273, 126);
			this.sastavTextBox.Name = "sastavTextBox";
			this.sastavTextBox.Size = new System.Drawing.Size(114, 24);
			this.sastavTextBox.TabIndex = 6;
			// 
			// doziranje_mgLabel
			// 
			doziranje_mgLabel.AutoSize = true;
			doziranje_mgLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			doziranje_mgLabel.Location = new System.Drawing.Point(414, 99);
			doziranje_mgLabel.Name = "doziranje_mgLabel";
			doziranje_mgLabel.Size = new System.Drawing.Size(100, 19);
			doziranje_mgLabel.TabIndex = 7;
			doziranje_mgLabel.Text = "doziranje mg:";
			// 
			// doziranje_mgTextBox
			// 
			this.doziranje_mgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "doziranje_mg", true));
			this.doziranje_mgTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.doziranje_mgTextBox.Location = new System.Drawing.Point(418, 126);
			this.doziranje_mgTextBox.Name = "doziranje_mgTextBox";
			this.doziranje_mgTextBox.Size = new System.Drawing.Size(118, 24);
			this.doziranje_mgTextBox.TabIndex = 8;
			// 
			// uputstvoLabel
			// 
			uputstvoLabel.AutoSize = true;
			uputstvoLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			uputstvoLabel.Location = new System.Drawing.Point(563, 99);
			uputstvoLabel.Name = "uputstvoLabel";
			uputstvoLabel.Size = new System.Drawing.Size(71, 19);
			uputstvoLabel.TabIndex = 9;
			uputstvoLabel.Text = "uputstvo:";
			// 
			// uputstvoTextBox
			// 
			this.uputstvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "uputstvo", true));
			this.uputstvoTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uputstvoTextBox.Location = new System.Drawing.Point(567, 126);
			this.uputstvoTextBox.Name = "uputstvoTextBox";
			this.uputstvoTextBox.Size = new System.Drawing.Size(133, 24);
			this.uputstvoTextBox.TabIndex = 10;
			// 
			// rok_trajanjaLabel
			// 
			rok_trajanjaLabel.AutoSize = true;
			rok_trajanjaLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			rok_trajanjaLabel.Location = new System.Drawing.Point(731, 99);
			rok_trajanjaLabel.Name = "rok_trajanjaLabel";
			rok_trajanjaLabel.Size = new System.Drawing.Size(93, 19);
			rok_trajanjaLabel.TabIndex = 11;
			rok_trajanjaLabel.Text = "rok trajanja:";
			// 
			// rok_trajanjaDateTimePicker
			// 
			this.rok_trajanjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lekoviBindingSource, "rok_trajanja", true));
			this.rok_trajanjaDateTimePicker.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rok_trajanjaDateTimePicker.Location = new System.Drawing.Point(735, 126);
			this.rok_trajanjaDateTimePicker.Name = "rok_trajanjaDateTimePicker";
			this.rok_trajanjaDateTimePicker.Size = new System.Drawing.Size(109, 24);
			this.rok_trajanjaDateTimePicker.TabIndex = 12;
			// 
			// kategorije_lekova_idLabel
			// 
			kategorije_lekova_idLabel.AutoSize = true;
			kategorije_lekova_idLabel.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			kategorije_lekova_idLabel.Location = new System.Drawing.Point(942, 100);
			kategorije_lekova_idLabel.Name = "kategorije_lekova_idLabel";
			kategorije_lekova_idLabel.Size = new System.Drawing.Size(91, 18);
			kategorije_lekova_idLabel.TabIndex = 13;
			kategorije_lekova_idLabel.Text = "kat lekova id:";
			// 
			// kategorije_lekova_idTextBox
			// 
			this.kategorije_lekova_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "kategorije_lekova_id", true));
			this.kategorije_lekova_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kategorije_lekova_idTextBox.Location = new System.Drawing.Point(945, 126);
			this.kategorije_lekova_idTextBox.Name = "kategorije_lekova_idTextBox";
			this.kategorije_lekova_idTextBox.Size = new System.Drawing.Size(65, 24);
			this.kategorije_lekova_idTextBox.TabIndex = 14;
			// 
			// promocije_popusti_idLabel
			// 
			promocije_popusti_idLabel.AutoSize = true;
			promocije_popusti_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			promocije_popusti_idLabel.Location = new System.Drawing.Point(859, 99);
			promocije_popusti_idLabel.Name = "promocije_popusti_idLabel";
			promocije_popusti_idLabel.Size = new System.Drawing.Size(65, 19);
			promocije_popusti_idLabel.TabIndex = 15;
			promocije_popusti_idLabel.Text = "prom id:";
			// 
			// promocije_popusti_idTextBox
			// 
			this.promocije_popusti_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "promocije_popusti_id", true));
			this.promocije_popusti_idTextBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.promocije_popusti_idTextBox.Location = new System.Drawing.Point(863, 126);
			this.promocije_popusti_idTextBox.Name = "promocije_popusti_idTextBox";
			this.promocije_popusti_idTextBox.Size = new System.Drawing.Size(63, 24);
			this.promocije_popusti_idTextBox.TabIndex = 16;
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
			this.lekoviDataGridView.Location = new System.Drawing.Point(87, 175);
			this.lekoviDataGridView.Name = "lekoviDataGridView";
			this.lekoviDataGridView.Size = new System.Drawing.Size(839, 238);
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
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(278, 441);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 19;
			this.btnAdd.Text = "DODAJ";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(567, 441);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 20;
			this.btnDelete.Text = "OBRISI";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(428, 441);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 21;
			this.btnEdit.Text = "IZMENI";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(851, 441);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(75, 23);
			this.btnPrint.TabIndex = 22;
			this.btnPrint.Text = "STAMPAJ";
			this.btnPrint.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(703, 441);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 23;
			this.button1.Text = "SACUVAJ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1201, 541);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lekoviDataGridView);
			this.Controls.Add(this.label1);
			this.Controls.Add(lekovi_idLabel);
			this.Controls.Add(this.lekovi_idTextBox);
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
			((System.ComponentModel.ISupportInitialize)(this.lekoviBindingNavigator)).EndInit();
			this.lekoviBindingNavigator.ResumeLayout(false);
			this.lekoviBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lekoviDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private apotekaDataSet apotekaDataSet;
		private System.Windows.Forms.BindingSource lekoviBindingSource;
		private apotekaDataSetTableAdapters.lekoviTableAdapter lekoviTableAdapter;
		private apotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator lekoviBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton lekoviBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox lekovi_idTextBox;
		private System.Windows.Forms.TextBox nazivTextBox;
		private System.Windows.Forms.TextBox sastavTextBox;
		private System.Windows.Forms.TextBox doziranje_mgTextBox;
		private System.Windows.Forms.TextBox uputstvoTextBox;
		private System.Windows.Forms.DateTimePicker rok_trajanjaDateTimePicker;
		private System.Windows.Forms.TextBox kategorije_lekova_idTextBox;
		private System.Windows.Forms.TextBox promocije_popusti_idTextBox;
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
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button button1;
	}
}