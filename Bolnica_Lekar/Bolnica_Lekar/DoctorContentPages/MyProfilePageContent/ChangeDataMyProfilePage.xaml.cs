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

namespace Bolnica_Lekar.DoctorContentPages.MyProfilePageContent
{
    /// <summary>
    /// Interaction logic for ChangeDataMyProfilePage.xaml
    /// </summary>
    public partial class ChangeDataMyProfilePage : Page, INotifyPropertyChanged
    {
        private HomepageDoctor homepageDoctor = null;
        private MyProfilePage myProfilePage = null;
        private string name = "";
        private string country = "";
        private string city = "";
        private string address = "";
        private string flatNumber = "";
        private string email = "";
        public ChangeDataMyProfilePage(HomepageDoctor hd, MyProfilePage mpp)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.myProfilePage = mpp;
            this.DataContext = this;
        }

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
                    this.name = value;
                    OnPropertyChanged("NameChanged");
                }
            }
        }
        #endregion

        #region AddressChanged
        public string AddressChanged
        {
            get
            {
                return this.address;
            }
            set
            {
                if (value != this.address)
                {
                    this.address = value;
                    OnPropertyChanged("AddressChanged");
                }
            }
        }
        #endregion

        #region FlatNumberChanged
        public string FlatNumberChanged
        {
            get
            {
                return this.flatNumber;
            }
            set
            {
                if (value != this.flatNumber)
                {
                    this.flatNumber = value;
                    OnPropertyChanged("FlatNumberChanged");
                }
            }
        }
        #endregion

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
                    this.email = value;
                    OnPropertyChanged("EmailChanged");
                }
            }
        }
        #endregion

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Ovde ces cuvati promene
            this.homepageDoctor.showMyProfilePage();
        }

        private void BackToMyProfile_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showMyProfilePage();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            NameInput.Focus();
        }
    }
}
