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
using System.Windows.Shapes;

namespace Bolnica_Lekar
{
    /// <summary>
    /// Interaction logic for AppointmentReportWindow.xaml
    /// </summary>
    public partial class AppointmentReportWindow : Window
    {
        private MedicalServicesWindow medicalServicesWindow = null;
        public AppointmentReportWindow(MedicalServicesWindow msw)
        {
            InitializeComponent();
            this.DataContext = this;
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
            medicalServicesWindow = msw;
        }

        #region LoadDiagnosisData
        private ObservableCollection<DiagnosisClass> LoadDiagnosisData()
        {
            ObservableCollection<DiagnosisClass> diagnosisData = new ObservableCollection<DiagnosisClass>();
            diagnosisData.Add(new DiagnosisClass { DiagnosisId = 1, DiagnosisName = "Alergija 1", DiagnosisIsChecked = true});
            diagnosisData.Add(new DiagnosisClass { DiagnosisId = 4, DiagnosisName = "Alergija 4", DiagnosisIsChecked = true });
            return diagnosisData;
        }
        #endregion

        #region HandleEscKey
        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.medicalServicesWindow.Show();
                Close();
            }
        }
        #endregion

        #region WindowLoaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProblemDescriptionTextBox.Focus();
            DataGridDiagnosis.ItemsSource = LoadDiagnosisData();
        }
        #endregion

        #region BackToPastMedicalServicesWindow
        private void BackToPastMedicalServicesWindow_Click(object sender, RoutedEventArgs e)
        {
            this.medicalServicesWindow.Show();
            this.Close();
        }
        #endregion
    }

    public class DiagnosisClass {
        public bool DiagnosisIsChecked { get; set; }
        public long DiagnosisId { get; set; }
        public String DiagnosisName { get; set; }
    }
}
