namespace ShopDB
{
    partial class ShopManager
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
            System.Windows.Forms.Label g_IDLabel;
            System.Windows.Forms.Label g_NameLabel;
            System.Windows.Forms.Label g_StudioLabel;
            System.Windows.Forms.Label g_DescriptionLabel;
            System.Windows.Forms.Label g_TypeLabel;
            System.Windows.Forms.Label g_PriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopManager));
            this.shopDataSet = new ShopDB.ShopDataSet();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter = new ShopDB.ShopDataSetTableAdapters.GameTableAdapter();
            this.tableAdapterManager = new ShopDB.ShopDataSetTableAdapters.TableAdapterManager();
            this.gameBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gameBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gameDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_IDTextBox = new System.Windows.Forms.TextBox();
            this.g_NameTextBox = new System.Windows.Forms.TextBox();
            this.g_StudioTextBox = new System.Windows.Forms.TextBox();
            this.g_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.g_TypeTextBox = new System.Windows.Forms.TextBox();
            this.g_PriceTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            g_IDLabel = new System.Windows.Forms.Label();
            g_NameLabel = new System.Windows.Forms.Label();
            g_StudioLabel = new System.Windows.Forms.Label();
            g_DescriptionLabel = new System.Windows.Forms.Label();
            g_TypeLabel = new System.Windows.Forms.Label();
            g_PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingNavigator)).BeginInit();
            this.gameBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // g_IDLabel
            // 
            g_IDLabel.AutoSize = true;
            g_IDLabel.Location = new System.Drawing.Point(28, 85);
            g_IDLabel.Name = "g_IDLabel";
            g_IDLabel.Size = new System.Drawing.Size(32, 13);
            g_IDLabel.TabIndex = 2;
            g_IDLabel.Text = "G ID:";
            // 
            // g_NameLabel
            // 
            g_NameLabel.AutoSize = true;
            g_NameLabel.Location = new System.Drawing.Point(28, 111);
            g_NameLabel.Name = "g_NameLabel";
            g_NameLabel.Size = new System.Drawing.Size(49, 13);
            g_NameLabel.TabIndex = 4;
            g_NameLabel.Text = "G Name:";
            // 
            // g_StudioLabel
            // 
            g_StudioLabel.AutoSize = true;
            g_StudioLabel.Location = new System.Drawing.Point(28, 137);
            g_StudioLabel.Name = "g_StudioLabel";
            g_StudioLabel.Size = new System.Drawing.Size(51, 13);
            g_StudioLabel.TabIndex = 6;
            g_StudioLabel.Text = "G Studio:";
            // 
            // g_DescriptionLabel
            // 
            g_DescriptionLabel.AutoSize = true;
            g_DescriptionLabel.Location = new System.Drawing.Point(28, 163);
            g_DescriptionLabel.Name = "g_DescriptionLabel";
            g_DescriptionLabel.Size = new System.Drawing.Size(74, 13);
            g_DescriptionLabel.TabIndex = 8;
            g_DescriptionLabel.Text = "G Description:";
            // 
            // g_TypeLabel
            // 
            g_TypeLabel.AutoSize = true;
            g_TypeLabel.Location = new System.Drawing.Point(28, 189);
            g_TypeLabel.Name = "g_TypeLabel";
            g_TypeLabel.Size = new System.Drawing.Size(45, 13);
            g_TypeLabel.TabIndex = 10;
            g_TypeLabel.Text = "G Type:";
            // 
            // g_PriceLabel
            // 
            g_PriceLabel.AutoSize = true;
            g_PriceLabel.Location = new System.Drawing.Point(28, 215);
            g_PriceLabel.Name = "g_PriceLabel";
            g_PriceLabel.Size = new System.Drawing.Size(45, 13);
            g_PriceLabel.TabIndex = 12;
            g_PriceLabel.Text = "G Price:";
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "ShopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.shopDataSet;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GameTableAdapter = this.gameTableAdapter;
            this.tableAdapterManager.GameTypeTableAdapter = null;
            this.tableAdapterManager.ProfileTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShopDB.ShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gameBindingNavigator
            // 
            this.gameBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gameBindingNavigator.BindingSource = this.gameBindingSource;
            this.gameBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gameBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gameBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.gameBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gameBindingNavigatorSaveItem});
            this.gameBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gameBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gameBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gameBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gameBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gameBindingNavigator.Name = "gameBindingNavigator";
            this.gameBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gameBindingNavigator.Size = new System.Drawing.Size(768, 25);
            this.gameBindingNavigator.TabIndex = 0;
            this.gameBindingNavigator.Text = "bindingNavigator1";
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
            // gameBindingNavigatorSaveItem
            // 
            this.gameBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gameBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gameBindingNavigatorSaveItem.Image")));
            this.gameBindingNavigatorSaveItem.Name = "gameBindingNavigatorSaveItem";
            this.gameBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gameBindingNavigatorSaveItem.Text = "Save Data";
            this.gameBindingNavigatorSaveItem.Click += new System.EventHandler(this.gameBindingNavigatorSaveItem_Click);
            // 
            // gameDataGridView
            // 
            this.gameDataGridView.AutoGenerateColumns = false;
            this.gameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gameDataGridView.DataSource = this.gameBindingSource;
            this.gameDataGridView.Location = new System.Drawing.Point(31, 252);
            this.gameDataGridView.Name = "gameDataGridView";
            this.gameDataGridView.Size = new System.Drawing.Size(672, 220);
            this.gameDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "G_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "G_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "G_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "G_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "G_Studio";
            this.dataGridViewTextBoxColumn3.HeaderText = "G_Studio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "G_Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "G_Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "G_Type";
            this.dataGridViewTextBoxColumn5.HeaderText = "G_Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "G_Price";
            this.dataGridViewTextBoxColumn6.HeaderText = "G_Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // g_IDTextBox
            // 
            this.g_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "G_ID", true));
            this.g_IDTextBox.Location = new System.Drawing.Point(108, 82);
            this.g_IDTextBox.Name = "g_IDTextBox";
            this.g_IDTextBox.Size = new System.Drawing.Size(218, 20);
            this.g_IDTextBox.TabIndex = 3;
            // 
            // g_NameTextBox
            // 
            this.g_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "G_Name", true));
            this.g_NameTextBox.Location = new System.Drawing.Point(108, 108);
            this.g_NameTextBox.Name = "g_NameTextBox";
            this.g_NameTextBox.Size = new System.Drawing.Size(218, 20);
            this.g_NameTextBox.TabIndex = 5;
            // 
            // g_StudioTextBox
            // 
            this.g_StudioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "G_Studio", true));
            this.g_StudioTextBox.Location = new System.Drawing.Point(108, 134);
            this.g_StudioTextBox.Name = "g_StudioTextBox";
            this.g_StudioTextBox.Size = new System.Drawing.Size(218, 20);
            this.g_StudioTextBox.TabIndex = 7;
            // 
            // g_DescriptionTextBox
            // 
            this.g_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "G_Description", true));
            this.g_DescriptionTextBox.Location = new System.Drawing.Point(108, 160);
            this.g_DescriptionTextBox.Name = "g_DescriptionTextBox";
            this.g_DescriptionTextBox.Size = new System.Drawing.Size(218, 20);
            this.g_DescriptionTextBox.TabIndex = 9;
            // 
            // g_TypeTextBox
            // 
            this.g_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "G_Type", true));
            this.g_TypeTextBox.Location = new System.Drawing.Point(108, 186);
            this.g_TypeTextBox.Name = "g_TypeTextBox";
            this.g_TypeTextBox.Size = new System.Drawing.Size(218, 20);
            this.g_TypeTextBox.TabIndex = 11;
            // 
            // g_PriceTextBox
            // 
            this.g_PriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "G_Price", true));
            this.g_PriceTextBox.Location = new System.Drawing.Point(108, 212);
            this.g_PriceTextBox.Name = "g_PriceTextBox";
            this.g_PriceTextBox.Size = new System.Drawing.Size(218, 20);
            this.g_PriceTextBox.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 42);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(736, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShopManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopDB.Properties.Resources._22965_anime_scenery;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(g_IDLabel);
            this.Controls.Add(this.g_IDTextBox);
            this.Controls.Add(g_NameLabel);
            this.Controls.Add(this.g_NameTextBox);
            this.Controls.Add(g_StudioLabel);
            this.Controls.Add(this.g_StudioTextBox);
            this.Controls.Add(g_DescriptionLabel);
            this.Controls.Add(this.g_DescriptionTextBox);
            this.Controls.Add(g_TypeLabel);
            this.Controls.Add(this.g_TypeTextBox);
            this.Controls.Add(g_PriceLabel);
            this.Controls.Add(this.g_PriceTextBox);
            this.Controls.Add(this.gameDataGridView);
            this.Controls.Add(this.gameBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShopManager";
            this.Load += new System.EventHandler(this.ShopManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingNavigator)).EndInit();
            this.gameBindingNavigator.ResumeLayout(false);
            this.gameBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private ShopDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private ShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gameBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gameBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView gameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox g_IDTextBox;
        private System.Windows.Forms.TextBox g_NameTextBox;
        private System.Windows.Forms.TextBox g_StudioTextBox;
        private System.Windows.Forms.TextBox g_DescriptionTextBox;
        private System.Windows.Forms.TextBox g_TypeTextBox;
        private System.Windows.Forms.TextBox g_PriceTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}