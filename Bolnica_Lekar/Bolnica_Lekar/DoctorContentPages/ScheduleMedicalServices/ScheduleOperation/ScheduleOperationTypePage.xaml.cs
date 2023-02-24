using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bolnica_Lekar.DoctorContentPages.ScheduleMedicalServices.ScheduleOperation
{
    /// <summary>
    /// Interaction logic for ScheduleOperationType.xaml
    /// </summary>
    public partial class ScheduleOperationTypePage : Page
    {
        private HomepageDoctor homepageDoctor = null;
        public ScheduleOperationTypePage(HomepageDoctor hd)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.DataContext = this;

            Loaded += (s, e) =>
            {
                Console.WriteLine("Loaded u konstruktoru");
                focusCellOnSpecificIndex(DataGridOperationType, 0);
            };
        }

        #region LoadOperationTypeData
        private ObservableCollection<OperationTypeClass> LoadOperationTypeData()
        {
            ObservableCollection<OperationTypeClass> operationTypeData = new ObservableCollection<OperationTypeClass>();
            operationTypeData.Add(new OperationTypeClass { OperationTypeId = 1, OperationTypeName = "Tip 1", OperationTypeChosen = false });
            operationTypeData.Add(new OperationTypeClass { OperationTypeId = 2, OperationTypeName = "Tip 2", OperationTypeChosen = false });
            operationTypeData.Add(new OperationTypeClass { OperationTypeId = 3, OperationTypeName = "Tip 3", OperationTypeChosen = false });
            operationTypeData.Add(new OperationTypeClass { OperationTypeId = 4, OperationTypeName = "Tip 4", OperationTypeChosen = false });
            operationTypeData.Add(new OperationTypeClass { OperationTypeId = 5, OperationTypeName = "Tip 5", OperationTypeChosen = false });
            operationTypeData.Add(new OperationTypeClass { OperationTypeId = 6, OperationTypeName = "Tip 6", OperationTypeChosen = false });
            return operationTypeData;
        }
        #endregion

        #region PageLoaded
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Page loaded");
            DataGridOperationType.ItemsSource = LoadOperationTypeData();
            //Set first field as focused
            //DataGridOperationType.SelectedIndex = 0;
            //DataGridOperationType.Focus();
            //focusCellOnSpecificIndex(DataGridOperationType, 0);
        }
        #endregion

        #region DataGridOperationTypeEnter
        private void DataGridOperationType_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var uiElement = e.OriginalSource as UIElement;
            if (e.Key == Key.Enter && uiElement != null)
            {
                e.Handled = true;
                //Console.WriteLine("USAO OVDE U ENTER");
                var dg = sender as DataGrid;
                if (dg == null) return;
                var index = dg.SelectedIndex;
                //here we get the actual row at selected index
                DataGridRow row = dg.ItemContainerGenerator.ContainerFromIndex(index) as DataGridRow;

                //here we get the actual data item behind the selected row
                OperationTypeClass item = dg.ItemContainerGenerator.ItemFromContainer(row) as OperationTypeClass;
                
                item.OperationTypeChosen = true;
            }
            else if (e.Key == Key.S && uiElement != null)
            {
                ContinueButton.Focus();
            }
        }
        #endregion

        #region ContinueButtonClick
        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showPatientProfilePage();
        }
        #endregion

        #region BackButtonClick
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showScheduleDatePage(ScheduleAppointment.BackWindowType.ScheduleOperation);
        }
        #endregion

        #region FocuseCellOnSpecificIndex
        public void focusCellOnSpecificIndex(DataGrid dg, int cellIndex)
        {
            if (dg.Items.Count > 0)
            {
                dg.Focus();
                dg.SelectedIndex = cellIndex;
                Console.WriteLine("Broj elemenata: " + dg.Items.Count);
                var cellcontent = dg.Columns[0].GetCellContent(dg.Items[cellIndex]);
                Console.WriteLine("Content: " + cellcontent);
                var cell = cellcontent?.Parent as DataGridCell;
                if (cell != null)
                {
                    Console.WriteLine("2");
                    cell.Focus();
                }
            }
        }
        #endregion

    }

    public class OperationTypeClass : INotifyPropertyChanged
    {
        private bool operationTypeChosen;
        public long OperationTypeId { get; set; }
        public string OperationTypeName { get; set; }

        #region OperationTypeChosenProperty
        public bool OperationTypeChosen
        {
            get { return operationTypeChosen; }
            set { operationTypeChosen = value; NotifyPropertyChanged("OperationTypeChosen"); }
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
