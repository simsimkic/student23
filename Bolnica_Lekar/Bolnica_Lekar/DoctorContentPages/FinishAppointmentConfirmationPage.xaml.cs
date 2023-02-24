using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for FinishAppointmentConfirmationPage.xaml
    /// </summary>
    public partial class FinishAppointmentConfirmationPage : Page
    {
        private HomepageDoctor homepageDoctor = null;
        public FinishAppointmentConfirmationPage(HomepageDoctor hd)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.DataContext = this;
        }

        #region LoadDiagnosisData
        private ObservableCollection<DiagnosisClass> LoadDiagnosisData()
        {
            ObservableCollection<DiagnosisClass> diagnosisData = new ObservableCollection<DiagnosisClass>();
            diagnosisData.Add(new DiagnosisClass { DiagnosisId = 1, DiagnosisName = "Alergija 1", DiagnosisIsChecked = true });
            diagnosisData.Add(new DiagnosisClass { DiagnosisId = 4, DiagnosisName = "Alergija 4", DiagnosisIsChecked = true });
            return diagnosisData;
        }
        #endregion

        #region PageLoaded
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ProblemDescriptionTextBox.Focus();
            DataGridDiagnosis.ItemsSource = LoadDiagnosisData();
        }
        #endregion

        #region ChangeMedicalReport
        private void ChangeMedicalReportButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showPatientMedicalRecordPage(true);
        }
        #endregion

        #region ConfirmMedicalReport
        private void ConfirmMedicalReportButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showPatientProfilePage();
        }
        #endregion
    }

}
