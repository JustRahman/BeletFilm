using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Belet.Views;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Belet.Model;
using System.Collections.ObjectModel;
using Belet.Command;
using Belet.Helper;
using System.Windows.Navigation;
using DevExpress.Data.Browsing;
using System.Windows.Input;
using System.Diagnostics;
using MaterialDesignThemes.Wpf;
using System.Windows.Controls;
using System.IO;

namespace Belet.ViewModels
{



    

    

    class BeletFilmViewModel : ViewModelBase
    {
    public DelegateCommand toggleTheme { get; set; }

    public bool IsDarkTheme { get; set; }
    private readonly PaletteHelper paletteHelper = new PaletteHelper();
        
        
        bool wndstate = false;

        

        private Window _wnd;
        public Window wnd
        {
            get
            {
                return _wnd;
            }
            set
            {
                SetValue(ref _wnd, value);
            }

        }

        DataContext datacontext = new DataContext();

        private BeletFilmModel _filmModel;
        public BeletFilmModel filmModel
        {
            get
            {
                return _filmModel;
            }
            set
            {
                SetValue(ref _filmModel, value);
            }

        }


        private Button _LOB;
        public Button LOB
        {
            get
            {
                return _LOB;
            }
            set
            {
                SetValue(ref _LOB, value);
            }

        }
        public MyDelegateCommand InitializeCommand { get; set; }
        public MyDelegateCommand close_application { get; set; }
        public DelegateCommand myhabathyzmatlar { get; set; }
        public DelegateCommand ToWatchMedia { get; set; }
        public MyDelegateCommand sizechangebtn { get; set; }
        public MyDelegateCommand cmdLogin { get; set; }
        public DelegateCommand choosepageBack { get; set; }
        public MyDelegateCommand emailopen { get; set; }
        public MyDelegateCommand telegram { get; set; }
        public DelegateCommand goldawmerkezi { get; set; }
        public DelegateCommand maplocation { get; set; }
        public DelegateCommand appstore { get; set; } 
        public DelegateCommand androidtv { get; set; }

        public DelegateCommand FilmPage { get; set; }
        public DelegateCommand TelekomBelet { get; set; }
        public DelegateCommand ASTUBelet { get; set; }
        public DelegateCommand playmarket { get; set; }
        public DelegateCommand KarTazelik { get; set; }
        public DelegateCommand BizBarada { get; set; }

        public DelegateCommand turkmentelekom { get; set; }

        public DelegateCommand beletspeed { get; set; }
        public DelegateCommand confidbtn { get; set; }

        public DelegateCommand BeletAcc { get; set; }


        public DelegateCommand presentBtn { get; set; }
        public DelegateCommand LogOutBtn { get; set; }
        string path;

