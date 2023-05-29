namespace Apoteka
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
			this.lekoviBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.lekovi_idTextBox = new System.Windows.Forms.TextBox();
			this.nazivTextBox = new System.Windows.Forms.TextBox();
			this.sastavTextBox = new System.Windows.Forms.TextBox();
			this.doziranje_mgTextBox = new System.Windows.Forms.TextBox();
			this.uputstvoTextBox = new System.Windows.Forms.TextBox();
			this.rok_trajanjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.kategorije_lekova_idTextBox = new System.Windows.Forms.TextBox();
			this.promocije_popusti_idTextBox = new System.Windows.Forms.TextBox();
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
			this.lekoviBindingNavigator.Size = new System.Drawing.Size(800, 25);
			this.lekoviBindingNavigator.TabIndex = 0;
			this.lekoviBindingNavigator.Text = "bindingNavigator1";
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
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// lekoviBindingNavigatorSaveItem
			// 
			this.lekoviBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.lekoviBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lekoviBindingNavigatorSaveItem.Image")));
			this.lekoviBindingNavigatorSaveItem.Name = "lekoviBindingNavigatorSaveItem";
			this.lekoviBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
			this.lekoviBindingNavigatorSaveItem.Text = "Save Data";
			this.lekoviBindingNavigatorSaveItem.Click += new System.EventHandler(this.lekoviBindingNavigatorSaveItem_Click);
			// 
			// lekovi_idLabel
			// 
			lekovi_idLabel.AutoSize = true;
			lekovi_idLabel.Location = new System.Drawing.Point(237, 113);
			lekovi_idLabel.Name = "lekovi_idLabel";
			lekovi_idLabel.Size = new System.Drawing.Size(49, 13);
			lekovi_idLabel.TabIndex = 1;
			lekovi_idLabel.Text = "lekovi id:";
			// 
			// lekovi_idTextBox
			// 
			this.lekovi_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "lekovi_id", true));
			this.lekovi_idTextBox.Location = new System.Drawing.Point(346, 110);
			this.lekovi_idTextBox.Name = "lekovi_idTextBox";
			this.lekovi_idTextBox.Size = new System.Drawing.Size(200, 20);
			this.lekovi_idTextBox.TabIndex = 2;
			// 
			// nazivLabel
			// 
			nazivLabel.AutoSize = true;
			nazivLabel.Location = new System.Drawing.Point(237, 139);
			nazivLabel.Name = "nazivLabel";
			nazivLabel.Size = new System.Drawing.Size(35, 13);
			nazivLabel.TabIndex = 3;
			nazivLabel.Text = "naziv:";
			// 
			// nazivTextBox
			// 
			this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "naziv", true));
			this.nazivTextBox.Location = new System.Drawing.Point(346, 136);
			this.nazivTextBox.Name = "nazivTextBox";
			this.nazivTextBox.Size = new System.Drawing.Size(200, 20);
			this.nazivTextBox.TabIndex = 4;
			// 
			// sastavLabel
			// 
			sastavLabel.AutoSize = true;
			sastavLabel.Location = new System.Drawing.Point(237, 165);
			sastavLabel.Name = "sastavLabel";
			sastavLabel.Size = new System.Drawing.Size(41, 13);
			sastavLabel.TabIndex = 5;
			sastavLabel.Text = "sastav:";
			// 
			// sastavTextBox
			// 
			this.sastavTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "sastav", true));
			this.sastavTextBox.Location = new System.Drawing.Point(346, 162);
			this.sastavTextBox.Name = "sastavTextBox";
			this.sastavTextBox.Size = new System.Drawing.Size(200, 20);
			this.sastavTextBox.TabIndex = 6;
			// 
			// doziranje_mgLabel
			// 
			doziranje_mgLabel.AutoSize = true;
			doziranje_mgLabel.Location = new System.Drawing.Point(237, 191);
			doziranje_mgLabel.Name = "doziranje_mgLabel";
			doziranje_mgLabel.Size = new System.Drawing.Size(69, 13);
			doziranje_mgLabel.TabIndex = 7;
			doziranje_mgLabel.Text = "doziranje mg:";
			// 
			// doziranje_mgTextBox
			// 
			this.doziranje_mgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "doziranje_mg", true));
			this.doziranje_mgTextBox.Location = new System.Drawing.Point(346, 188);
			this.doziranje_mgTextBox.Name = "doziranje_mgTextBox";
			this.doziranje_mgTextBox.Size = new System.Drawing.Size(200, 20);
			this.doziranje_mgTextBox.TabIndex = 8;
			// 
			// uputstvoLabel
			// 
			uputstvoLabel.AutoSize = true;
			uputstvoLabel.Location = new System.Drawing.Point(237, 217);
			uputstvoLabel.Name = "uputstvoLabel";
			uputstvoLabel.Size = new System.Drawing.Size(51, 13);
			uputstvoLabel.TabIndex = 9;
			uputstvoLabel.Text = "uputstvo:";
			// 
			// uputstvoTextBox
			// 
			this.uputstvoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "uputstvo", true));
			this.uputstvoTextBox.Location = new System.Drawing.Point(346, 214);
			this.uputstvoTextBox.Name = "uputstvoTextBox";
			this.uputstvoTextBox.Size = new System.Drawing.Size(200, 20);
			this.uputstvoTextBox.TabIndex = 10;
			// 
			// rok_trajanjaLabel
			// 
			rok_trajanjaLabel.AutoSize = true;
			rok_trajanjaLabel.Location = new System.Drawing.Point(237, 244);
			rok_trajanjaLabel.Name = "rok_trajanjaLabel";
			rok_trajanjaLabel.Size = new System.Drawing.Size(62, 13);
			rok_trajanjaLabel.TabIndex = 11;
			rok_trajanjaLabel.Text = "rok trajanja:";
			// 
			// rok_trajanjaDateTimePicker
			// 
			this.rok_trajanjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lekoviBindingSource, "rok_trajanja", true));
			this.rok_trajanjaDateTimePicker.Location = new System.Drawing.Point(346, 240);
			this.rok_trajanjaDateTimePicker.Name = "rok_trajanjaDateTimePicker";
			this.rok_trajanjaDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.rok_trajanjaDateTimePicker.TabIndex = 12;
			// 
			// kategorije_lekova_idLabel
			// 
			kategorije_lekova_idLabel.AutoSize = true;
			kategorije_lekova_idLabel.Location = new System.Drawing.Point(237, 269);
			kategorije_lekova_idLabel.Name = "kategorije_lekova_idLabel";
			kategorije_lekova_idLabel.Size = new System.Drawing.Size(102, 13);
			kategorije_lekova_idLabel.TabIndex = 13;
			kategorije_lekova_idLabel.Text = "kategorije lekova id:";
			// 
			// kategorije_lekova_idTextBox
			// 
			this.kategorije_lekova_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "kategorije_lekova_id", true));
			this.kategorije_lekova_idTextBox.Location = new System.Drawing.Point(346, 266);
			this.kategorije_lekova_idTextBox.Name = "kategorije_lekova_idTextBox";
			this.kategorije_lekova_idTextBox.Size = new System.Drawing.Size(200, 20);
			this.kategorije_lekova_idTextBox.TabIndex = 14;
			// 
			// promocije_popusti_idLabel
			// 
			promocije_popusti_idLabel.AutoSize = true;
			promocije_popusti_idLabel.Location = new System.Drawing.Point(237, 295);
			promocije_popusti_idLabel.Name = "promocije_popusti_idLabel";
			promocije_popusti_idLabel.Size = new System.Drawing.Size(103, 13);
			promocije_popusti_idLabel.TabIndex = 15;
			promocije_popusti_idLabel.Text = "promocije popusti id:";
			// 
			// promocije_popusti_idTextBox
			// 
			this.promocije_popusti_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lekoviBindingSource, "promocije_popusti_id", true));
			this.promocije_popusti_idTextBox.Location = new System.Drawing.Point(346, 292);
			this.promocije_popusti_idTextBox.Name = "promocije_popusti_idTextBox";
			this.promocije_popusti_idTextBox.Size = new System.Drawing.Size(200, 20);
			this.promocije_popusti_idTextBox.TabIndex = 16;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.apotekaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lekoviBindingSource)).EndInit();
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
	}
}