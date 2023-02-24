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

namespace Bolnica_Lekar.DoctorContentPages.ScheduleMedicalServices.ScheduleAppointment
{
    /// <summary>
    /// Interaction logic for ScheduleAppointmentPage.xaml
    /// </summary>
    public partial class ScheduleAppointmentPage : Page
    {
        private HomepageDoctor homepageDoctor = null;
        public ScheduleAppointmentPage(HomepageDoctor hd)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.DataContext = this;
        }

        #region PageLoaded
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AppointmentWithMeButton.Focus();
        }
        #endregion

        #region AppointmentWithMe
        private void AppointmentWithMeButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showScheduleDatePage(BackWindowType.ScheduleAppointmentForMe);
        }
        #endregion

        #region AppointmentWithOtherDoctor
        private void AppointmentWithOtherDoctorButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showChooseDoctorPage();
        }
        #endregion
    }
}
