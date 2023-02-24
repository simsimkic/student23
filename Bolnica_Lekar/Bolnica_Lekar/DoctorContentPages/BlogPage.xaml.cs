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
    /// Interaction logic for BlogPage.xaml
    /// </summary>
    public partial class BlogPage : Page
    {
        private HomepageDoctor homepageDoctor = null;
        public BlogPage(HomepageDoctor hd)
        {
            InitializeComponent();
            this.homepageDoctor = hd;
            this.DataContext = this;
        }

        #region LoadCategoryTypeData
        private ObservableCollection<CategoryTypeClass> LoadCategoryTypeData()
        {
            ObservableCollection<CategoryTypeClass> categoryTypeData = new ObservableCollection<CategoryTypeClass>();
            categoryTypeData.Add(new CategoryTypeClass { CategoryTypeId = 1, CategoryTypeName = "Kategorija 1", CategoryTypeChosen = false });
            categoryTypeData.Add(new CategoryTypeClass { CategoryTypeId = 2, CategoryTypeName = "Kategorija 2", CategoryTypeChosen = false });
            categoryTypeData.Add(new CategoryTypeClass { CategoryTypeId = 3, CategoryTypeName = "Kategorija 3", CategoryTypeChosen = false });
            categoryTypeData.Add(new CategoryTypeClass { CategoryTypeId = 4, CategoryTypeName = "Kategorija 4", CategoryTypeChosen = false });
            categoryTypeData.Add(new CategoryTypeClass { CategoryTypeId = 5, CategoryTypeName = "Kategorija 5", CategoryTypeChosen = false });

            return categoryTypeData;
        }
        #endregion

        #region PageLoaded
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            FirstItemInBlogTab.Focus();
            ArticlesList.SelectedItem = ArticlesList.Items.GetItemAt(0);
            DataGridCategoryType.ItemsSource = LoadCategoryTypeData();
        }
        #endregion

        #region ArticleListEnter
        private void ArticlesList_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var uiElement = e.OriginalSource as UIElement;
            if (e.Key == Key.Enter && uiElement != null)
            {
                e.Handled = true;
                //Console.WriteLine(uiElement.ToString());
                this.homepageDoctor.showArticlePage();
            }
        }
        #endregion

        #region CategoryTypeGridEnter
        private void DataGridCategoryType_PreviewKeyDown(object sender, KeyEventArgs e)
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
                CategoryTypeClass item = dg.ItemContainerGenerator.ItemFromContainer(row) as CategoryTypeClass;

                item.CategoryTypeChosen = true;
            }
        }
        #endregion

        #region PostArticle
        private void PostArticleButton_Click(object sender, RoutedEventArgs e)
        {
            this.homepageDoctor.showBlogPage();
        }
        #endregion
    }

    public class CategoryTypeClass : INotifyPropertyChanged
    {
        private bool categoryTypeChosen;
        public long CategoryTypeId { get; set; }
        public string CategoryTypeName { get; set; }

        #region CategoryTypeChoosenProperty
        public bool CategoryTypeChosen
        {
            get { return categoryTypeChosen; }
            set { categoryTypeChosen = value; NotifyPropertyChanged("CategoryTypeChosen"); }
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
