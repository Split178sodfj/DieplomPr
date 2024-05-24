using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFUIKitProfessional.Pages
{
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.deeplomDataSet1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deeplomDataSet1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.deeplomDataSet1.Employee);

            // Подключить обработчик события TextChanged к Search_textBox
            Search_textBox.TextChanged += Search_textBox_TextChanged;

            // Заполнить comboBox1 данными для сортировки
            comboBox1.Items.Add("А-Я");
            comboBox1.Items.Add("Я-А");

            
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            // Получить введенный в Search_textBox текст
            string searchText = Search_textBox.Text;

            // Фильтровать данные в employeeBindingSource по ФИО
            employeeBindingSource.Filter = $"Full_name LIKE '%{searchText}%'";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получить выбранный элемент из comboBox1
            string selectedItem = comboBox1.SelectedItem.ToString();

            // Сортировать данные в employeeBindingSource в зависимости от выбранного элемента
            switch (selectedItem)
            {
                case "А-Я":
                    employeeBindingSource.Sort = "Full_name ASC";
                    break;
                case "Я-А":
                    employeeBindingSource.Sort = "Full_name DESC";
                    break;
            }
        }

        private void Change_theme_Click(object sender, EventArgs e)
        {
            
        }

        private void employeeDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Role_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Full_name_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}