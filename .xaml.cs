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

namespace WPFUIKitProfessional
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WPFUIKitProfessional.DeeplomDataSet1 deeplomDataSet1 = ((WPFUIKitProfessional.DeeplomDataSet1)(this.FindResource("deeplomDataSet1")));
            // Загрузить данные в таблицу Employee. Можно изменить этот код как требуется.
            WPFUIKitProfessional.DeeplomDataSet1TableAdapters.EmployeeTableAdapter deeplomDataSet1EmployeeTableAdapter = new WPFUIKitProfessional.DeeplomDataSet1TableAdapters.EmployeeTableAdapter();
            deeplomDataSet1EmployeeTableAdapter.Fill(deeplomDataSet1.Employee);
            System.Windows.Data.CollectionViewSource employeeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("employeeViewSource")));
            employeeViewSource.View.MoveCurrentToFirst();
        }
    }
}
