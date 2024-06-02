using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Wordprocessing;

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

        private void Rep_repaier_button_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\korgm\\OneDrive\\Рабочий стол\\Дипломный проект\\Проект\\7CompRepaierRep.docx";
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
                    foreach (DataGridViewRow selectedRow in наличиеОборудованияDataGridView.SelectedRows)
                    {
                        Paragraph dataPara = new Paragraph();
                        Run outerRun = new Run();
                        outerRun.AppendChild(new Text(count++.ToString() + ". ") { Space = SpaceProcessingModeValues.Preserve });
                        dataPara.AppendChild(outerRun);
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            if (cell.Value != null && cell.Value != DBNull.Value && наличиеОборудованияDataGridView.Columns[cell.ColumnIndex].Visible)
                            {
                                Run innerRun = new Run();
                                if (наличиеОборудованияDataGridView.Columns[cell.ColumnIndex].HeaderText == "Наименование")
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
            string filePath = "C:\\Users\\korgm\\OneDrive\\Рабочий стол\\Дипломный проект\\Проект\\8CompUpgradeQuery.docx";
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
                    foreach (DataGridViewRow selectedRow in наличиеОборудованияDataGridView.SelectedRows)
                    {
                        Paragraph dataPara = new Paragraph();
                        Run outerRun = new Run();
                        outerRun.AppendChild(new Text(count++.ToString() + ". ") { Space = SpaceProcessingModeValues.Preserve });
                        dataPara.AppendChild(outerRun);
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            if (cell.Value != null && cell.Value != DBNull.Value && наличиеОборудованияDataGridView.Columns[cell.ColumnIndex].Visible)
                            {
                                Run innerRun = new Run();
                                if (наличиеОборудованияDataGridView.Columns[cell.ColumnIndex].HeaderText == "Наименование")
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
            
            string filePath = "C:\\Users\\korgm\\OneDrive\\Рабочий стол\\Дипломный проект\\Проект\\9CompCommisQuery.docx";
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
                    foreach (DataGridViewRow selectedRow in наличиеОборудованияDataGridView.SelectedRows)
                    {
                        Paragraph dataPara = new Paragraph();
                        Run outerRun = new Run();
                        outerRun.AppendChild(new Text(count++.ToString() + ". ") { Space = SpaceProcessingModeValues.Preserve });
                        dataPara.AppendChild(outerRun);
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            if (cell.Value != null && cell.Value != DBNull.Value && наличиеОборудованияDataGridView.Columns[cell.ColumnIndex].Visible)
                            {
                                Run innerRun = new Run();
                                if (наличиеОборудованияDataGridView.Columns[cell.ColumnIndex].HeaderText == "Наименование")
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
            
            string filePath = "C:\\Users\\korgm\\OneDrive\\Рабочий стол\\Дипломный проект\\Проект\\10CompDiagnosRep.docx";
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
                    foreach (DataGridViewRow selectedRow in наличиеОборудованияDataGridView.SelectedRows)
                    {
                        Paragraph dataPara = new Paragraph();
                        Run outerRun = new Run();
                        outerRun.AppendChild(new Text(count++.ToString() + ". ") { Space = SpaceProcessingModeValues.Preserve });
                        dataPara.AppendChild(outerRun);
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            if (cell.Value != null && cell.Value != DBNull.Value && наличиеОборудованияDataGridView.Columns[cell.ColumnIndex].Visible)
                            {
                                Run innerRun = new Run();
                                if (наличиеОборудованияDataGridView.Columns[cell.ColumnIndex].HeaderText == "Наименование")
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

        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\korgm\\OneDrive\\Рабочий стол\\Дипломный проект\\Проект\\11CompRefundQuery.docx";
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
                    foreach (DataGridViewRow selectedRow in наличиеОборудованияDataGridView.SelectedRows)
                    {
                        Paragraph dataPara = new Paragraph();
                        Run outerRun = new Run();
                        outerRun.AppendChild(new Text(count++.ToString() + ". ") { Space = SpaceProcessingModeValues.Preserve });
                        dataPara.AppendChild(outerRun);
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            if (cell.Value != null && cell.Value != DBNull.Value && наличиеОборудованияDataGridView.Columns[cell.ColumnIndex].Visible)
                            {
                                Run innerRun = new Run();
                                if (наличиеОборудованияDataGridView.Columns[cell.ColumnIndex].HeaderText == "Наименование")
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
