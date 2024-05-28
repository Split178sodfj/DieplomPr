namespace WPFUIKitProfessional.Pages
{
    partial class Software
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Software));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deeplomDataSet1 = new WPFUIKitProfessional.DeeplomDataSet1();
            this.программноеОбеспечениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.программноеОбеспечениеTableAdapter = new WPFUIKitProfessional.DeeplomDataSet1TableAdapters.ПрограммноеОбеспечениеTableAdapter();
            this.tableAdapterManager = new WPFUIKitProfessional.DeeplomDataSet1TableAdapters.TableAdapterManager();
            this.программноеОбеспечениеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.программноеОбеспечениеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.программноеОбеспечениеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Date_textBox = new System.Windows.Forms.TextBox();
            this.Key_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deeplomDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.программноеОбеспечениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.программноеОбеспечениеBindingNavigator)).BeginInit();
            this.программноеОбеспечениеBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.программноеОбеспечениеDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deeplomDataSet1
            // 
            this.deeplomDataSet1.DataSetName = "DeeplomDataSet1";
            this.deeplomDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // программноеОбеспечениеBindingSource
            // 
            this.программноеОбеспечениеBindingSource.DataMember = "ПрограммноеОбеспечение";
            this.программноеОбеспечениеBindingSource.DataSource = this.deeplomDataSet1;
            // 
            // программноеОбеспечениеTableAdapter
            // 
            this.программноеОбеспечениеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WPFUIKitProfessional.DeeplomDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.НаличиеОборудованияTableAdapter = null;
            this.tableAdapterManager.ПрограммноеОбеспечениеTableAdapter = this.программноеОбеспечениеTableAdapter;
            // 
            // программноеОбеспечениеBindingNavigator
            // 
            this.программноеОбеспечениеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.программноеОбеспечениеBindingNavigator.BackColor = System.Drawing.Color.CornflowerBlue;
            this.программноеОбеспечениеBindingNavigator.BindingSource = this.программноеОбеспечениеBindingSource;
            this.программноеОбеспечениеBindingNavigator.CountItem = null;
            this.программноеОбеспечениеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.программноеОбеспечениеBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.программноеОбеспечениеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.программноеОбеспечениеBindingNavigatorSaveItem});
            this.программноеОбеспечениеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.программноеОбеспечениеBindingNavigator.MinimumSize = new System.Drawing.Size(0, 45);
            this.программноеОбеспечениеBindingNavigator.MoveFirstItem = null;
            this.программноеОбеспечениеBindingNavigator.MoveLastItem = null;
            this.программноеОбеспечениеBindingNavigator.MoveNextItem = null;
            this.программноеОбеспечениеBindingNavigator.MovePreviousItem = null;
            this.программноеОбеспечениеBindingNavigator.Name = "программноеОбеспечениеBindingNavigator";
            this.программноеОбеспечениеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.программноеОбеспечениеBindingNavigator.Size = new System.Drawing.Size(1073, 45);
            this.программноеОбеспечениеBindingNavigator.TabIndex = 0;
            this.программноеОбеспечениеBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(198, 42);
            this.bindingNavigatorAddNewItem.Text = "Добавить строку";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(187, 42);
            this.bindingNavigatorDeleteItem.Text = "Удалить строку";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // программноеОбеспечениеBindingNavigatorSaveItem
            // 
            this.программноеОбеспечениеBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.программноеОбеспечениеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("программноеОбеспечениеBindingNavigatorSaveItem.Image")));
            this.программноеОбеспечениеBindingNavigatorSaveItem.Name = "программноеОбеспечениеBindingNavigatorSaveItem";
            this.программноеОбеспечениеBindingNavigatorSaveItem.Size = new System.Drawing.Size(210, 42);
            this.программноеОбеспечениеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.программноеОбеспечениеBindingNavigatorSaveItem.Click += new System.EventHandler(this.программноеОбеспечениеBindingNavigatorSaveItem_Click);
            // 
            // программноеОбеспечениеDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.программноеОбеспечениеDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.программноеОбеспечениеDataGridView.AutoGenerateColumns = false;
            this.программноеОбеспечениеDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.программноеОбеспечениеDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.программноеОбеспечениеDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.программноеОбеспечениеDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.программноеОбеспечениеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.программноеОбеспечениеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.программноеОбеспечениеDataGridView.DataSource = this.программноеОбеспечениеBindingSource;
            this.программноеОбеспечениеDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.программноеОбеспечениеDataGridView.GridColor = System.Drawing.Color.SeaShell;
            this.программноеОбеспечениеDataGridView.Location = new System.Drawing.Point(0, 45);
            this.программноеОбеспечениеDataGridView.Name = "программноеОбеспечениеDataGridView";
            this.программноеОбеспечениеDataGridView.RowHeadersWidth = 51;
            this.программноеОбеспечениеDataGridView.RowTemplate.Height = 24;
            this.программноеОбеспечениеDataGridView.Size = new System.Drawing.Size(1073, 279);
            this.программноеОбеспечениеDataGridView.TabIndex = 1;
            this.программноеОбеспечениеDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.программноеОбеспечениеDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "License_key";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.HeaderText = "Ключ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date_of_receving";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата получения";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(772, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 33);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Search_textBox.Location = new System.Drawing.Point(921, 8);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(140, 31);
            this.Search_textBox.TabIndex = 19;
            this.Search_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(877, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 38);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(727, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 36);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Date_textBox
            // 
            this.Date_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.программноеОбеспечениеBindingSource, "Date_of_receving", true));
            this.Date_textBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Date_textBox.Location = new System.Drawing.Point(317, 365);
            this.Date_textBox.Name = "Date_textBox";
            this.Date_textBox.Size = new System.Drawing.Size(100, 31);
            this.Date_textBox.TabIndex = 22;
            this.Date_textBox.TextChanged += new System.EventHandler(this.Date_textBox_TextChanged);
            // 
            // Key_textBox
            // 
            this.Key_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.программноеОбеспечениеBindingSource, "License_key", true));
            this.Key_textBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Key_textBox.Location = new System.Drawing.Point(175, 365);
            this.Key_textBox.Name = "Key_textBox";
            this.Key_textBox.Size = new System.Drawing.Size(100, 31);
            this.Key_textBox.TabIndex = 23;
            // 
            // Name_textBox
            // 
            this.Name_textBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.программноеОбеспечениеBindingSource, "Name", true));
            this.Name_textBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Name_textBox.Location = new System.Drawing.Point(30, 365);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(100, 31);
            this.Name_textBox.TabIndex = 24;
            // 
            // Software
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Key_textBox);
            this.Controls.Add(this.Date_textBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.программноеОбеспечениеDataGridView);
            this.Controls.Add(this.программноеОбеспечениеBindingNavigator);
            this.Name = "Software";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software";
            this.Load += new System.EventHandler(this.Software_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deeplomDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.программноеОбеспечениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.программноеОбеспечениеBindingNavigator)).EndInit();
            this.программноеОбеспечениеBindingNavigator.ResumeLayout(false);
            this.программноеОбеспечениеBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.программноеОбеспечениеDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DeeplomDataSet1 deeplomDataSet1;
        private System.Windows.Forms.BindingSource программноеОбеспечениеBindingSource;
        private DeeplomDataSet1TableAdapters.ПрограммноеОбеспечениеTableAdapter программноеОбеспечениеTableAdapter;
        private DeeplomDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator программноеОбеспечениеBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton программноеОбеспечениеBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView программноеОбеспечениеDataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Date_textBox;
        private System.Windows.Forms.TextBox Key_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}