        public BeletFilmViewModel()
        {
            myhabathyzmatlar = new DelegateCommand(myhabathyzmatlar_cmd);
            toggleTheme = new DelegateCommand(toggleTheme_cmd);
            filmModel = new BeletFilmModel();
            InitializeCommand = new MyDelegateCommand(w => InitializeCommand_cmd(w));
            choosepageBack = new DelegateCommand(() => choosepageBack_cmd());
            FilmPage = new DelegateCommand(() => FilmPage_cmd());
            TelekomBelet = new DelegateCommand(() => TelekomBelet_cmd());
            ASTUBelet = new DelegateCommand(() => ASTUBelet_cmd());
            KarTazelik  = new DelegateCommand(() => KarTazelik_cmd());
             maplocation = new DelegateCommand(() => maplocation_cmd());
            goldawmerkezi = new DelegateCommand(() => goldawmerkezi_cmd());
            telegram = new MyDelegateCommand(e => telegram_cmd(e));
            emailopen = new MyDelegateCommand(f => emailopen_cmd(f));
            BizBarada = new DelegateCommand(() => BizBarada_cmd());
            playmarket = new DelegateCommand(playmarket_cmd);
            turkmentelekom = new DelegateCommand(() => turkmentelekom_cmd());
            beletspeed = new DelegateCommand(() => beletspeed_cmd());
            confidbtn = new DelegateCommand(() => confidbtn_cmd());
            close_application = new MyDelegateCommand(pep => close_application_cmd(pep));
            sizechangebtn = new MyDelegateCommand(klop => sizechangebtn_cmd(klop));
            cmdLogin = new MyDelegateCommand(zid => cmdLogin_cmd(zid));
            appstore = new DelegateCommand(appstore_cmd);
            androidtv = new DelegateCommand(androidtv_cmd);
            BeletAcc = new DelegateCommand(BeletAcc_cmd);
            ToWatchMedia = new DelegateCommand(ToWatchMedia_cmd);

            path = System.AppDomain.CurrentDomain.BaseDirectory + "config.json";
            LogOutBtn = new DelegateCommand(() => LogOutBtn_cmd());
            presentBtn = new DelegateCommand(() => presentBtn_cmd());

            filmModel.videomedia = System.AppDomain.CurrentDomain.BaseDirectory + @"Videos\large.mp4";

            filmModel.harrypotter = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\HarryPotter.jpg";
            filmModel.logo   = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\BeletLogo.png";
            filmModel.IsBigOrNormal = "Big Mode";
            filmModel.anime = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\Anime.jpg";
            filmModel.hunterghost = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\Ghost hunters.jpg";
            filmModel.mandalor = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\Mandolor.jpg";
            filmModel.telefon = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\Telefon.jpg";
            filmModel.tablet = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\Tablet.jpg";
            filmModel.laptop = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\TV.jpg";
            filmModel.tuner = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\Tuner.jpg"; 
            filmModel.brush1 = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\Utopia.jpg";  
            filmModel.brush2 = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\SuperFamily.jpg";  
            filmModel.brush3 = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\StarWar2.jpg";  
            filmModel.brush4 = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\MonstrHoliday.jpg";  
            filmModel.brush5 = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\Anime2.jpg";  
            filmModel.geometry1 = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\Enermouse.jpg"; 
            filmModel.geometry2 = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\Marvel.jpg"; 
            filmModel.geometry3 = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\T34.jpg";  
            filmModel.geometry4 = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\Galaxy Guide.jpg";

            IsDarkTheme = StaticsForTheme.IsBtnChecked;
        }
        private void LogOutBtn_cmd()
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                LOB.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Entered as ghost");
            }
        }
        private void presentBtn_cmd()
        {
            Process.Start("https://film.belet.me/cerificate");
        }
        private void ToWatchMedia_cmd()
        {
            Views.MainFilmPage previousMainFilmPage = new Views.MainFilmPage();
            wnd.Close();
            previousMainFilmPage.ShowDialog();
        }

        private void BeletAcc_cmd()
        {
            Process.Start("https://belet.com.tm/contacts");
        }
        private void myhabathyzmatlar_cmd()
        {
            Process.Start("https://belet.com.tm/business");
        }
        private void androidtv_cmd()
        {
            Process.Start("https://belet.com.tm/assets/apk/beletfilm_tv_2.2.apk");
        }

        private void appstore_cmd()
        {
            Process.Start("https://apps.apple.com/us/app/belet-film/id1551618663");
        }

        private void playmarket_cmd()
        {
            Process.Start("https://play.google.com/store/apps/details?id=tm.belet.films&hl=ru&gl=US");
        }

        private void toggleTheme_cmd()
        {
            ITheme theme = paletteHelper.GetTheme();

            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);

                StaticsForTheme.IsBtnChecked = IsDarkTheme;
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
                StaticsForTheme.IsBtnChecked = IsDarkTheme;

            }
            paletteHelper.SetTheme(theme);
        }
        private void confidbtn_cmd()
        {
            Process.Start("https://belet.com.tm/legal/privacy");
        }

        private void beletspeed_cmd()
        {
            Process.Start("https://speed.belet.com.tm/");
        }

        private void turkmentelekom_cmd()
        {
            Process.Start("https://telecom.tm/ru/");
        }

        private void emailopen_cmd(object f)
        {
            Process.Start("mailto:info@belet.me");
        }

        private void telegram_cmd(object e)
        {
             Process.Start("https://t.me/belet_video_forum");
        }

        private void goldawmerkezi_cmd()
        {
             Process.Start("https://help.belet.com.tm/");
        }

        private void maplocation_cmd()
        {
             Process.Start("https://www.google.ru/maps/place/37%C2%B057'40.7%22N+58%C2%B024'56.9%22E/@37.9610511,58.4154673,355m/data=!3m1!1e3!4m6!3m5!1s0x0:0x0!7e2!8m2!3d37.9613103!4d58.4157966");
        }

        private void callbtn_cmd(object o)
        { 
             Process.Start("https://belet.com.tm/tel:+993-12-75-02-08");
        }

        private void cmdLogin_cmd(object zid)
        {
            wnd.WindowState = WindowState.Minimized; 
        }
         

        private void sizechangebtn_cmd(object klop)
        {
            if (wndstate == false)
            {
                wnd.WindowState = WindowState.Maximized;
                wndstate = true;
                filmModel.IsBigOrNormal = "Normal Mode";
            }
            else
            {
                wnd.WindowState = WindowState.Normal;
                wndstate = false;
                filmModel.IsBigOrNormal = "Big Mode";

            }

        }

        private void close_application_cmd(object pep)
        {
            wnd.Close();
        }

        private void KarTazelik_cmd()
        {
            Views.TazelikBelet tazelikBelet = new Views.TazelikBelet();
            wnd.Close();
            tazelikBelet.ShowDialog();
        }

        private void BizBarada_cmd()
        {
            Views.BeletBarada beletBarada = new Views.BeletBarada();
            wnd.Close();
            beletBarada.ShowDialog();
        }

        private void ASTUBelet_cmd()
        {
            Views.ASTUBelet aSTUBelet = new Views.ASTUBelet();
            wnd.Close();
            aSTUBelet.ShowDialog();
        }

        private void TelekomBelet_cmd()
        {
            Views.TelekomBelet telekomBelet = new Views.TelekomBelet();
            wnd.Close();
            telekomBelet.ShowDialog();
        }

        private void FilmPage_cmd()
        {
            Views.MainFilmPage filmPage = new Views.MainFilmPage();
            wnd.Close();
            filmPage.ShowDialog();
        }

        private void choosepageBack_cmd()
        {
            Views.ChoosePage choosePage = new Views.ChoosePage();
            wnd.Close();
            choosePage.ShowDialog();
        }




        private void InitializeCommand_cmd(object o)
        {
            object[] wind = o as object[];
            wnd = (Window)wind[0];
            LOB = (Button)wind[1];


            //  wnd.Close();
            //   throw new NotImplementedException();
        }


    }
}
