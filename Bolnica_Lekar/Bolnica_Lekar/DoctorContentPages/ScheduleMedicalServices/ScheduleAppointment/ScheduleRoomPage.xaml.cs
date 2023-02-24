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
using static Bolnica_Lekar.DoctorContentPages.ScheduleMedicalServices.ScheduleAppointment.ScheduleDatePage;

namespace Bolnica_Lekar.DoctorContentPages.ScheduleMedicalServices.ScheduleAppointment
{
    /// <summary>
    /// Interaction logic for ScheduleRoomPage.xaml
    /// </summary>
    public partial class ScheduleRoomPage : Page
    {
        private HomepageDoctor homepageDoctor = null;
        private BackWindowType backWindowType;
        public ScheduleRoomPage(HomepageDoctor hd, BackWindowType bwt)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.DataContext = this;
            this.backWindowType = bwt;
        }

        #region LoadRoomsData
        private ObservableCollection<RoomClass> LoadRoomsData()
        {
            ObservableCollection<RoomClass> roomsData = new ObservableCollection<RoomClass>();
            roomsData.Add(new RoomClass { RoomId = 1, RoomName = "Soba 1", RoomChosen = false });
            roomsData.Add(new RoomClass { RoomId = 2, RoomName = "Soba 2", RoomChosen = false });
            roomsData.Add(new RoomClass { RoomId = 3, RoomName = "Soba 3", RoomChosen = false });
            roomsData.Add(new RoomClass { RoomId = 4, RoomName = "Soba 4", RoomChosen = false });
            roomsData.Add(new RoomClass { RoomId = 5, RoomName = "Soba 5", RoomChosen = false });
            roomsData.Add(new RoomClass { RoomId = 6, RoomName = "Soba 6", RoomChosen = false });
            roomsData.Add(new RoomClass { RoomId = 7, RoomName = "Soba 7", RoomChosen = false });
            return roomsData;
        }
        #endregion

        #region PageLoaded
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridAvailableRooms.ItemsSource = LoadRoomsData();
        }
        #endregion

        #region DataGridAvailableRoomsPreviewKeyDownEnter
        private void DataGridAvailableRooms_PreviewKeyDown(object sender, KeyEventArgs e)
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
                RoomClass item = dg.ItemContainerGenerator.ItemFromContainer(row) as RoomClass;

                item.RoomChosen = true;
            }
        }
        #endregion

        #region ContinueToConfirmationOfAppointment
        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showPatientProfilePage();
        }
        #endregion

        #region BackToScheduleDate
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showScheduleDatePage(this.backWindowType);
        }
        #endregion
    }

    public class RoomClass : INotifyPropertyChanged
    {
        private bool roomChosen;
        public long RoomId { get; set; }
        public string RoomName { get; set; }

        #region RoomChosenProperty
        public bool RoomChosen
        {
            get { return roomChosen; }
            set { roomChosen = value; NotifyPropertyChanged("RoomChosen"); }
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
