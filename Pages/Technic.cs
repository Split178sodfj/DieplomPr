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


        private MonthCalendar monthCalendarReceiving;
        private MonthCalendar monthCalendarDebiting;
        private MonthCalendar monthCalendarCommissioning;


        public Technic()
        {
            InitializeComponent();

            // Initialize monthCalendarReceiving
            monthCalendarReceiving = new MonthCalendar();
            monthCalendarReceiving.Location = new Point(220, 40); // adjust the location as needed
            monthCalendarReceiving.Size = new Size(200, 150);
            this.Controls.Add(monthCalendarReceiving);

            // Initialize monthCalendarDebiting
            monthCalendarDebiting = new MonthCalendar();
            monthCalendarDebiting.Location = new Point(220, 70); // adjust the location as needed
            monthCalendarDebiting.Size = new Size(200, 150);
            this.Controls.Add(monthCalendarDebiting);

            // Initialize monthCalendarCommissioning
            monthCalendarCommissioning = new MonthCalendar();
            monthCalendarCommissioning.Location = new Point(220, 100); // adjust the location as needed
            monthCalendarCommissioning.Size = new Size(200, 150);
            this.Controls.Add(monthCalendarCommissioning);

            // Subscribe to monthCalendarReceiving's DateChanged event
            monthCalendarReceiving.DateChanged += monthCalendarReceiving_DateChanged;

            // Subscribe to monthCalendarDebiting's DateChanged event
            monthCalendarDebiting.DateChanged += monthCalendarDebiting_DateChanged;

            // Subscribe to monthCalendarCommissioning's DateChanged event
            monthCalendarCommissioning.DateChanged += monthCalendarCommissioning_DateChanged;
        }


        private void monthCalendarReceiving_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Get the selected date from monthCalendarReceiving
            DateTime selectedDate = monthCalendarReceiving.SelectionStart;

            // Display the selected date in Date_receving_textBox
            Date_receving_textBox.Text = selectedDate.ToString("dd.MM.yyyy");

            // Get the current cell in datagridview
            DataGridViewCell currentCell = наличиеОборудованияDataGridView.CurrentCell;

            // If the current cell is not null, update the date value in the cell
            if (currentCell != null)
            {
                наличиеОборудованияDataGridView.Rows[currentCell.RowIndex].Cells["Дата"].Value = selectedDate;
            }
        }

        private void monthCalendarDebiting_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Get the selected date from monthCalendarDebiting
            DateTime selectedDate = monthCalendarDebiting.SelectionStart;

            // Display the selected date in Date_debiting_textBox
            Date_debiting_textBox.Text = selectedDate.ToString("dd.MM.yyyy");

            // Get the current cell in datagridview
            DataGridViewCell currentCell = наличиеОборудованияDataGridView.CurrentCell;

            // If the current cell is not null, update the date value in the cell
            if (currentCell != null)
            {
                наличиеОборудованияDataGridView.Rows[currentCell.RowIndex].Cells["Дата"].Value = selectedDate;
            }
        }

        private void monthCalendarCommissioning_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Get the selected date from monthCalendarCommissioning
            DateTime selectedDate = monthCalendarCommissioning.SelectionStart;

            // Display the selected date in Date_commissioning_textBox
            Date_commissioning_textBox.Text = selectedDate.ToString("dd.MM.yyyy");

            // Get the current cell in datagridview
            DataGridViewCell currentCell = наличиеОборудованияDataGridView.CurrentCell;

            // If the current cell is not null, update the date value in the cell
            if (currentCell != null)
            {
                наличиеОборудованияDataGridView.Rows[currentCell.RowIndex].Cells["Дата"].Value = selectedDate;
            }
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
