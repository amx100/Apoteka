namespace Apoteka
{
	partial class HistorijaProdajeForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorijaProdajeForm));
			System.Windows.Forms.Label historija_prodaje_idLabel;
			System.Windows.Forms.Label lekovi_idLabel;
			System.Windows.Forms.Label kupci_idLabel;
			System.Windows.Forms.Label kolicinaLabel;
			System.Windows.Forms.Label datumLabel;
			this.apotekaDataSet = new Apoteka.apotekaDataSet();
			this.historija_prodajeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.historija_prodajeTableAdapter = new Apoteka.apotekaDataSetTableAdapters.historija_prodajeTableAdapter();
			this.tableAdapterManager = new Apoteka.apotekaDataSetTableAdapters.TableAdapterManager();
			this.historija_prodajeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.historija_prodajeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.historija_prodajeDataGridView = new System.Windows.Forms.DataGridView();
			this.historija_prodaje_idTextBox = new System.Windows.Forms.TextBox();
			this.lekovi_idTextBox = new System.Windows.Forms.TextBox();
			this.kupci_idTextBox = new System.Windows.Forms.TextBox();
			this.kolicinaTextBox = new System.Windows.Forms.TextBox();
			this.datumDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			historija_prodaje_idLabel = new System.Windows.Forms.Label();
			lekovi_idLabel = new System.Windows.Forms.Label();
			kupci_idLabel = new System.Windows.Forms.Label();
			kolicinaLabel = new System.Windows.Forms.Label();
			datumLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.historija_prodajeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.historija_prodajeBindingNavigator)).BeginInit();
			this.historija_prodajeBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.historija_prodajeDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// apotekaDataSet
			// 
			this.apotekaDataSet.DataSetName = "apotekaDataSet";
			this.apotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// historija_prodajeBindingSource
			// 
			this.historija_prodajeBindingSource.DataMember = "historija_prodaje";
			this.historija_prodajeBindingSource.DataSource = this.apotekaDataSet;
			// 
			// historija_prodajeTableAdapter
			// 
			this.historija_prodajeTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.ceneTableAdapter = null;
			this.tableAdapterManager.dobavljaciTableAdapter = null;
			this.tableAdapterManager.historija_prodajeTableAdapter = this.historija_prodajeTableAdapter;
			this.tableAdapterManager.kategorije_lekovaTableAdapter = null;
			this.tableAdapterManager.kupciTableAdapter = null;
			this.tableAdapterManager.lekoviTableAdapter = null;
			this.tableAdapterManager.narudzbineTableAdapter = null;
			this.tableAdapterManager.promocije_popustiTableAdapter = null;
			this.tableAdapterManager.racuniTableAdapter = null;
			this.tableAdapterManager.skladistenjeTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Apoteka.apotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// historija_prodajeBindingNavigator
			// 
			this.historija_prodajeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.historija_prodajeBindingNavigator.BindingSource = this.historija_prodajeBindingSource;
			this.historija_prodajeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.historija_prodajeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.historija_prodajeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.historija_prodajeBindingNavigatorSaveItem});
			this.historija_prodajeBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.historija_prodajeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.historija_prodajeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.historija_prodajeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.historija_prodajeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.historija_prodajeBindingNavigator.Name = "historija_prodajeBindingNavigator";
			this.historija_prodajeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.historija_prodajeBindingNavigator.Size = new System.Drawing.Size(1331, 25);
			this.historija_prodajeBindingNavigator.TabIndex = 0;
			this.historija_prodajeBindingNavigator.Text = "bindingNavigator1";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// historija_prodajeBindingNavigatorSaveItem
			// 
			this.historija_prodajeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.historija_prodajeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("historija_prodajeBindingNavigatorSaveItem.Image")));
			this.historija_prodajeBindingNavigatorSaveItem.Name = "historija_prodajeBindingNavigatorSaveItem";
			this.historija_prodajeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.historija_prodajeBindingNavigatorSaveItem.Text = "Save Data";
			this.historija_prodajeBindingNavigatorSaveItem.Click += new System.EventHandler(this.historija_prodajeBindingNavigatorSaveItem_Click);
			// 
			// historija_prodajeDataGridView
			// 
			this.historija_prodajeDataGridView.AutoGenerateColumns = false;
			this.historija_prodajeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.historija_prodajeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.historija_prodajeDataGridView.DataSource = this.historija_prodajeBindingSource;
			this.historija_prodajeDataGridView.Location = new System.Drawing.Point(170, 230);
			this.historija_prodajeDataGridView.Name = "historija_prodajeDataGridView";
			this.historija_prodajeDataGridView.Size = new System.Drawing.Size(1002, 260);
			this.historija_prodajeDataGridView.TabIndex = 1;
			// 
			// historija_prodaje_idLabel
			// 
			historija_prodaje_idLabel.AutoSize = true;
			historija_prodaje_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			historija_prodaje_idLabel.Location = new System.Drawing.Point(203, 167);
			historija_prodaje_idLabel.Name = "historija_prodaje_idLabel";
			historija_prodaje_idLabel.Size = new System.Drawing.Size(150, 19);
			historija_prodaje_idLabel.TabIndex = 2;
			historija_prodaje_idLabel.Text = "historija prodaje id:";
			// 
			// historija_prodaje_idTextBox
			// 
			this.historija_prodaje_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historija_prodajeBindingSource, "historija_prodaje_id", true));
			this.historija_prodaje_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.historija_prodaje_idTextBox.Location = new System.Drawing.Point(207, 189);
			this.historija_prodaje_idTextBox.Name = "historija_prodaje_idTextBox";
			this.historija_prodaje_idTextBox.Size = new System.Drawing.Size(146, 22);
			this.historija_prodaje_idTextBox.TabIndex = 3;
			// 
			// lekovi_idLabel
			// 
			lekovi_idLabel.AutoSize = true;
			lekovi_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			lekovi_idLabel.Location = new System.Drawing.Point(405, 164);
			lekovi_idLabel.Name = "lekovi_idLabel";
			lekovi_idLabel.Size = new System.Drawing.Size(74, 19);
			lekovi_idLabel.TabIndex = 4;
			lekovi_idLabel.Text = "lekovi id:";
			// 
			// lekovi_idTextBox
			// 
			this.lekovi_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historija_prodajeBindingSource, "lekovi_id", true));
			this.lekovi_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lekovi_idTextBox.Location = new System.Drawing.Point(409, 186);
			this.lekovi_idTextBox.Name = "lekovi_idTextBox";
			this.lekovi_idTextBox.Size = new System.Drawing.Size(137, 22);
			this.lekovi_idTextBox.TabIndex = 5;
			// 
			// kupci_idLabel
			// 
			kupci_idLabel.AutoSize = true;
			kupci_idLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			kupci_idLabel.Location = new System.Drawing.Point(599, 164);
			kupci_idLabel.Name = "kupci_idLabel";
			kupci_idLabel.Size = new System.Drawing.Size(70, 19);
			kupci_idLabel.TabIndex = 6;
			kupci_idLabel.Text = "kupci id:";
			// 
			// kupci_idTextBox
			// 
			this.kupci_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historija_prodajeBindingSource, "kupci_id", true));
			this.kupci_idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kupci_idTextBox.Location = new System.Drawing.Point(603, 188);
			this.kupci_idTextBox.Name = "kupci_idTextBox";
			this.kupci_idTextBox.Size = new System.Drawing.Size(107, 22);
			this.kupci_idTextBox.TabIndex = 7;
			// 
			// kolicinaLabel
			// 
			kolicinaLabel.AutoSize = true;
			kolicinaLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			kolicinaLabel.Location = new System.Drawing.Point(780, 164);
			kolicinaLabel.Name = "kolicinaLabel";
			kolicinaLabel.Size = new System.Drawing.Size(69, 19);
			kolicinaLabel.TabIndex = 8;
			kolicinaLabel.Text = "kolicina:";
			// 
			// kolicinaTextBox
			// 
			this.kolicinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.historija_prodajeBindingSource, "kolicina", true));
			this.kolicinaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kolicinaTextBox.Location = new System.Drawing.Point(784, 186);
			this.kolicinaTextBox.Name = "kolicinaTextBox";
			this.kolicinaTextBox.Size = new System.Drawing.Size(106, 22);
			this.kolicinaTextBox.TabIndex = 9;
			// 
			// datumLabel
			// 
			datumLabel.AutoSize = true;
			datumLabel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			datumLabel.Location = new System.Drawing.Point(956, 164);
			datumLabel.Name = "datumLabel";
			datumLabel.Size = new System.Drawing.Size(59, 19);
			datumLabel.TabIndex = 10;
			datumLabel.Text = "datum:";
			// 
			// datumDateTimePicker
			// 
			this.datumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.historija_prodajeBindingSource, "datum", true));
			this.datumDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datumDateTimePicker.Location = new System.Drawing.Point(960, 186);
			this.datumDateTimePicker.Name = "datumDateTimePicker";
			this.datumDateTimePicker.Size = new System.Drawing.Size(212, 22);
			this.datumDateTimePicker.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(402, 528);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 45);
			this.button1.TabIndex = 45;
			this.button1.Text = "Dodaj ";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(844, 528);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(120, 45);
			this.button4.TabIndex = 44;
			this.button4.Text = "Stampaj";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(694, 528);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(120, 45);
			this.button3.TabIndex = 43;
			this.button3.Text = "Sacuvaj";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(547, 528);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 45);
			this.button2.TabIndex = 42;
			this.button2.Text = "Obrisi ";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "historija_prodaje_id";
			this.dataGridViewTextBoxColumn1.HeaderText = "historija_prodaje_id";
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
			this.dataGridViewTextBoxColumn3.DataPropertyName = "kupci_id";
			this.dataGridViewTextBoxColumn3.HeaderText = "kupci_id";
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.label1.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(541, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(322, 35);
			this.label1.TabIndex = 46;
			this.label1.Text = "Podaci o historiji prodaje";
			// 
			// HistorijaProdajeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1331, 616);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(historija_prodaje_idLabel);
			this.Controls.Add(this.historija_prodaje_idTextBox);
			this.Controls.Add(lekovi_idLabel);
			this.Controls.Add(this.lekovi_idTextBox);
			this.Controls.Add(kupci_idLabel);
			this.Controls.Add(this.kupci_idTextBox);
			this.Controls.Add(kolicinaLabel);
			this.Controls.Add(this.kolicinaTextBox);
			this.Controls.Add(datumLabel);
			this.Controls.Add(this.datumDateTimePicker);
			this.Controls.Add(this.historija_prodajeDataGridView);
			this.Controls.Add(this.historija_prodajeBindingNavigator);
			this.Name = "HistorijaProdajeForm";
			this.Text = "HistorijaProdajeForm";
			this.Load += new System.EventHandler(this.HistorijaProdajeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.historija_prodajeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.historija_prodajeBindingNavigator)).EndInit();
			this.historija_prodajeBindingNavigator.ResumeLayout(false);
			this.historija_prodajeBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.historija_prodajeDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private apotekaDataSet apotekaDataSet;
		private System.Windows.Forms.BindingSource historija_prodajeBindingSource;
		private apotekaDataSetTableAdapters.historija_prodajeTableAdapter historija_prodajeTableAdapter;
		private apotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator historija_prodajeBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton historija_prodajeBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView historija_prodajeDataGridView;
		private System.Windows.Forms.TextBox historija_prodaje_idTextBox;
		private System.Windows.Forms.TextBox lekovi_idTextBox;
		private System.Windows.Forms.TextBox kupci_idTextBox;
		private System.Windows.Forms.TextBox kolicinaTextBox;
		private System.Windows.Forms.DateTimePicker datumDateTimePicker;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Label label1;
	}
}