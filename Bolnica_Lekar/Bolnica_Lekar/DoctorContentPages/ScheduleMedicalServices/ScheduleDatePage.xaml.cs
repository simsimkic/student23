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
    /// Interaction logic for ScheduleDatePage.xaml
    /// </summary>
    public partial class ScheduleDatePage : Page
    {
        private HomepageDoctor homepageDoctor = null;
        private BackWindowType backWindowType;
        public ScheduleDatePage(HomepageDoctor hd, BackWindowType bwt)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.DataContext = this;
            this.backWindowType = bwt;
        }

        #region PageLoaded
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
        }
        #endregion

        #region ContinueToChooseRoom
        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.backWindowType == BackWindowType.ScheduleOperation)
            {
                this.homepageDoctor.showOperationTypePage();
            }
            else
            {
                this.homepageDoctor.showScheduleRoomPage(this.backWindowType);
            }
            #endregion
        }

        #region Back
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.backWindowType == BackWindowType.ScheduleAppointmentForMe)
            {
                this.homepageDoctor.showScheduleAppointmentPage();
            } else if (this.backWindowType == BackWindowType.ScheduleAppointmentForOtherDoctor)
            {
                this.homepageDoctor.showChooseDoctorPage();
            } else if (this.backWindowType == BackWindowType.ScheduleOperation)
            {
                this.homepageDoctor.showPatientProfilePage();
            }
        }
        #endregion
    }

    public enum BackWindowType
    {
        ScheduleAppointmentForMe = 0,
        ScheduleAppointmentForOtherDoctor = 1,
        ScheduleOperation = 2
    }
}
