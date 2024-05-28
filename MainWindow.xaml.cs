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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFUIKitProfessional.Themes;
using WPFUIKitProfessional.Pages;
using System.Data;
using System.Data.SqlClient;

namespace WPFUIKitProfessional
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Software softwareForm;
        private Technic technicForm;
        private Orders ordersForm;
        private Roles rolesForm;
        private bool isSoftwareFormOpen = false;
        private bool isTechnicFormOpen = false;
        private bool isOrdersFormOpen = false;
        private bool isRolesFormOpen = false;

        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void Themes_Click(object sender, RoutedEventArgs e)
        {
            if (Themes.IsChecked == true)
                ThemesController.SetTheme(ThemesController.ThemeTypes.Dark);
            else
                ThemesController.SetTheme(ThemesController.ThemeTypes.Light);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void rdHome_Click(object sender, RoutedEventArgs e)
        {
            frameContent.Navigate(new Home());
        }

        private void rdAnalytics_Click(object sender, RoutedEventArgs e)
        {
            if (!isSoftwareFormOpen)
            {
                softwareForm = new Software();
                softwareForm.Closed += SoftwareForm_Closed;
                softwareForm.Show();
                isSoftwareFormOpen = true;
            }
            else
            {
                softwareForm.Activate();
            }
        }

        private void SoftwareForm_Closed(object sender, EventArgs e)
        {
            isSoftwareFormOpen = false;
            softwareForm.Closed -= SoftwareForm_Closed;
        }

        private void rdMessages_Click(object sender, RoutedEventArgs e)
        {
            if (!isTechnicFormOpen)
            {
                technicForm = new Technic();
                technicForm.Closed += TechnicForm_Closed;
                technicForm.Show();
                isTechnicFormOpen = true;
            }
            else
            {
                technicForm.Activate();
            }
        }

        private void TechnicForm_Closed(object sender, EventArgs e)
        {
            isTechnicFormOpen = false;
            technicForm.Closed -= TechnicForm_Closed;
        }

        private void rdOrders_Click(object sender, RoutedEventArgs e)
        {
            if (!isOrdersFormOpen)
            {
                ordersForm = new Orders();
                ordersForm.Closed += OrdersForm_Closed;
                ordersForm.Show();
                isOrdersFormOpen = true;
            }
            else
            {
                ordersForm.Activate();
            }
        }

        private void OrdersForm_Closed(object sender, EventArgs e)
        {
            isOrdersFormOpen = false;
            ordersForm.Closed -= OrdersForm_Closed;
        }

        private void rdUsers_Click(object sender, RoutedEventArgs e)
        {
            if (!isRolesFormOpen)
            {
                // Отобразить окно для ввода данных администратора
                var login = new CheckWindow();
                login.ShowDialog();

                if (login.DialogResult == true)
                {
                    // Проверить, введены ли правильные данные администратора
                    if (login.LoginText == "4" && login.PasswordText == "5")
                    {
                        rolesForm = new Roles();
                        rolesForm.Closed += RolesForm_Closed;
                        rolesForm.Show();
                        isRolesFormOpen = true;
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль администратора.");
                    }
                }
            }
            else
            {
                rolesForm.Activate();
            }
        }

        private void RolesForm_Closed(object sender, EventArgs e)
        {
            isRolesFormOpen = false;
            rolesForm.Closed -= RolesForm_Closed;
        }
    }
}