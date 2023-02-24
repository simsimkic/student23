using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Bolnica_Lekar.DoctorContentPages
{
    /// <summary>
    /// Interaction logic for PatientMedicalRecordPage.xaml
    /// </summary>
    public partial class PatientMedicalRecordPage : Page, INotifyPropertyChanged
    {
        private HomepageDoctor homepageDoctor = null;
        private bool isAppointment = false;
        private String lastButtonContent = "";

        public PatientMedicalRecordPage(HomepageDoctor hd)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.DataContext = this;
        }

        #region IsAppointmentProperty
        public bool IsAppointment
        {
            get
            {
                return isAppointment;
            }

            set
            {
                isAppointment = value;
                if (isAppointment)
                {
                    this.LastButtonContent = "Izmeni zdravstveni karton";
                } else
                {
                    this.LastButtonContent = "Nazad";
                }
                NotifyPropertyChanged("IsAppointment");
            }
        }
        #endregion

        #region LastButtonProperty
        public String LastButtonContent
        {
            get
            {
                return lastButtonContent;
            }

            set
            {
                lastButtonContent = value;
                NotifyPropertyChanged("LastButtonContent");
            }
        }
        #endregion

        #region PropertyChangedNotifier
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        #endregion

        #region LoadAllergyData
        private ObservableCollection<AllergyClass> LoadAllergyData()
        {
            ObservableCollection<AllergyClass> allergyData = new ObservableCollection<AllergyClass>();
            allergyData.Add(new AllergyClass { AllergyId = 1, AllergyName = "Alergija 1" });
            allergyData.Add(new AllergyClass { AllergyId = 2, AllergyName = "Alergija 2" });
            allergyData.Add(new AllergyClass { AllergyId = 3, AllergyName = "Alergija 3" });
            allergyData.Add(new AllergyClass { AllergyId = 4, AllergyName = "Alergija 4" });
            return allergyData;
        }
        #endregion

        #region LoadDiagnosisData
        private ObservableCollection<DiagnosisClass> LoadDiagnosisData()
        {
            ObservableCollection<DiagnosisClass> diagnosisData = new ObservableCollection<DiagnosisClass>();
            diagnosisData.Add(new DiagnosisClass { DiagnosisId = 1, DiagnosisName = "Alergija 1", DiagnosisIsChecked = false });
            diagnosisData.Add(new DiagnosisClass { DiagnosisId = 2, DiagnosisName = "Alergija 2", DiagnosisIsChecked = false });
            diagnosisData.Add(new DiagnosisClass { DiagnosisId = 3, DiagnosisName = "Alergija 3", DiagnosisIsChecked = false });
            diagnosisData.Add(new DiagnosisClass { DiagnosisId = 4, DiagnosisName = "Alergija 4", DiagnosisIsChecked = false });
            diagnosisData.Add(new DiagnosisClass { DiagnosisId = 5, DiagnosisName = "Alergija 5", DiagnosisIsChecked = false });
            Console.WriteLine(diagnosisData.Count);
            return diagnosisData;
        }
        #endregion

        #region PageLoaded
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ShowPastPrescriptionsButton.Focus();
            DataGridAllergy.ItemsSource = LoadAllergyData();
            DataGridDiagnosis.ItemsSource = LoadDiagnosisData();
        }
        #endregion

        #region DataGridPreviewKeyDown
        private void DataGridDiagnosis_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var uiElement = e.OriginalSource as UIElement;
            if (e.Key == Key.Enter && uiElement != null)
            {
                e.Handled = true;
                //Console.WriteLine(uiElement.ToString());
                var dg = sender as DataGrid;
                if (dg == null) return;
                var index = dg.SelectedIndex;
                //here we get the actual row at selected index
                DataGridRow row = dg.ItemContainerGenerator.ContainerFromIndex(index) as DataGridRow;

                //here we get the actual data item behind the selected row
                DiagnosisClass item = dg.ItemContainerGenerator.ItemFromContainer(row) as DiagnosisClass;
                
                item.DiagnosisIsChecked = !item.DiagnosisIsChecked;
                Console.WriteLine(item.DiagnosisIsChecked);
            }
        }
        #endregion

        #region OpenPrescriptionWindowButton
        private void ShowPastPrescriptionsButton_Click(object sender, RoutedEventArgs e)
        {
            PrescriptionsWindow prescriptionsWindow = new PrescriptionsWindow();
            prescriptionsWindow.Show();
        }
        #endregion

        #region OpenMedicalServicesWindowButton
        private void ShowPastMedicalServicesButton_Click(object sender, RoutedEventArgs e)
        {
            MedicalServicesWindow medicalServicesWindow = new MedicalServicesWindow();
            medicalServicesWindow.Show();
        }
        #endregion

        #region LastButton
        private void LastButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.isAppointment)
            {
                ChangePatientMedicalRecordWindow changePatientMedicalRecordWindow = new ChangePatientMedicalRecordWindow();
                changePatientMedicalRecordWindow.Show();
            } else
            {
                this.homepageDoctor.showPatientProfilePage();
            }
            
        }
        #endregion

        #region FinishAppointment
        private void FinishAppointmentButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showFinishedAppointmentConfirmationPage();
        }
        #endregion
    }

    public class AllergyClass
    {
        public long AllergyId { get; set; }
        public string AllergyName { get; set; }
    }

    public class DiagnosisClass : INotifyPropertyChanged
    {
        private bool diagnosisIsChecked;
        public long DiagnosisId { get; set; }
        public String DiagnosisName { get; set; }

        #region DiagnosisIsCheckedPropery
        public bool DiagnosisIsChecked
        {
            get { return diagnosisIsChecked; }
            set { diagnosisIsChecked = value; NotifyPropertyChanged("DiagnosisIsChecked"); }
        }
        #endregion

        #region PropertyChangedNotifier
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        #endregion
    }

}
