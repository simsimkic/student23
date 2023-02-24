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
    /// Interaction logic for AddPrescriptionPage.xaml
    /// </summary>
    public partial class AddPrescriptionPage : Page
    {
        private HomepageDoctor homepageDoctor = null;
        private ObservableCollection<DrugsRegistryClass> drugsRegistry;
        private IList<DrugsRegistryClass> chosenDrugs;

        public AddPrescriptionPage(HomepageDoctor hd)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.DataContext = this;
        }

        #region LoadDrugsRegistryData
        private ObservableCollection<DrugsRegistryClass> LoadDrugsRegistryData()
        {
            ObservableCollection<DrugsRegistryClass> drugsRegistryData = new ObservableCollection<DrugsRegistryClass>();
            drugsRegistryData.Add(new DrugsRegistryClass { DrugId = 1, DrugName = "Lek 1", DrugQuantity = 0 });
            drugsRegistryData.Add(new DrugsRegistryClass { DrugId = 2, DrugName = "Lek 2", DrugQuantity = 0 });
            drugsRegistryData.Add(new DrugsRegistryClass { DrugId = 3, DrugName = "Lek 3", DrugQuantity = 0 });
            drugsRegistryData.Add(new DrugsRegistryClass { DrugId = 4, DrugName = "Lek 4", DrugQuantity = 0 });
            return drugsRegistryData;
        }
        #endregion

        #region PageLoaded
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            drugsRegistry = LoadDrugsRegistryData();
            chosenDrugs = new ObservableCollection<DrugsRegistryClass>();
            DataGridDrugsRegistry.ItemsSource = drugsRegistry;
            DataGridChosenDrugs.ItemsSource = chosenDrugs;

            //Set first field as focused
            DataGridDrugsRegistry.SelectedIndex = 0;
            DataGridDrugsRegistry.Focus();
        }
        #endregion

        #region DataGridDrugsRegistryPreviewKeyDownEnter
        private void DataGridDrugsRegistry_PreviewKeyDown(object sender, KeyEventArgs e)
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
                DrugsRegistryClass item = dg.ItemContainerGenerator.ItemFromContainer(row) as DrugsRegistryClass;

                //DataGridChosenDrugs.Items.Add(item);
                chosenDrugs.Add(item);
                drugsRegistry.Remove(item);

                focusCellOnSpecificIndex(DataGridDrugsRegistry, index);
                if (DataGridDrugsRegistry.Items.Count == 0)
                {
                    focusCellOnSpecificIndex(DataGridChosenDrugs, 0);
                }

            }
            else if (e.Key == Key.S && uiElement != null)
            {
                focusCellOnSpecificIndex(DataGridChosenDrugs, 0);
            }
        }
        #endregion

        #region DataGridChosenDrugPreviewKeyDownEnter
        private void DataGridChosenDrugs_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var uiElement = e.OriginalSource as UIElement;
            if (e.Key == Key.Delete && uiElement != null)
            {
                e.Handled = true;
                var dg = sender as DataGrid;
                if (dg == null) return;
                var index = dg.SelectedIndex;
                //here we get the actual row at selected index
                DataGridRow row = dg.ItemContainerGenerator.ContainerFromIndex(index) as DataGridRow;

                //here we get the actual data item behind the selected row
                DrugsRegistryClass item = dg.ItemContainerGenerator.ItemFromContainer(row) as DrugsRegistryClass;

                //DataGridChosenDrugs.Items.Add(item);
                drugsRegistry.Add(item);
                chosenDrugs.Remove(item);

                focusCellOnSpecificIndex(DataGridChosenDrugs, index);
                if (DataGridChosenDrugs.Items.Count == 0)
                {
                    focusCellOnSpecificIndex(DataGridDrugsRegistry, 0);
                }

            } 
            else if (e.Key == Key.S && uiElement != null)
            {
                ConfirmPrescriptionButton.Focus();
            } 
            else if (e.Key == Key.W && uiElement != null)
            {
                focusCellOnSpecificIndex(DataGridDrugsRegistry, 0);
            }
        }
        #endregion

        #region FocuseCellOnSpecificIndex
        public void focusCellOnSpecificIndex(DataGrid dg, int cellIndex)
        {
            if (dg.Items.Count > 0)
            {
                dg.Focus();
                dg.SelectedIndex = cellIndex;
                var cellcontent = dg.Columns[0].GetCellContent(dg.Items[cellIndex]);
                var cell = cellcontent?.Parent as DataGridCell;
                if (cell != null)
                {
                    cell.Focus();
                }
            }
        }
        #endregion

        #region ConfirmPrescription
        private void ConfirmPrescriptionButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showPatientProfilePage();
        }
        #endregion

        #region CancelPrescription
        private void CancelPrescriptiontButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showPatientProfilePage();
        }
        #endregion
    }

    public class DrugsRegistryClass : INotifyPropertyChanged
    {
        private int drugQuantity;
        public long DrugId { get; set; }
        public string DrugName { get; set; }

        #region DrugQuantityProperty
        public int DrugQuantity
        {
            get { return drugQuantity; }
            set { drugQuantity = value; NotifyPropertyChanged("DrugQuantity"); }
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
