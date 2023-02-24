using Bolnica_Lekar.DoctorContentPages;
using Bolnica_Lekar.DoctorContentPages.MyProfilePageContent;
using Bolnica_Lekar.DoctorContentPages.ScheduleMedicalServices;
using Bolnica_Lekar.DoctorContentPages.ScheduleMedicalServices.ScheduleAppointment;
using Bolnica_Lekar.DoctorContentPages.ScheduleMedicalServices.ScheduleOperation;
using System;
using System.Collections.Generic;
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
using static Bolnica_Lekar.DoctorContentPages.ScheduleMedicalServices.ScheduleAppointment.ScheduleDatePage;

namespace Bolnica_Lekar
{
    /// <summary>
    /// Interaction logic for HomepageDoctor.xaml
    /// </summary>
    public partial class HomepageDoctor : Window
    {
        private ICommand logOutCommand;
        private ICommand doctorSchedulePageCommand;
        private ICommand listOfPatientsPageCommand;
        private ICommand myProfilePageCommand;
        private ICommand listOfDrugsPageCommand;
        private ICommand blogPageCommand;

        private DoctorSchedulePage doctorSchedulePage = null;
        private ListOfPatientsPage listOfPatientsPage = null;
        private MyProfilePage myProfilePage = null;
        private PatientProfilePage patientProfilePage = null;
        private ListOfDrugsPage listOfDrugsPage = null;
        private ChangeDataMyProfilePage changeDataMyProfilePage = null;
        private PatientMedicalRecordPage patientMedicalRecordPage = null;
        private FinishAppointmentConfirmationPage finishAppointmentConfirmationPage = null;
        private AddPrescriptionPage addPrescriptionPage = null;
        private ScheduleAppointmentPage scheduleAppointmentPage = null;
        private ScheduleDatePage scheduleDatePage = null;
        private ScheduleRoomPage scheduleRoomPage = null;
        private ChooseDoctorPage chooseDoctorPage = null;
        private BlogPage blogPage = null;
        private ArticlePage articlePage = null;
        private ScheduleOperationTypePage scheduleOperationTypePage = null;

        public HomepageDoctor()
        {
            InitializeComponent();
            this.DataContext = this;
            this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
        }

        private void HandleEsc(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Close();
        }

        public ICommand LogOutCommand
        {
            get
            {
                return logOutCommand
                    ?? (logOutCommand = new ActionCommand(() =>
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.Close();
                    }));
            }
        }

        public ICommand DoctorSchedulePageCommand
        {
            get
            {
                return doctorSchedulePageCommand
                    ?? (doctorSchedulePageCommand = new ActionCommand(() =>
                    {
                        this.showDoctorSchedulePage();
                    }));
            }
        }

        public ICommand ListOfPatientsPageCommand
        {
            get
            {
                return listOfPatientsPageCommand
                    ?? (listOfPatientsPageCommand = new ActionCommand(() =>
                    {
                        this.showListOfPatientsPage();
                    }));
            }
        }

        public ICommand MyProfilePageCommand
        {
            get
            {
                return myProfilePageCommand
                    ?? (myProfilePageCommand = new ActionCommand(() =>
                    {
                        this.showMyProfilePage();
                    }));
            }
        }

        public ICommand ListOfDrugsPageCommand
        {
            get
            {
                return listOfDrugsPageCommand
                    ?? (listOfDrugsPageCommand = new ActionCommand(() =>
                    {
                        this.showListOfDrugsPage();
                    }));
            }
        }

        public ICommand BlogPageCommand
        {
            get
            {
                return blogPageCommand
                    ?? (blogPageCommand = new ActionCommand(() =>
                    {
                        this.showBlogPage();
                    }));
            }
        }

        public void showDoctorSchedulePage()
        {
            if (doctorSchedulePage == null)
            {
                PageContent.Content = new DoctorSchedulePage(this);
            }
            else
            {
                PageContent.Content = doctorSchedulePage;
            }
        }

        public void showListOfPatientsPage()
        {
            if (listOfPatientsPage == null)
            {
                PageContent.Content = new ListOfPatientsPage(this);
            }
            else
            {
                PageContent.Content = listOfPatientsPage;
            }
        }

