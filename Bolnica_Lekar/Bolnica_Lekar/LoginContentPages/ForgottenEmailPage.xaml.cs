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
    /// Interaction logic for ForgottenEmailPage.xaml
    /// </summary>
    public partial class ForgottenEmailPage : Page, INotifyPropertyChanged
    {
        private MainWindow mainWindow = null;
        private string name;
        private string lastname;
        private string JMBG;
        private string newEmail;

        public ForgottenEmailPage(MainWindow mw)
        {
            InitializeComponent();
            this.mainWindow = mw;
            this.DataContext = this;
        }

        #region NameChanged
        public string NameChanged
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != this.name)
                {
                //TODO: Ovde ce se cuvati podaci o promeni i slati zahtev
                    OnPropertyChanged("NameChanged");
                }
            }
        }
        #endregion

        #region LastnameChanged
        public string LastnameChanged
        {
            get
            {
                return this.lastname;
            }
            set
            {
                if (value != this.lastname)
                {
                    //TODO: Ovde ce se cuvati podaci o promeni i slati zahtev
                    OnPropertyChanged("LastnameChanged");
                }
            }
        }
        #endregion

        #region JMBGChanged
        public string JMBGChanged
        {
            get
            {
                return this.JMBG;
            }
            set
            {
                if (value != this.JMBG)
                {
                    //TODO: Ovde ce se cuvati podaci o promeni i slati zahtev
                    OnPropertyChanged("JMBGChanged");
                }
            }
        }
        #endregion

        #region NewEmailChanged
        public string NewEmailChanged
        {
            get
            {
                return this.newEmail;
            }
            set
            {
                if (value != this.newEmail)
                {
                    //TODO: Ovde ce se cuvati podaci o promeni i slati zahtev
                    OnPropertyChanged("NewEmailChanged");
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

        private void ButtonInputRenewalOfEmail_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Ovde ce se slati zahtev bas
            this.mainWindow.showLoginEmailPage();
        }

        private void ButtonBackToEmailPage_Click(object sender, RoutedEventArgs e)
        {
            this.mainWindow.showLoginEmailPage();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            NameInput.Focus();
        }
    }
}
