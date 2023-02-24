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
    /// Interaction logic for DoctorSchedulePage.xaml
    /// </summary>
    public partial class DoctorSchedulePage : Page
    {
        private HomepageDoctor homepageDoctor = null;
        public DoctorSchedulePage(HomepageDoctor hd)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.DataContext = this;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            FirstItemInTab.Focus();
            ListBoxObject.SelectedItem = ListBoxObject.Items.GetItemAt(0);
        }

        private void ListBoxObject_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var uiElement = e.OriginalSource as UIElement;
            if (e.Key == Key.Enter && uiElement != null)
            {
                e.Handled = true;
                //Console.WriteLine(uiElement.ToString());
                this.homepageDoctor.showPatientMedicalRecordPage(true);
            }

        }
    }
}
