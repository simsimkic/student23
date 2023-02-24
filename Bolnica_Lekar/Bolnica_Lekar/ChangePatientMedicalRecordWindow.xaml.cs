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
using System.Windows.Shapes;

namespace Bolnica_Lekar
{
    /// <summary>
    /// Interaction logic for ChangePatientMedicalRecordWindow.xaml
    /// </summary>
    public partial class ChangePatientMedicalRecordWindow : Window
    {
        public ChangePatientMedicalRecordWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
        }

        #region LoadAllergyData
        private ObservableCollection<AllergyClass> LoadAllergyData()
        {
            ObservableCollection<AllergyClass> allergyData = new ObservableCollection<AllergyClass>();
            allergyData.Add(new AllergyClass { AllergyId = 1, AllergyName = "Alergija 1", AllergyIsChecked = false });
            allergyData.Add(new AllergyClass { AllergyId = 2, AllergyName = "Alergija 2", AllergyIsChecked = false });
            allergyData.Add(new AllergyClass { AllergyId = 3, AllergyName = "Alergija 3", AllergyIsChecked = false });
            allergyData.Add(new AllergyClass { AllergyId = 4, AllergyName = "Alergija 4", AllergyIsChecked = false });
            return allergyData;
        }
        #endregion

        #region DataGridPreviewKeyDown
        private void DataGridAllergy_PreviewKeyDown(object sender, KeyEventArgs e)
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
                AllergyClass item = dg.ItemContainerGenerator.ItemFromContainer(row) as AllergyClass;

                item.AllergyIsChecked = !item.AllergyIsChecked;
                Console.WriteLine(item.AllergyIsChecked);
            }
        }
        #endregion

        #region HandleEscKey
        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }
        #endregion

        #region WindowLoaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WeightTextBox.Focus();
            DataGridAllergy.ItemsSource = LoadAllergyData();
        }
        #endregion

        #region SaveChanges
        private void SaveChangesButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Ovde ce ici logika za cuvanje podatak
            this.Close();
        }
        #endregion

        #region CancelChanges
        private void CancelChangesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion
    }

    public class AllergyClass : INotifyPropertyChanged
    {
        private bool allergyIsChecked;
        public long AllergyId { get; set; }
        public string AllergyName { get; set; }

        #region AllergyIsCheckedPropery
        public bool AllergyIsChecked
        {
            get { return allergyIsChecked; }
            set { allergyIsChecked = value; NotifyPropertyChanged("AllergyIsChecked"); }
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
