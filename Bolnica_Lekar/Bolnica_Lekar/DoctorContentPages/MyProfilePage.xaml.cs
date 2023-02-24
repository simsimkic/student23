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

namespace Bolnica_Lekar.DoctorContentPages
{
    /// <summary>
    /// Interaction logic for MyProfilePage.xaml
    /// </summary>
    public partial class MyProfilePage : Page
    {
        private HomepageDoctor homepageDoctor = null;
        public MyProfilePage(HomepageDoctor hd)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.DataContext = this;
        }

        private void ChangeProfileData_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showChangedDataMyProfilePage();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ChangeProfileButton.Focus();
        }
    }
}
