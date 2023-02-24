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
    /// Interaction logic for ArticlePage.xaml
    /// </summary>
    public partial class ArticlePage : Page
    {
        private HomepageDoctor homepageDoctor = null;
        public ArticlePage(HomepageDoctor hd)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.DataContext = this;
        }

        #region PageLoaded
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BackButton.Focus();
        }
        #endregion

        #region BackToBlog
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showBlogPage();
        }
        #endregion
    }
}
