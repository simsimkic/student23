using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Bolnica_Lekar.LoginContentPages
{
    /// <summary>
    /// Interaction logic for InputPassword.xaml
    /// </summary>
    public partial class LoginPasswordPage : Page, INotifyPropertyChanged
    {
        public MainWindow mainWindow = null;
        private string password;

        public LoginPasswordPage(MainWindow mw)
        {
            InitializeComponent();
            this.mainWindow = mw;
            this.DataContext = this;
        }

        #region EmailInfo
        public string EmailInfo
        {
            get
            {
                return mainWindow.Email;
            }
            set
            {
                if (value != mainWindow.Email)
                {
                    mainWindow.Email = value;
                    OnPropertyChanged("EmailInfo");
                }
            }
        }
        #endregion

        #region UserInfo
        public string UserInfo
        {
            get
            {
                //TODO: Dobavi iz baze podataka, za odredjeni email, ime i prezime
                return "Name Name";
            }
            set
            {
                if (value != "Name Name")
                {
                    mainWindow.Email = value;
                    OnPropertyChanged("UserInfo");
                }
            }
        }
        #endregion

        #region PropertyChangedNotifier
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        private void Button_Login(object sender, RoutedEventArgs e)
        {
            //TODO: Dodaj proveru za Login
            this.password = PasswordInput.Password.ToString();
            Console.WriteLine("Password je: " + this.password);
            HomepageDoctor homepageDoctor = new HomepageDoctor();
            homepageDoctor.Show();
            mainWindow.Close();
        }

        private void Button_Back_InputMail(object sender, RoutedEventArgs e)
        {
            this.mainWindow.showLoginEmailPage();
        }

        private void ButtonToForgottenPasswordPage_Click(object sender, RoutedEventArgs e)
        {
            this.mainWindow.showForgottenPasswordPage();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PasswordInput.Focus();
        }

        /*public static MainWindow GetMainWindow()
        {
            MainWindow mainWindow = null;

            foreach (Window window in Application.Current.Windows)
            {
                Type type = typeof(MainWindow);
                if (window != null && window.DependencyObjectType.Name == type.Name)
                {
                    mainWindow = (MainWindow)window;
                    if (mainWindow != null)
                    {
                        break;
                    }
                }
            }
            return mainWindow;
        }*/
    }
}
