using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Belet.Model;
using Belet.Views;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using Belet.Command;
using Belet.Helper;
using MaterialDesignThemes.Wpf;
using System.Diagnostics;
using System.Windows.Controls;
using System.IO;

namespace Belet.ViewModels
{



    class TVBeletViewModel : ViewModelBase
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

        private TVBeletModel _tvbelet;
        public TVBeletModel tvbelet
        {
            get
            {
                return _tvbelet;
            }
            set
            {
                SetValue(ref _tvbelet, value);
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

        public MyDelegateCommand cmdLogin { get; set; }
        public DelegateCommand myhabathyzmatlar { get; set; }
        public MyDelegateCommand sizechangebtn { get; set; }
        public DelegateCommand choosepageBack { get; set; }
        public DelegateCommand FilmFrame { get; set; }
        public DelegateCommand VideoFrame { get; set; }
        public DelegateCommand agtshop { get; set; }

        public DelegateCommand BeletAcc { get; set; }
        public DelegateCommand KarTazelik { get; set; }

        public MyDelegateCommand emailopen { get; set; }
        public MyDelegateCommand telegram { get; set; }
        public DelegateCommand goldawmerkezi { get; set; }
        public DelegateCommand maplocation { get; set; }


        public DelegateCommand BizBarada { get; set; }

        public DelegateCommand turkmentelekom { get; set; }

        public DelegateCommand beletspeed { get; set; }
        public DelegateCommand confidbtn { get; set; }

        public DelegateCommand presentBtn { get; set; }
        public DelegateCommand LogOutBtn { get; set; }
        string path;


        public TVBeletViewModel()
        {
            path = System.AppDomain.CurrentDomain.BaseDirectory + "config.json";
            LogOutBtn = new DelegateCommand(() => LogOutBtn_cmd());
            presentBtn = new DelegateCommand(() => presentBtn_cmd());
            tvbelet = new TVBeletModel();
            InitializeCommand = new MyDelegateCommand(w => InitializeCommand_cmd(w));
            choosepageBack = new DelegateCommand(() => choosepageBack_cmd());

            close_application = new MyDelegateCommand(pep => close_application_cmd(pep));
            sizechangebtn = new MyDelegateCommand(klop => sizechangebtn_cmd(klop));
            cmdLogin = new MyDelegateCommand(zid => cmdLogin_cmd(zid));
            FilmFrame = new DelegateCommand(FilmFrame_cmd);
            VideoFrame = new DelegateCommand(VideoFrame_cmd);
            agtshop = new DelegateCommand(agtshop_cmd);
            myhabathyzmatlar = new DelegateCommand(myhabathyzmatlar_cmd);

            KarTazelik = new DelegateCommand(() => KarTazelik_cmd());
            BeletAcc = new DelegateCommand(BeletAcc_cmd);
            maplocation = new DelegateCommand(() => maplocation_cmd());
            goldawmerkezi = new DelegateCommand(() => goldawmerkezi_cmd());
            telegram = new MyDelegateCommand(e => telegram_cmd(e));
            emailopen = new MyDelegateCommand(f => emailopen_cmd(f));
            BizBarada = new DelegateCommand(() => BizBarada_cmd());
            turkmentelekom = new DelegateCommand(() => turkmentelekom_cmd());
            beletspeed = new DelegateCommand(() => beletspeed_cmd());
            confidbtn = new DelegateCommand(() => confidbtn_cmd());
            tvbelet.dunytv = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\BeletDuny.png";
            tvbelet.tvtuner = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\BeletTV.jpg";
            tvbelet.marvelwar = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\Marvel.png"; 
            tvbelet.supeerfamily = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\SuperFamily.png"; 
            tvbelet.mandalor = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\StarWar.png";
            tvbelet.tvtunertuner = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\BeletIpTuner2.jpg";
            tvbelet.geometry1 = System.AppDomain.CurrentDomain.BaseDirectory + @"Images\BeletLogo.png";

            toggleTheme = new DelegateCommand(toggleTheme_cmd);

            tvbelet.IsBigOrNormal = "Bid Mode";
            tvbelet.brush1 = "Black";
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
        private void myhabathyzmatlar_cmd()
        {
            Process.Start("https://belet.com.tm/business");
        }
        private void agtshop_cmd()
        {
            Process.Start("https://agts.tv/");
        }

        private void BeletAcc_cmd()
        {
            Process.Start("https://belet.com.tm/contacts");
        }

        private void KarTazelik_cmd()
        {
            Views.TazelikBelet tazelikBelet = new Views.TazelikBelet();
            wnd.Close();
            tazelikBelet.ShowDialog();
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

        private void BizBarada_cmd()
        {
            Views.BeletBarada beletBarada = new Views.BeletBarada();
            wnd.Close();
            beletBarada.ShowDialog();
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



        private void VideoFrame_cmd()
        {
            Views.VideoBelet videoBelet = new Views.VideoBelet();
            wnd.Close();
            videoBelet.ShowDialog();
        }

        private void FilmFrame_cmd()
        {
            Views.BeletFilm beletFilm = new Views.BeletFilm();
            wnd.Close();
            beletFilm.ShowDialog();
        }

        private void choosepageBack_cmd()
        {
            Views.ChoosePage belet = new Views.ChoosePage();
            wnd.Close();
            belet.ShowDialog();
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
                tvbelet.IsBigOrNormal = "Normal Mode";
            }
            else
            {
                wnd.WindowState = WindowState.Normal;
                wndstate = false;
                tvbelet.IsBigOrNormal = "Bid Mode";

            }

        }

        private void close_application_cmd(object pep)
        {
            wnd.Close();
        }

        private void toggleTheme_cmd()
        {
            ITheme theme = paletteHelper.GetTheme();

            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
                tvbelet.brush1 = "Black";
                StaticsForTheme.IsBtnChecked = IsDarkTheme;
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
                tvbelet.brush1 = "White";
                StaticsForTheme.IsBtnChecked = IsDarkTheme;
            }
            paletteHelper.SetTheme(theme);
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
