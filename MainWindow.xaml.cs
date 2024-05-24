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

namespace WPFUIKitProfessional
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
            Software software = new Software();
            software.Show();
        }

        private void rdMessages_Click(object sender, RoutedEventArgs e)
        {
            Technic technic = new Technic();
            technic.Show();
        }

        private void rdCollections_Click(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
        }

        private void rdUsers_Click(object sender, RoutedEventArgs e)
        {
            Roles form1 = new Roles();
            form1.Show();
        }
    }
}
