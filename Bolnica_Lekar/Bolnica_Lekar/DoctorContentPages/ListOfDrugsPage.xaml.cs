using System;
using System.Collections.Generic;
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
    /// Interaction logic for DrugsPage.xaml
    /// </summary>
    public partial class ListOfDrugsPage : Page, INotifyPropertyChanged
    {
        private HomepageDoctor homepageDoctor = null;
        private ICollectionView _dataGridCollection;
        private string _filterID;
        private string _filterName;
        private int lastChanged = 0;
        public ListOfDrugsPage(HomepageDoctor hd)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.DataContext = this;
            DataGridCollection = CollectionViewSource.GetDefaultView(TestData);
            DataGridCollection.Filter = new Predicate<object>(Filter);
        }

        public ICollectionView DataGridCollection
        {
            get { return _dataGridCollection; }
            set { _dataGridCollection = value; NotifyPropertyChanged("DataGridCollection"); }
        }

        public string FilterID
        {
            get { return _filterID; }
            set
            {
                _filterID = value;
                lastChanged = 1;
                NotifyPropertyChanged("FilterID");
                FilterCollection();
            }
        }

        public string FilterName
        {
            get { return _filterName; }
            set
            {
                _filterName = value;
                lastChanged = 2;
                NotifyPropertyChanged("FilterName");
                FilterCollection();
            }
        }

        private void FilterCollection()
        {
            if (_dataGridCollection != null)
            {
                _dataGridCollection.Refresh();
            }
        }

        public bool Filter(object obj)
        {
            var data = obj as TestClassDrug;
            if (data != null)
            {
                switch (lastChanged)
                {
                    case 1:
                        if (!string.IsNullOrEmpty(_filterID))
                        {
                            return data.ID.StartsWith(_filterID);
                        }
                        break;
                    case 2:
                        if (!string.IsNullOrEmpty(_filterName))
                        {
                            return data.Name.StartsWith(_filterName);
                        }
                        break;
                }
                return true;
            }
            return false;
        }

        public IEnumerable<TestClassDrug> TestData
        {
            get
            {
                yield return new TestClassDrug { ID = "1", Name = "Lek1" };
                yield return new TestClassDrug { ID = "2", Name = "Lek2" };
                yield return new TestClassDrug { ID = "3", Name = "Lek3" };
                yield return new TestClassDrug { ID = "4", Name = "Lek4" };
                yield return new TestClassDrug { ID = "5", Name = "Lek5" };
                yield return new TestClassDrug { ID = "6", Name = "Lek6" };
                yield return new TestClassDrug { ID = "7", Name = "Lek7" };
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


        private void DataGrid_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            var uiElement = e.OriginalSource as UIElement;
            if (e.Key == Key.Enter && uiElement != null)
            {
                e.Handled = true;
                //Console.WriteLine(uiElement.ToString());
                //TODO: Dodati otvaranje novog prozora za odobravanje leka
                Console.WriteLine("Enter pressed in the section for the approval of the drugs");
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            IDSearchBox.Focus();
        }
    }

    public class TestClassDrug
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
}
