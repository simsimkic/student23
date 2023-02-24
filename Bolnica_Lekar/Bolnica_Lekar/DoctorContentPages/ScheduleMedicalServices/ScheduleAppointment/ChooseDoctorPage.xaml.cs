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

namespace Bolnica_Lekar.DoctorContentPages.ScheduleMedicalServices.ScheduleAppointment
{
    /// <summary>
    /// Interaction logic for ChooseDoctorPage.xaml
    /// </summary>
    public partial class ChooseDoctorPage : Page
    {
        private HomepageDoctor homepageDoctor = null;
        public ChooseDoctorPage(HomepageDoctor hd)
        {
            InitializeComponent(); 
            this.homepageDoctor = hd;
            this.DataContext = this;
        }

        #region LoadServiceTypeData
        private ObservableCollection<ServiceTypeClass> LoadServiceTypeData()
        {
            ObservableCollection<ServiceTypeClass> serviceTypeData = new ObservableCollection<ServiceTypeClass>();
            serviceTypeData.Add(new ServiceTypeClass { ServiceTypeId = 1, ServiceTypeName = "Tip 1", ServiceTypeChosen = false });
            serviceTypeData.Add(new ServiceTypeClass { ServiceTypeId = 2, ServiceTypeName = "Tip 2", ServiceTypeChosen = false });
            serviceTypeData.Add(new ServiceTypeClass { ServiceTypeId = 3, ServiceTypeName = "Tip 3", ServiceTypeChosen = false });
            serviceTypeData.Add(new ServiceTypeClass { ServiceTypeId = 4, ServiceTypeName = "Tip 4", ServiceTypeChosen = false });
            serviceTypeData.Add(new ServiceTypeClass { ServiceTypeId = 5, ServiceTypeName = "Tip 5", ServiceTypeChosen = false });
            serviceTypeData.Add(new ServiceTypeClass { ServiceTypeId = 6, ServiceTypeName = "Tip 6", ServiceTypeChosen = false });
            return serviceTypeData;
        }
        #endregion

        #region LoadChooseDoctorData
        private ObservableCollection<ChooseDoctorClass> LoadChooseDoctorData()
        {
            ObservableCollection<ChooseDoctorClass> chooseDoctorData = new ObservableCollection<ChooseDoctorClass>();
            chooseDoctorData.Add(new ChooseDoctorClass { ChooseDoctorId = 1, ChooseDoctorName = "Doktor 1", ChooseDoctorChosen = false });
            chooseDoctorData.Add(new ChooseDoctorClass { ChooseDoctorId = 2, ChooseDoctorName = "Doktor 2", ChooseDoctorChosen = false });
            chooseDoctorData.Add(new ChooseDoctorClass { ChooseDoctorId = 3, ChooseDoctorName = "Doktor 3", ChooseDoctorChosen = false });
            chooseDoctorData.Add(new ChooseDoctorClass { ChooseDoctorId = 4, ChooseDoctorName = "Doktor 4", ChooseDoctorChosen = false });
            chooseDoctorData.Add(new ChooseDoctorClass { ChooseDoctorId = 5, ChooseDoctorName = "Doktor 5", ChooseDoctorChosen = false });
            chooseDoctorData.Add(new ChooseDoctorClass { ChooseDoctorId = 6, ChooseDoctorName = "Doktor 6", ChooseDoctorChosen = false });
            return chooseDoctorData;
        }
        #endregion

        #region PageLoaded
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridServiceType.ItemsSource = LoadServiceTypeData();
            DataGridChooseDoctor.ItemsSource = LoadChooseDoctorData();
        }
        #endregion

        #region ServiceTypeEnterKey
        private void DataGridServiceType_PreviewKeyDown(object sender, KeyEventArgs e)
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
                ServiceTypeClass item = dg.ItemContainerGenerator.ItemFromContainer(row) as ServiceTypeClass;

                item.ServiceTypeChosen = true;
            }
        }
        #endregion

        #region ChooseDoctorEnterKey
        private void DataGridChooseDoctor_PreviewKeyDown(object sender, KeyEventArgs e)
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
                ChooseDoctorClass item = dg.ItemContainerGenerator.ItemFromContainer(row) as ChooseDoctorClass;

                item.ChooseDoctorChosen = true;
            }
        }
        #endregion

        #region ContinueToScheduleDate
        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showScheduleDatePage(BackWindowType.ScheduleAppointmentForOtherDoctor);
        }
        #endregion

        #region BackToScheduleAppointmentFirstPage
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showScheduleAppointmentPage();
        }
        #endregion
    }

    public class ServiceTypeClass : INotifyPropertyChanged
    {
        private bool serviceTypeChosen;
        public long ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }

        #region ServiceTypeChosenProperty
        public bool ServiceTypeChosen
        {
            get { return serviceTypeChosen; }
            set { serviceTypeChosen = value; NotifyPropertyChanged("ServiceTypeChosen"); }
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

    public class ChooseDoctorClass : INotifyPropertyChanged
    {
        private bool chooseDoctorChosen;
        public long ChooseDoctorId { get; set; }
        public string ChooseDoctorName { get; set; }

        #region ChooseDoctorChosenProperty
        public bool ChooseDoctorChosen
        {
            get { return chooseDoctorChosen; }
            set { chooseDoctorChosen = value; NotifyPropertyChanged("ChooseDoctorChosen"); }
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
