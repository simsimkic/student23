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
    /// Interaction logic for ListOfPatientsPage.xaml
    /// </summary>
    public partial class ListOfPatientsPage : Page, INotifyPropertyChanged
    {
        private HomepageDoctor homepageDoctor = null;
        private ICollectionView _dataGridCollection;
        private string _filterJMBG;
        private string _filterName;
        private int lastChanged = 0;
        public ListOfPatientsPage(HomepageDoctor hd)
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

        public string FilterJMBG
        {
            get { return _filterJMBG; }
            set
            {
                _filterJMBG = value;
                lastChanged = 1;
                NotifyPropertyChanged("FilterJMBG");
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
            var data = obj as TestClass;
            if (data != null)
            {
                switch (lastChanged)
                {
                    case 1:
                        if (!string.IsNullOrEmpty(_filterJMBG))
                        {
                            return data.JMBG.StartsWith(_filterJMBG);
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

        public IEnumerable<TestClass> TestData
        {
            get
            {
                yield return new TestClass { JMBG = "1507996549823", Name = "aNeki Pacijent1" };
                yield return new TestClass { JMBG = "2507996549823", Name = "bNeki Pacijent2" };
                yield return new TestClass { JMBG = "3507996549823", Name = "cNeki Pacijent3" };
                yield return new TestClass { JMBG = "4507996549823", Name = "dNeki Pacijent4" };
                yield return new TestClass { JMBG = "5507996549823", Name = "eNeki Pacijent5" };
                yield return new TestClass { JMBG = "6507996549823", Name = "fNeki Pacijent6" };
                yield return new TestClass { JMBG = "7507996549823", Name = "gNeki Pacijent7" };
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
                this.homepageDoctor.showPatientProfilePage();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            JMBGSearchBox.Focus();
        }
    }

    public class TestClass
    {
        public string JMBG { get; set; }
        public string Name { get; set; }
    }
}
