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
using WPFUIKitProfessional.EntityModel;

namespace ModernCRUD.Pages
{
    public partial class EditDataWin : Window
    {
        ModernCRUDEntities _db = new ModernCRUDEntities();
        int ID;
        public EditDataWin(int CustomerID)
        {
            InitializeComponent();
            ID = CustomerID;

            var st = (from m in _db.CustomerDBs where m.ID == ID select m).First();
            TBName.Text = st.Name;
            TBAddress.Text = st.Address;
            TBPhone.Text = st.Phone;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            CustomerDB updateCustomerDB = (from m in _db.CustomerDBs where m.ID == ID select m).Single();
            updateCustomerDB.Name = TBName.Text;
            updateCustomerDB.Address = TBAddress.Text;
            updateCustomerDB.Phone = TBPhone.Text;
            _db.SaveChanges();
            MainWindow.datagrid.ItemsSource = _db.CustomerDBs.ToList();
            MessageBox.Show("Edit Data Success!", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}
