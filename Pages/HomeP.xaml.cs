using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace WPFUIKitProfessional.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomeP.xaml
    /// </summary>
    public partial class HomeP : Window
    {
        private string connectionString = "Data Source=DESKTOP-JBQOFCV\\SQLEXPRESS;Initial Catalog=Deeplom;Integrated Security=True";

        public HomeP()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ScriptDB_Click(object sender, RoutedEventArgs e)
        {
            ScriptDatabase();
        }

        private void ResCopyDB_Click(object sender, RoutedEventArgs e)
        {
            BackupDatabase();
        }

        private void ClearDB_Click(object sender, RoutedEventArgs e)
        {
            ClearDatabase();
        }

        private void ScriptDatabase()
        {
            string scriptPath = "C:\\Scripts\\Deeplom.sql";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string script = GetScript(connection);

                File.WriteAllText(scriptPath, script);

                System.Windows.MessageBox.Show("Script saved to " + scriptPath);
            }
        }

        private string GetScript(SqlConnection connection)
        {
            StringBuilder script = new StringBuilder();

            // Script Employee table
            SqlCommand command = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Employee'", connection);
            SqlDataReader reader = command.ExecuteReader();

            script.AppendLine("CREATE TABLE Employee (");
            while (reader.Read())
            {
                string columnName = reader["COLUMN_NAME"].ToString();
                string dataType = reader["DATA_TYPE"].ToString();
                script.AppendLine($"    {columnName} {dataType},");
            }
            script.AppendLine(");");
            reader.Close(); // Close the DataReader

            // Script Order table
            command = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Order'", connection);
            reader = command.ExecuteReader();

            script.AppendLine("CREATE TABLE [Order] (");
            while (reader.Read())
            {
                string columnName = reader["COLUMN_NAME"].ToString();
                string dataType = reader["DATA_TYPE"].ToString();
                script.AppendLine($"    {columnName} {dataType},");
            }
            script.AppendLine(");");
            reader.Close(); // Close the DataReader

            // Script НаличиеОборудования table
            command = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'НаличиеОборудования'", connection);
            reader = command.ExecuteReader();

            script.AppendLine("CREATE TABLE НаличиеОборудования (");
            while (reader.Read())
            {
                string columnName = reader["COLUMN_NAME"].ToString();
                string dataType = reader["DATA_TYPE"].ToString();
                script.AppendLine($"    {columnName} {dataType},");
            }
            script.AppendLine(");");
            reader.Close(); // Close the DataReader

            // Script ПрограммноеОбеспечение table
            command = new SqlCommand("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'ПрограммноеОбеспечение'", connection);
            reader = command.ExecuteReader();

            script.AppendLine("CREATE TABLE ПрограммноеОбеспечение (");
            while (reader.Read())
            {
                string columnName = reader["COLUMN_NAME"].ToString();
                string dataType = reader["DATA_TYPE"].ToString();
                script.AppendLine($"    {columnName} {dataType},");
            }
            script.AppendLine(");");
            reader.Close(); // Close the DataReader

            // Script relationships between tables
            command = new SqlCommand("ALTER TABLE [Order] ADD CONSTRAINT FK_Order_Employee FOREIGN KEY (ID_employee) REFERENCES Employee(ID_employee);", connection);
            script.AppendLine(command.CommandText);

            command = new SqlCommand("ALTER TABLE НаличиеОборудования ADD CONSTRAINT FK_НаличиеОборудования_Employee FOREIGN KEY (ID_employee) REFERENCES Employee(ID_employee);", connection);
            script.AppendLine(command.CommandText);

            command = new SqlCommand("ALTER TABLE ПрограммноеОбеспечение ADD CONSTRAINT FK_ПрограммноеОбеспечение_Employee FOREIGN KEY (ID_employee) REFERENCES Employee(ID_employee);", connection);
            script.AppendLine(command.CommandText);

            return script.ToString();
        }

        private void BackupDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("BACKUP DATABASE Deeplom TO DISK = 'C:\\Backup\\Deeplom.bak'", connection);
                command.ExecuteNonQuery();
                System.Windows.MessageBox.Show("Database backup successful!");
            }
        }

        private void ClearDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("TRUNCATE TABLE [Order]", connection);
                command.ExecuteNonQuery();

                command = new SqlCommand("TRUNCATE TABLE НаличиеОборудования", connection);
                command.ExecuteNonQuery();

                command = new SqlCommand("TRUNCATE TABLE ПрограммноеОбеспечение", connection);
                command.ExecuteNonQuery();

                System.Windows.MessageBox.Show("Database cleared successfully!");
            }
        }
    }
}