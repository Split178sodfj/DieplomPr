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
    /// Логика взаимодействия для CheckWindow.xaml
    /// </summary>
    public partial class CheckWindow : Window
    {
        public CheckWindow()
        {
            InitializeComponent();
        }

            public string LoginText { get; private set; }
            public string PasswordText { get; private set; }

            

            private void btnOK_Click(object sender, RoutedEventArgs e)
            {
                LoginText = txtLogin.Text;
                PasswordText = txtPassword.Password;
                DialogResult = true;
                Close();
            }

            private void btnCancel_Click(object sender, RoutedEventArgs e)
            {
                DialogResult = false;
                Close();
            }
        }
    }
