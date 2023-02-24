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
    /// Interaction logic for PrescriptionsWindow.xaml
    /// </summary>
    public partial class PrescriptionsWindow : Window
    {
        public PrescriptionsWindow()
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

        #region LoadPrescriptionData
        private ObservableCollection<PrescriptionClass> LoadPrescriptionData()
        {
            ObservableCollection<PrescriptionClass> prescriptionData = new ObservableCollection<PrescriptionClass>();
            prescriptionData.Add(new PrescriptionClass { DrugName = "Lek 1", PrescriptionQuantity = 2, PrescriptionDate = "22.05.2020.", DoctorName = "Doctor 1"});
            prescriptionData.Add(new PrescriptionClass { DrugName = "Lek 2", PrescriptionQuantity = 1, PrescriptionDate = "25.05.2020.", DoctorName = "Doctor 2" });
            prescriptionData.Add(new PrescriptionClass { DrugName = "Lek 3", PrescriptionQuantity = 3, PrescriptionDate = "26.05.2020.", DoctorName = "Doctor 1" });
            prescriptionData.Add(new PrescriptionClass { DrugName = "Lek 4", PrescriptionQuantity = 2, PrescriptionDate = "27.05.2020.", DoctorName = "Doctor 3" });
            return prescriptionData;
        }
        #endregion

        #region WindowLoaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridPrescriptions.ItemsSource = LoadPrescriptionData();
        }
        #endregion
    }

    public class PrescriptionClass
    {
        public string DrugName { get; set; }
        public int PrescriptionQuantity { get; set; }

        public string PrescriptionDate { get; set; }

        public string DoctorName { get; set; }
    }
}
