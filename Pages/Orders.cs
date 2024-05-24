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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

    

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deeplomDataSet2.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.deeplomDataSet2.Order);


            // Подключить обработчик события TextChanged к Search_textBox
            Search_textBox.TextChanged += Search_textBox_TextChanged;

            // Заполнить comboBox1 данными для сортировки
            comboBox1.Items.Add("А-Я");
            comboBox1.Items.Add("Я-А");



        }

        private void orderBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void orderBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.deeplomDataSet2);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получить выбранный элемент из comboBox1
            string selectedItem = comboBox1.SelectedItem.ToString();

            // Сортировать данные в employeeBindingSource в зависимости от выбранного элемента
            switch (selectedItem)
            {
                case "А-Я":
                    orderBindingSource.Sort = "Name ASC";
                    break;
                case "Я-А":
                    orderBindingSource.Sort = "Name DESC";
                    break;
            }

        }

        private void Search_textBox_TextChanged(object sender, EventArgs e)
        {
            // Получить введенный в Search_textBox текст
            string searchText = Search_textBox.Text;

            // Фильтровать данные в employeeBindingSource по ФИО
            orderBindingSource.Filter = $"Name LIKE '%{searchText}%'";

        }

        private void Name_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Amount_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