        public void showMyProfilePage()
        {
            if (myProfilePage == null)
            {
                PageContent.Content = new MyProfilePage(this);
            }
            else
            {
                PageContent.Content = myProfilePage;
            }
        }

        public void showPatientProfilePage()
        {
            if (patientProfilePage == null)
            {
                PageContent.Content = new PatientProfilePage(this);
            }
            else
            {
                PageContent.Content = patientProfilePage;
            }
        }

        public void showListOfDrugsPage()
        {
            if (listOfDrugsPage == null)
            {
                PageContent.Content = new ListOfDrugsPage(this);
            }
            else
            {
                PageContent.Content = listOfDrugsPage;
            }
        }

        public void showChangedDataMyProfilePage()
        {
            if (changeDataMyProfilePage == null)
            {
                PageContent.Content = new ChangeDataMyProfilePage(this, this.myProfilePage);
            }
            else
            {
                PageContent.Content = changeDataMyProfilePage;
            }
        }

        public void showPatientMedicalRecordPage(bool isAppointment)
        {
            if (patientMedicalRecordPage == null)
            {
                PatientMedicalRecordPage patientMedicalRecordPageVar = new PatientMedicalRecordPage(this);
                (patientMedicalRecordPageVar as PatientMedicalRecordPage).IsAppointment = isAppointment;
                PageContent.Content = patientMedicalRecordPageVar;
            }
            else
            {
                //TODO Ovi elsovi i nisu toliko bitni zapravo
                PageContent.Content = patientMedicalRecordPage;
                patientMedicalRecordPage.IsAppointment = isAppointment;
            }
        }

        public void showFinishedAppointmentConfirmationPage()
        {
            if (finishAppointmentConfirmationPage == null)
            {
                PageContent.Content = new FinishAppointmentConfirmationPage(this);
            }
            else
            {
                PageContent.Content = finishAppointmentConfirmationPage;
            }
        }

        public void showAddPrescriptionPage()
        {
            if (addPrescriptionPage == null)
            {
                PageContent.Content = new AddPrescriptionPage(this);
            }
            else
            {
                PageContent.Content = addPrescriptionPage;
            }
        }

        public void showScheduleAppointmentPage()
        {
            if (scheduleAppointmentPage == null)
            {
                PageContent.Content = new ScheduleAppointmentPage(this);
            }
            else
            {
                PageContent.Content = scheduleAppointmentPage;
            }
        }

        public void showScheduleDatePage(BackWindowType bwt)
        {
            if (scheduleDatePage == null)
            {
                PageContent.Content = new ScheduleDatePage(this, bwt);
            }
            else
            {
                PageContent.Content = scheduleDatePage;
            }
        }

        public void showScheduleRoomPage(BackWindowType bwt)
        {
            if (scheduleRoomPage == null)
            {
                PageContent.Content = new ScheduleRoomPage(this, bwt);
            }
            else
            {
                PageContent.Content = scheduleRoomPage;
            }
        }

        public void showChooseDoctorPage()
        {
            if (chooseDoctorPage == null)
            {
                PageContent.Content = new ChooseDoctorPage(this);
            }
            else
            {
                PageContent.Content = chooseDoctorPage;
            }
        }

        public void showBlogPage()
        {
            if (blogPage == null)
            {
                PageContent.Content = new BlogPage(this);
            }
            else
            {
                PageContent.Content = blogPage;
            }
        }

        public void showArticlePage()
        {
            if (articlePage == null)
            {
                PageContent.Content = new ArticlePage(this);
            }
            else
            {
                PageContent.Content = articlePage;
            }
        }

        public void showOperationTypePage()
        {
            if (scheduleOperationTypePage == null)
            {
                PageContent.Content = new ScheduleOperationTypePage(this);
            }
            else
            {
                PageContent.Content = scheduleOperationTypePage;
            }
        }

        public PatientMedicalRecordPage PatientMedicalRecordPage
        {
            get
            {
                return patientMedicalRecordPage;
            }

            set
            {
                patientMedicalRecordPage = value;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.showDoctorSchedulePage();
        }

        /*public void LogoutShortcut(object sender, ExecutedRoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }*/
    }
}
