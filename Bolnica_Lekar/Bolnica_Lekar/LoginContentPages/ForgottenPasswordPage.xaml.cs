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
    /// Interaction logic for ForgottenPasswordPage.xaml
    /// </summary>
    public partial class ForgottenPasswordPage : Page, INotifyPropertyChanged
    {
        private MainWindow mainWindow = null;
        private string email;
        private string newPassword;
        private string repeatNewPassword;
        public ForgottenPasswordPage(MainWindow mw)
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
                return this.email;
            }
            set
            {
                if (value != this.email)
                {
                    //TODO: Ovde ce se cuvati podaci o promeni i slati zahtev
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

        private void ButtonInputRenewalOfPassword_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Ovde ce se slati zahtev bas
            this.newPassword = NewPasswordInput.Password.ToString();
            this.repeatNewPassword = RepeatNewPasswordInput.Password.ToString();
            Console.WriteLine("New password is: " + this.newPassword);
            Console.WriteLine("Repeat new password is: " + this.repeatNewPassword);
            this.mainWindow.showLoginEmailPage();
        }

        private void ButtonBackToEmailPage_Click(object sender, RoutedEventArgs e)
        {
            this.mainWindow.showLoginEmailPage();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            EmailInput.Focus();
        }
    }
}
