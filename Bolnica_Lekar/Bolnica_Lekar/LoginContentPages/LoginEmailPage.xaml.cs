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
    /// Interaction logic for InputEmailPage.xaml
    /// </summary>
    public partial class LoginEmailPage : Page, INotifyPropertyChanged
    {
        public MainWindow mainWindow = null;

        public LoginEmailPage(MainWindow mw)
        {
            InitializeComponent();
            this.mainWindow = mw;
            this.DataContext = this;
        }

        #region EmailChanged
        public string EmailChanged
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
                    Console.WriteLine("U Email page " + mainWindow.Email);
                    OnPropertyChanged("EmailChanged");
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

        private void Button_Input_Password(object sender, RoutedEventArgs e)
        {
            this.mainWindow.showLoginPasswordPage();
        }

        private void ButtonToForgottenEmailPage_Click(object sender, RoutedEventArgs e)
        {
            this.mainWindow.showForgottenEmailPage();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            EmailInput.Focus();
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