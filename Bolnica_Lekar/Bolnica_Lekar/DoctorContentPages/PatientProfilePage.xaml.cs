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
    /// Interaction logic for PatientProfile.xaml
    /// </summary>
    public partial class PatientProfilePage : Page
    {
        private HomepageDoctor homepageDoctor = null;
        public PatientProfilePage(HomepageDoctor hd)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.DataContext = this;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MedicalRecordButton.Focus();
        }

        #region SeeMedicalRecord
        private void MedicalRecordButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showPatientMedicalRecordPage(false);
        }
        #endregion

        #region AddPrescription
        private void AddPrescriptionButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showAddPrescriptionPage();
        }
        #endregion

        #region ScheduleAppointment
        private void ScheduleAppointmentButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showScheduleAppointmentPage();
        }
        #endregion

        #region ScheduleOperation
        private void ScheduleOperationButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showScheduleDatePage(ScheduleMedicalServices.ScheduleAppointment.BackWindowType.ScheduleOperation);
        }
        #endregion
    }
}
