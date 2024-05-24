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
    public partial class Software : Form
    {
        public Software()
        {
            InitializeComponent();
        }

        private void Software_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deeplomDataSet1.ПрограммноеОбеспечение". При необходимости она может быть перемещена или удалена.
            this.программноеОбеспечениеTableAdapter.Fill(this.deeplomDataSet1.ПрограммноеОбеспечение);


            // Подключить обработчик события TextChanged к Search_textBox
            Search_textBox.TextChanged += Search_textBox_TextChanged;

            // Заполнить comboBox1 данными для сортировки
            comboBox1.Items.Add("А-Я");
            comboBox1.Items.Add("Я-А");

        }

        private void программноеОбеспечениеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.программноеОбеспечениеBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.deeplomDataSet1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получить выбранный элемент из comboBox1
            string selectedItem = comboBox1.SelectedItem.ToString();

            // Сортировать данные в employeeBindingSource в зависимости от выбранного элемента
            switch (selectedItem)
            {
                case "А-Я":
                    программноеОбеспечениеBindingSource.Sort = "Name ASC";
                    break;
                case "Я-А":
                    программноеОбеспечениеBindingSource.Sort = "Name DESC";
                    break;
            }
        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            // Получить введенный в Search_textBox текст
            string searchText = Search_textBox.Text;

            // Фильтровать данные в employeeBindingSource по ФИО
            программноеОбеспечениеBindingSource.Filter = $"Name LIKE '%{searchText}%'";
        }

        private void Name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Key_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
