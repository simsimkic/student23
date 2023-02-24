using Bolnica_Lekar.LoginContentPages;
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

namespace Bolnica_Lekar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        private LoginEmailPage loginEmailPage = null;
        private LoginPasswordPage LoginPasswordPage = null;
        private ForgottenEmailPage forgottenEmailPage = null;
        private ForgottenPasswordPage forgottenPasswordPage = null;

        public string Email { get; set; }
        public string Password { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
        }

        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }

        public void showForgottenEmailPage()
        {
            if (forgottenEmailPage == null)
            {
                Login.Content = new ForgottenEmailPage(this);
            }
            else
            {
                Login.Content = forgottenEmailPage;
            }

            this.Email = "";
        }

        public void showLoginEmailPage()
        {
            if (loginEmailPage == null)
            {
                Login.Content = new LoginEmailPage(this);
            } else
            {
                Login.Content = loginEmailPage;
            }
        }

        public void showLoginPasswordPage()
        {
            if (LoginPasswordPage == null)
            {
                Login.Content = new LoginPasswordPage(this);
            } else
            {
                Login.Content = LoginPasswordPage;
            }
        }

        public void showForgottenPasswordPage()
        {
            if (forgottenPasswordPage == null)
            {
                Login.Content = new ForgottenPasswordPage(this);
            }
            else
            {
                Login.Content = forgottenPasswordPage;
            }

            this.Email = "";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.showLoginEmailPage();
        }

    }
}
