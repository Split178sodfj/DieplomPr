using System;
using System.Data.SqlClient;
using System.Windows;
using WPFUIKitProfessional.DeeplomDataSet1TableAdapters;

namespace WPFUIKitProfessional.Pages
{
    /// <summary>
    /// Логика взаимодействия для UsersWin.xaml
    /// </summary>
    public partial class UsersWin : Window
    {
        public UsersWin()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WPFUIKitProfessional.DeeplomDataSet1 deeplomDataSet1 = ((WPFUIKitProfessional.DeeplomDataSet1)(this.FindResource("deeplomDataSet1")));

            // Загрузить данные в таблицу Employee
            WPFUIKitProfessional.DeeplomDataSet1TableAdapters.EmployeeTableAdapter deeplomDataSet1EmployeeTableAdapter = new WPFUIKitProfessional.DeeplomDataSet1TableAdapters.EmployeeTableAdapter();
            deeplomDataSet1EmployeeTableAdapter.Fill(deeplomDataSet1.Employee);

                
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            // Обновить данные в базе данных
            WPFUIKitProfessional.DeeplomDataSet1 deeplomDataSet1 = ((WPFUIKitProfessional.DeeplomDataSet1)(this.FindResource("deeplomDataSet1")));
            deeplomDataSet1.Employee.AcceptChanges();
            WPFUIKitProfessional.DeeplomDataSet1TableAdapters.EmployeeTableAdapter deeplomDataSet1EmployeeTableAdapter = new WPFUIKitProfessional.DeeplomDataSet1TableAdapters.EmployeeTableAdapter();
            deeplomDataSet1EmployeeTableAdapter.Update(deeplomDataSet1.Employee);
        }

        private void BtnDel_Click_2(object sender, RoutedEventArgs e)
        {
            int employeeId = Convert.ToInt32(ID_employeeTextBox.Text);
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JBQOFCV\\SQLEXPRESS;Integrated Security=True;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Employee WHERE ID_employee = @ID_employee", connection))
                { 
                    command.Parameters.AddWithValue("@ID_employee", employeeId);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

            // Обновить данные в таблице
            WPFUIKitProfessional.DeeplomDataSet1 deeplomDataSet1 = ((WPFUIKitProfessional.DeeplomDataSet1)(this.FindResource("deeplomDataSet1")));
            WPFUIKitProfessional.DeeplomDataSet1TableAdapters.EmployeeTableAdapter deeplomDataSet1EmployeeTableAdapter = new WPFUIKitProfessional.DeeplomDataSet1TableAdapters.EmployeeTableAdapter();
            int count = (int)deeplomDataSet1EmployeeTableAdapter.DeleteQuery(employeeId);
            deeplomDataSet1EmployeeTableAdapter.Fill(deeplomDataSet1.Employee);
        }



        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Получить значения из текстовых полей
            string fullName = full_nameTextBox.Text;
            string role = roleTextBox.Text;
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string status = statusTextBox.Text;

            // Создать подключение к базе данных
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JBQOFCV\\SQLEXPRESS;Integrated Security=True"))
            {
                // Открыть подключение
                connection.Open();

                // Создать команду для добавления записи
                using (SqlCommand command = new SqlCommand("INSERT INTO Employee (Full_name, Role, Login, Password, Status) VALUES (@Full_name, @Role, @Login, @Password, @Status)", connection))
                {
                    // Добавить параметры в команду
                    command.Parameters.AddWithValue("@Full_name", fullName);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Status", status);

                    // Выполнить команду
                    command.ExecuteNonQuery();
                }

                // Закрыть подключение
                connection.Close();
            }

            // Обновить данные в таблице
            WPFUIKitProfessional.DeeplomDataSet1 deeplomDataSet1 = ((WPFUIKitProfessional.DeeplomDataSet1)(this.FindResource("deeplomDataSet1")));
            WPFUIKitProfessional.DeeplomDataSet1TableAdapters.EmployeeTableAdapter deeplomDataSet1EmployeeTableAdapter = new WPFUIKitProfessional.DeeplomDataSet1TableAdapters.EmployeeTableAdapter();
            deeplomDataSet1EmployeeTableAdapter.Fill(deeplomDataSet1.Employee);
        }

    }
}
