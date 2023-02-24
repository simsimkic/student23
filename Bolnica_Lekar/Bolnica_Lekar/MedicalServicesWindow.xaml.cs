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

namespace Bolnica_Lekar
{
    /// <summary>
    /// Interaction logic for MedicalServicesWindow.xaml
    /// </summary>
    public partial class MedicalServicesWindow : Window
    {
        public MedicalServicesWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
        }

        #region HandleEscKey
        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }
        #endregion

        #region WindowLoaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FirstItemInAppointmentTab.Focus();
            AppointmentsList.SelectedItem = AppointmentsList.Items.GetItemAt(0);
        }
        #endregion

        #region OpenAppointmentReportWindow
        private void AppointmentsList_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var uiElement = e.OriginalSource as UIElement;
            if (e.Key == Key.Enter && uiElement != null)
            {
                e.Handled = true;
                //Console.WriteLine(uiElement.ToString());
                AppointmentReportWindow appointmentReportWindow = new AppointmentReportWindow(this);
                appointmentReportWindow.Show();
                this.Hide();
            }
        }
        #endregion
    }
}
