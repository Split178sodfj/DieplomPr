using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing; // <--- Add this line
using System.Linq;

//...





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

        private void Rep_buy_button_Click(object sender, EventArgs e)
        {
            CreateDocxFile();
        }
        private void CreateDocxFile()
        {
            string filePath = "C:\\Users\\korgm\\OneDrive\\Рабочий стол\\Дипломный проект\\Проект\\test1.docx";
            using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, true))
            {
                MainDocumentPart mainPart = doc.MainDocumentPart;
                Body body = mainPart.Document.Body;

                // Find the placeholder text ": "
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
                    // Insert the selected data after the placeholder text
                    int count = 1;
                    foreach (DataGridViewRow selectedRow in orderDataGridView.SelectedRows)
                    {
                        Paragraph dataPara = new Paragraph();
                        Run outerRun = new Run();
                        outerRun.AppendChild(new Text(count++.ToString() + ". ") { Space = SpaceProcessingModeValues.Preserve });
                        dataPara.AppendChild(outerRun);
                        foreach (DataGridViewCell cell in selectedRow.Cells)
                        {
                            if (cell.Value != null && cell.Value != DBNull.Value && orderDataGridView.Columns[cell.ColumnIndex].Visible)
                            {
                                Run innerRun = new Run();
                                if (orderDataGridView.Columns[cell.ColumnIndex].HeaderText == "Наименование")
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
                    MessageBox.Show("Placeholder text not found in the document.");
                }

                doc.Save();
                MessageBox.Show("Файл успешно создан и сохранен по пути: " + filePath);
            }
        }
    }
}
