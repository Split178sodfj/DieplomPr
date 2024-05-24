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
    public partial class Technic : Form
    {
        public Technic()
        {
            InitializeComponent();
        }

        private void наличиеОборудованияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.наличиеОборудованияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.deeplomDataSet1);

        }

        private void Technic_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deeplomDataSet1.НаличиеОборудования". При необходимости она может быть перемещена или удалена.
            this.наличиеОборудованияTableAdapter.Fill(this.deeplomDataSet1.НаличиеОборудования);

            // Подключить обработчик события TextChanged к Search_textBox
            Search_textBox.TextChanged += Search_textBox_TextChanged;

            // Заполнить comboBox1 данными для сортировки
            comboBox1.Items.Add("А-Я");
            comboBox1.Items.Add("Я-А");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Получить выбранный элемент из comboBox1
            string selectedItem = comboBox1.SelectedItem.ToString();

            // Сортировать данные в employeeBindingSource в зависимости от выбранного элемента
            switch (selectedItem)
            {
                case "А-Я":
                    наличиеОборудованияBindingSource.Sort = "Name ASC";
                    break;
                case "Я-А":
                    наличиеОборудованияBindingSource.Sort = "Name DESC";
                    break;
            }

        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            // Получить введенный в Search_textBox текст
            string searchText = Search_textBox.Text;

            // Фильтровать данные в employeeBindingSource по ФИО
            наличиеОборудованияBindingSource.Filter = $"Name LIKE '%{searchText}%'";

        }
    }
}
