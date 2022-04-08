namespace ShopDB
{
    partial class UserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManager));
            System.Windows.Forms.Label c_IDLabel;
            System.Windows.Forms.Label c_PasswordLabel;
            System.Windows.Forms.Label c_TelLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shopDataSet = new ShopDB.ShopDataSet();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profileTableAdapter = new ShopDB.ShopDataSetTableAdapters.ProfileTableAdapter();
            this.tableAdapterManager = new ShopDB.ShopDataSetTableAdapters.TableAdapterManager();
            this.profileBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.profileBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.profileDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_IDTextBox = new System.Windows.Forms.TextBox();
            this.c_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.c_TelTextBox = new System.Windows.Forms.TextBox();
            c_IDLabel = new System.Windows.Forms.Label();
            c_PasswordLabel = new System.Windows.Forms.Label();
            c_TelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingNavigator)).BeginInit();
            this.profileBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(663, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 42);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "ShopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profileBindingSource
            // 
            this.profileBindingSource.DataMember = "Profile";
            this.profileBindingSource.DataSource = this.shopDataSet;
            // 
            // profileTableAdapter
            // 
            this.profileTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GameTableAdapter = null;
            this.tableAdapterManager.GameTypeTableAdapter = null;
            this.tableAdapterManager.ProfileTableAdapter = this.profileTableAdapter;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShopDB.ShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // profileBindingNavigator
            // 
            this.profileBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.profileBindingNavigator.BindingSource = this.profileBindingSource;
            this.profileBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.profileBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.profileBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.profileBindingNavigatorSaveItem});
            this.profileBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.profileBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.profileBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.profileBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.profileBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.profileBindingNavigator.Name = "profileBindingNavigator";
            this.profileBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.profileBindingNavigator.Size = new System.Drawing.Size(699, 25);
            this.profileBindingNavigator.TabIndex = 18;
            this.profileBindingNavigator.Text = "bindingNavigator1";
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
            // profileBindingNavigatorSaveItem
            // 
            this.profileBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.profileBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("profileBindingNavigatorSaveItem.Image")));
            this.profileBindingNavigatorSaveItem.Name = "profileBindingNavigatorSaveItem";
            this.profileBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.profileBindingNavigatorSaveItem.Text = "Save Data";
            this.profileBindingNavigatorSaveItem.Click += new System.EventHandler(this.profileBindingNavigatorSaveItem_Click);
            // 
            // profileDataGridView
            // 
            this.profileDataGridView.AutoGenerateColumns = false;
            this.profileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.profileDataGridView.DataSource = this.profileBindingSource;
            this.profileDataGridView.Location = new System.Drawing.Point(297, 121);
            this.profileDataGridView.Name = "profileDataGridView";
            this.profileDataGridView.Size = new System.Drawing.Size(360, 220);
            this.profileDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "C_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "C_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "C_Password";
            this.dataGridViewTextBoxColumn2.HeaderText = "C_Password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "C_Tel";
            this.dataGridViewTextBoxColumn3.HeaderText = "C_Tel";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // c_IDLabel
            // 
            c_IDLabel.AutoSize = true;
            c_IDLabel.Location = new System.Drawing.Point(28, 124);
            c_IDLabel.Name = "c_IDLabel";
            c_IDLabel.Size = new System.Drawing.Size(31, 13);
            c_IDLabel.TabIndex = 18;
            c_IDLabel.Text = "C ID:";
            // 
            // c_IDTextBox
            // 
            this.c_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profileBindingSource, "C_ID", true));
            this.c_IDTextBox.Location = new System.Drawing.Point(100, 121);
            this.c_IDTextBox.Name = "c_IDTextBox";
            this.c_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.c_IDTextBox.TabIndex = 19;
            // 
            // c_PasswordLabel
            // 
            c_PasswordLabel.AutoSize = true;
            c_PasswordLabel.Location = new System.Drawing.Point(28, 150);
            c_PasswordLabel.Name = "c_PasswordLabel";
            c_PasswordLabel.Size = new System.Drawing.Size(66, 13);
            c_PasswordLabel.TabIndex = 20;
            c_PasswordLabel.Text = "C Password:";
            // 
            // c_PasswordTextBox
            // 
            this.c_PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profileBindingSource, "C_Password", true));
            this.c_PasswordTextBox.Location = new System.Drawing.Point(100, 147);
            this.c_PasswordTextBox.Name = "c_PasswordTextBox";
            this.c_PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.c_PasswordTextBox.TabIndex = 21;
            // 
            // c_TelLabel
            // 
            c_TelLabel.AutoSize = true;
            c_TelLabel.Location = new System.Drawing.Point(28, 176);
            c_TelLabel.Name = "c_TelLabel";
            c_TelLabel.Size = new System.Drawing.Size(35, 13);
            c_TelLabel.TabIndex = 22;
            c_TelLabel.Text = "C Tel:";
            // 
            // c_TelTextBox
            // 
            this.c_TelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profileBindingSource, "C_Tel", true));
            this.c_TelTextBox.Location = new System.Drawing.Point(100, 173);
            this.c_TelTextBox.Name = "c_TelTextBox";
            this.c_TelTextBox.Size = new System.Drawing.Size(100, 20);
            this.c_TelTextBox.TabIndex = 23;
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShopDB.Properties.Resources._22965_anime_scenery;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 423);
            this.Controls.Add(c_IDLabel);
            this.Controls.Add(this.c_IDTextBox);
            this.Controls.Add(c_PasswordLabel);
            this.Controls.Add(this.c_PasswordTextBox);
            this.Controls.Add(c_TelLabel);
            this.Controls.Add(this.c_TelTextBox);
            this.Controls.Add(this.profileDataGridView);
            this.Controls.Add(this.profileBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManager";
            this.Load += new System.EventHandler(this.UserManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingNavigator)).EndInit();
            this.profileBindingNavigator.ResumeLayout(false);
            this.profileBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private ShopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource profileBindingSource;
        private ShopDataSetTableAdapters.ProfileTableAdapter profileTableAdapter;
        private ShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator profileBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton profileBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView profileDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox c_IDTextBox;
        private System.Windows.Forms.TextBox c_PasswordTextBox;
        private System.Windows.Forms.TextBox c_TelTextBox;
    }
}