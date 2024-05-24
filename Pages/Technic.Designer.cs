namespace WPFUIKitProfessional.Pages
{
    partial class Technic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Technic));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deeplomDataSet1 = new WPFUIKitProfessional.DeeplomDataSet1();
            this.наличиеОборудованияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наличиеОборудованияTableAdapter = new WPFUIKitProfessional.DeeplomDataSet1TableAdapters.НаличиеОборудованияTableAdapter();
            this.tableAdapterManager = new WPFUIKitProfessional.DeeplomDataSet1TableAdapters.TableAdapterManager();
            this.наличиеОборудованияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.наличиеОборудованияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.наличиеОборудованияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deeplomDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.наличиеОборудованияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.наличиеОборудованияBindingNavigator)).BeginInit();
            this.наличиеОборудованияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.наличиеОборудованияDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deeplomDataSet1
            // 
            this.deeplomDataSet1.DataSetName = "DeeplomDataSet1";
            this.deeplomDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // наличиеОборудованияBindingSource
            // 
            this.наличиеОборудованияBindingSource.DataMember = "НаличиеОборудования";
            this.наличиеОборудованияBindingSource.DataSource = this.deeplomDataSet1;
            // 
            // наличиеОборудованияTableAdapter
            // 
            this.наличиеОборудованияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WPFUIKitProfessional.DeeplomDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.НаличиеОборудованияTableAdapter = this.наличиеОборудованияTableAdapter;
            this.tableAdapterManager.ПрограммноеОбеспечениеTableAdapter = null;
            // 
            // наличиеОборудованияBindingNavigator
            // 
            this.наличиеОборудованияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.наличиеОборудованияBindingNavigator.BackColor = System.Drawing.Color.CornflowerBlue;
            this.наличиеОборудованияBindingNavigator.BindingSource = this.наличиеОборудованияBindingSource;
            this.наличиеОборудованияBindingNavigator.CountItem = null;
            this.наличиеОборудованияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.наличиеОборудованияBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.наличиеОборудованияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.наличиеОборудованияBindingNavigatorSaveItem});
            this.наличиеОборудованияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.наличиеОборудованияBindingNavigator.MinimumSize = new System.Drawing.Size(0, 45);
            this.наличиеОборудованияBindingNavigator.MoveFirstItem = null;
            this.наличиеОборудованияBindingNavigator.MoveLastItem = null;
            this.наличиеОборудованияBindingNavigator.MoveNextItem = null;
            this.наличиеОборудованияBindingNavigator.MovePreviousItem = null;
            this.наличиеОборудованияBindingNavigator.Name = "наличиеОборудованияBindingNavigator";
            this.наличиеОборудованияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.наличиеОборудованияBindingNavigator.Size = new System.Drawing.Size(1086, 45);
            this.наличиеОборудованияBindingNavigator.TabIndex = 0;
            this.наличиеОборудованияBindingNavigator.Text = "bindingNavigator1";
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
            // наличиеОборудованияBindingNavigatorSaveItem
            // 
            this.наличиеОборудованияBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.наличиеОборудованияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("наличиеОборудованияBindingNavigatorSaveItem.Image")));
            this.наличиеОборудованияBindingNavigatorSaveItem.Name = "наличиеОборудованияBindingNavigatorSaveItem";
            this.наличиеОборудованияBindingNavigatorSaveItem.Size = new System.Drawing.Size(210, 42);
            this.наличиеОборудованияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.наличиеОборудованияBindingNavigatorSaveItem.Click += new System.EventHandler(this.наличиеОборудованияBindingNavigatorSaveItem_Click);
            // 
            // наличиеОборудованияDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.наличиеОборудованияDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.наличиеОборудованияDataGridView.AutoGenerateColumns = false;
            this.наличиеОборудованияDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.наличиеОборудованияDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.наличиеОборудованияDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.наличиеОборудованияDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.наличиеОборудованияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.наличиеОборудованияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.наличиеОборудованияDataGridView.DataSource = this.наличиеОборудованияBindingSource;
            this.наличиеОборудованияDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.наличиеОборудованияDataGridView.GridColor = System.Drawing.Color.SeaShell;
            this.наличиеОборудованияDataGridView.Location = new System.Drawing.Point(0, 45);
            this.наличиеОборудованияDataGridView.Name = "наличиеОборудованияDataGridView";
            this.наличиеОборудованияDataGridView.RowHeadersWidth = 51;
            this.наличиеОборудованияDataGridView.RowTemplate.Height = 24;
            this.наличиеОборудованияDataGridView.Size = new System.Drawing.Size(1086, 220);
            this.наличиеОборудованияDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Inventory_number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date_receiving";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата получения";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date_of_debiting";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ввод в эксплуатацию";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Place";
            this.dataGridViewTextBoxColumn7.HeaderText = "Кабинет";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date_of_commissioning";
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата списания";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(785, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 33);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Search_textBox.Location = new System.Drawing.Point(934, 8);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(140, 31);
            this.Search_textBox.TabIndex = 23;
            this.Search_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::WPFUIKitProfessional.Properties.Resources.icons8_search_362;
            this.pictureBox2.Location = new System.Drawing.Point(890, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 38);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::WPFUIKitProfessional.Properties.Resources.icons8_sort_361;
            this.pictureBox1.Location = new System.Drawing.Point(740, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 36);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.наличиеОборудованияBindingSource, "Name", true));
            this.textBox1.Location = new System.Drawing.Point(45, 302);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.наличиеОборудованияBindingSource, "Inventory_number", true));
            this.textBox2.Location = new System.Drawing.Point(175, 303);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.наличиеОборудованияBindingSource, "Date_receiving", true));
            this.textBox3.Location = new System.Drawing.Point(334, 302);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 27;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.наличиеОборудованияBindingSource, "Date_of_debiting", true));
            this.textBox4.Location = new System.Drawing.Point(474, 302);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 28;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.наличиеОборудованияBindingSource, "Place", true));
            this.textBox5.Location = new System.Drawing.Point(613, 302);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 29;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.наличиеОборудованияBindingSource, "Date_of_commissioning", true));
            this.textBox6.Location = new System.Drawing.Point(740, 303);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 30;
            // 
            // Technic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1086, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.наличиеОборудованияDataGridView);
            this.Controls.Add(this.наличиеОборудованияBindingNavigator);
            this.Name = "Technic";
            this.Text = "Оборудование";
            this.Load += new System.EventHandler(this.Technic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deeplomDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.наличиеОборудованияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.наличиеОборудованияBindingNavigator)).EndInit();
            this.наличиеОборудованияBindingNavigator.ResumeLayout(false);
            this.наличиеОборудованияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.наличиеОборудованияDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DeeplomDataSet1 deeplomDataSet1;
        private System.Windows.Forms.BindingSource наличиеОборудованияBindingSource;
        private DeeplomDataSet1TableAdapters.НаличиеОборудованияTableAdapter наличиеОборудованияTableAdapter;
        private DeeplomDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator наличиеОборудованияBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton наличиеОборудованияBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView наличиеОборудованияDataGridView;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}