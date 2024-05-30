using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace WPFUIKitProfessional.Pages
{
    public partial class Software : Form
    {
        private DateTimePicker dateDateTimePicker;
        private MonthCalendar monthCalendar;

        public Software()
        {
            InitializeComponent();

            // Initialize dateDateTimePicker
            dateDateTimePicker = new DateTimePicker();
            dateDateTimePicker.Location = new Point(10, 10);
            dateDateTimePicker.Size = new Size(200, 20);
            dateDateTimePicker.CustomFormat = "dd.MM.yyyy";
            dateDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.Controls.Add(dateDateTimePicker);

            // Initialize monthCalendar
            monthCalendar = new MonthCalendar();
            monthCalendar.Location = new Point(220, 10);
            monthCalendar.Size = new Size(200, 150);
            this.Controls.Add(monthCalendar);

            // Subscribe to monthCalendar's DateChanged event
            monthCalendar.DateChanged += monthCalendar_DateChanged;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Get the selected date from monthCalendar
            DateTime selectedDate = monthCalendar.SelectionStart;

            // Display the selected date in Date_textBox
            Date_textBox.Text = selectedDate.ToString("dd.MM.yyyy");

            // Get the current cell in datagridview
            DataGridViewCell currentCell = программноеОбеспечениеDataGridView.CurrentCell;

            // If the current cell is not null, update the date value in the cell
            if (currentCell != null)
            {
                программноеОбеспечениеDataGridView.Rows[currentCell.RowIndex].Cells["Дата"].Value = selectedDate;
            }
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
            try
            {
                this.Validate();
                this.программноеОбеспечениеBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.deeplomDataSet1);

                // Получить выбранную дату из dateDateTimePicker
                DateTime selectedDate = dateDateTimePicker.Value;

                // Выполнить действия с выбранной датой
                // ...
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            try
            {
                программноеОбеспечениеBindingSource.Filter = $"Name LIKE '%{searchText}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Date_textBox_TextChanged(object sender, EventArgs e)
        {
            //Date_textBox.Text = "Выбраны даты с " + e.Start.ToString() + " по " + e.End.ToString();
        }

        private void программноеОбеспечениеDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //// Получить выбранную дату из dateDateTimePicker
            //DateTime selectedDate = dateDateTimePicker.Value;

            //// Получить текущую ячейку в datagridview
            //DataGridViewCell currentCell = программноеОбеспечениеDataGridView.CurrentCell;

            //// Если текущая ячейка не пустая, обновить значение даты в ячейке
            //if (currentCell != null)
            //{
            //    программноеОбеспечениеDataGridView.Rows[currentCell.RowIndex].Cells["Дата"].Value = selectedDate;
            //}
        }

        private void Rep_upd_button_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\korgm\\OneDrive\\Рабочий стол\\Дипломный проект\\Проект\\2ProgsUpdaterRep.docx";
            using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, true))
            {
                MainDocumentPart mainPart = doc.MainDocumentPart;
                Body body = mainPart.Document.Body;

                //  поиск двоеточия
                Paragraph placeholderPara = null;
                foreach (Paragraph para in body.Elements<Paragraph>())
                {
                    foreach (Run run in para.Elements<Run>())
                    {
                        if (run.Elements<Text>().Any(t => t.Text.Contains("а:")))
                        {
                            placeholderPara = para;
                            break;
                        }
                    }
                    if (placeholderPara != null) break;
                }

                if (placeholderPara != null)
                {
                    // вставить текст
                    int count = 1;
                    foreach (DataGridViewRow selectedRow in программноеОбеспечениеDataGridView.SelectedRows)
                    {
                        Paragraph dataPara = new Paragraph();
                        Run outerRun = new Run();
                        outerRun.AppendChild(new Text(count++.ToString() + ". ") { Space = SpaceProcessingModeValues.Preserve });
                        dataPara.AppendChild(outerRun);
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            if (cell.Value != null && cell.Value != DBNull.Value && программноеОбеспечениеDataGridView.Columns[cell.ColumnIndex].Visible)
                            {
                                Run innerRun = new Run();
                                if (программноеОбеспечениеDataGridView.Columns[cell.ColumnIndex].HeaderText == "Наименование")
                                {
                                    innerRun.AppendChild(new Bold());
                                }
                                innerRun.AppendChild(new Text(cell.Value.ToString()) { Space = SpaceProcessingModeValues.Preserve });
                                dataPara.AppendChild(innerRun);
                                innerRun = new Run();
                                innerRun.AppendChild(new Text(" ") { Space = SpaceProcessingModeValues.Preserve });
                                dataPara.AppendChild(innerRun);
                            }
                        }
                        body.InsertAfter(dataPara, placeholderPara);
                    }
                }
                else
                {
                    MessageBox.Show("файла не существует.");
                }

                doc.Save();
                MessageBox.Show("Файл успешно создан и сохранен по пути: " + filePath);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string filePath = "C:\\Users\\korgm\\OneDrive\\Рабочий стол\\Дипломный проект\\Проект\\3ProgsContQuery.docx";
            using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, true))
            {
                MainDocumentPart mainPart = doc.MainDocumentPart;
                Body body = mainPart.Document.Body;

                //  поиск двоеточия
                Paragraph placeholderPara = null;
                foreach (Paragraph para in body.Elements<Paragraph>())
                {
                    foreach (Run run in para.Elements<Run>())
                    {
                        if (run.Elements<Text>().Any(t => t.Text.Contains("а:")))
                        {
                            placeholderPara = para;
                            break;
                        }
                    }
                    if (placeholderPara != null) break;
                }

                if (placeholderPara != null)
                {
                    // вставить текст
                    int count = 1;
                    foreach (DataGridViewRow selectedRow in программноеОбеспечениеDataGridView.SelectedRows)
                    {
                        Paragraph dataPara = new Paragraph();
                        Run outerRun = new Run();
                        outerRun.AppendChild(new Text(count++.ToString() + ". ") { Space = SpaceProcessingModeValues.Preserve });
                        dataPara.AppendChild(outerRun);
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            if (cell.Value != null && cell.Value != DBNull.Value && программноеОбеспечениеDataGridView.Columns[cell.ColumnIndex].Visible)
                            {
                                Run innerRun = new Run();
                                if (программноеОбеспечениеDataGridView.Columns[cell.ColumnIndex].HeaderText == "Наименование")
                                {
                                    innerRun.AppendChild(new Bold());
                                }
                                innerRun.AppendChild(new Text(cell.Value.ToString()) { Space = SpaceProcessingModeValues.Preserve });
                                dataPara.AppendChild(innerRun);
                                innerRun = new Run();
                                innerRun.AppendChild(new Text(" ") { Space = SpaceProcessingModeValues.Preserve });
                                dataPara.AppendChild(innerRun);
                            }
                        }
                        body.InsertAfter(dataPara, placeholderPara);
                    }
                }
                else
                {
                    MessageBox.Show("файла не существует.");
                }

                doc.Save();
                MessageBox.Show("Файл успешно создан и сохранен по пути: " + filePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string filePath = "C:\\Users\\korgm\\OneDrive\\Рабочий стол\\Дипломный проект\\Проект\\4ProgsRepFail.docx";
            using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, true))
            {
                MainDocumentPart mainPart = doc.MainDocumentPart;
                Body body = mainPart.Document.Body;

                //  поиск двоеточия
                Paragraph placeholderPara = null;
                foreach (Paragraph para in body.Elements<Paragraph>())
                {
                    foreach (Run run in para.Elements<Run>())
                    {
                        if (run.Elements<Text>().Any(t => t.Text.Contains("а:")))
                        {
                            placeholderPara = para;
                            break;
                        }
                    }
                    if (placeholderPara != null) break;
                }

                if (placeholderPara != null)
                {
                    // вставить текст
                    int count = 1;
                    foreach (DataGridViewRow selectedRow in программноеОбеспечениеDataGridView.SelectedRows)
                    {
                        Paragraph dataPara = new Paragraph();
                        Run outerRun = new Run();
                        outerRun.AppendChild(new Text(count++.ToString() + ". ") { Space = SpaceProcessingModeValues.Preserve });
                        dataPara.AppendChild(outerRun);
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            if (cell.Value != null && cell.Value != DBNull.Value && программноеОбеспечениеDataGridView.Columns[cell.ColumnIndex].Visible)
                            {
                                Run innerRun = new Run();
                                if (программноеОбеспечениеDataGridView.Columns[cell.ColumnIndex].HeaderText == "Наименование")
                                {
                                    innerRun.AppendChild(new Bold());
                                }
                                innerRun.AppendChild(new Text(cell.Value.ToString()) { Space = SpaceProcessingModeValues.Preserve });
                                dataPara.AppendChild(innerRun);
                                innerRun = new Run();
                                innerRun.AppendChild(new Text(" ") { Space = SpaceProcessingModeValues.Preserve });
                                dataPara.AppendChild(innerRun);
                            }
                        }
                        body.InsertAfter(dataPara, placeholderPara);
                    }
                }
                else
                {
                    MessageBox.Show("файла не существует.");
                }

                doc.Save();
                MessageBox.Show("Файл успешно создан и сохранен по пути: " + filePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            string filePath = "C:\\Users\\korgm\\OneDrive\\Рабочий стол\\Дипломный проект\\Проект\\5ProgsCopyRep.docx";
            using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, true))
            {
                MainDocumentPart mainPart = doc.MainDocumentPart;
                Body body = mainPart.Document.Body;

                //  поиск двоеточия
                Paragraph placeholderPara = null;
                foreach (Paragraph para in body.Elements<Paragraph>())
                {
                    foreach (Run run in para.Elements<Run>())
                    {
                        if (run.Elements<Text>().Any(t => t.Text.Contains("а:")))
                        {
                            placeholderPara = para;
                            break;
                        }
                    }
                    if (placeholderPara != null) break;
                }

                if (placeholderPara != null)
                {
                    // вставить текст
                    int count = 1;
                    foreach (DataGridViewRow selectedRow in программноеОбеспечениеDataGridView.SelectedRows)
                    {
                        Paragraph dataPara = new Paragraph();
                        Run outerRun = new Run();
                        outerRun.AppendChild(new Text(count++.ToString() + ". ") { Space = SpaceProcessingModeValues.Preserve });
                        dataPara.AppendChild(outerRun);
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            if (cell.Value != null && cell.Value != DBNull.Value && программноеОбеспечениеDataGridView.Columns[cell.ColumnIndex].Visible)
                            {
                                Run innerRun = new Run();
                                if (программноеОбеспечениеDataGridView.Columns[cell.ColumnIndex].HeaderText == "Наименование")
                                {
                                    innerRun.AppendChild(new Bold());
                                }
                                innerRun.AppendChild(new Text(cell.Value.ToString()) { Space = SpaceProcessingModeValues.Preserve });
                                dataPara.AppendChild(innerRun);
                                innerRun = new Run();
                                innerRun.AppendChild(new Text(" ") { Space = SpaceProcessingModeValues.Preserve });
                                dataPara.AppendChild(innerRun);
                            }
                        }
                        body.InsertAfter(dataPara, placeholderPara);
                    }
                }
                else
                {
                    MessageBox.Show("файла не существует.");
                }

                doc.Save();
                MessageBox.Show("Файл успешно создан и сохранен по пути: " + filePath);
            }
        }
    }
}