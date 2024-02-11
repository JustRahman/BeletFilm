using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Belet.Views;
using Belet.Model;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Belet.Model.Media;
using System.Collections.ObjectModel;
using Belet.Command;
using Belet.Helper;
using MaterialDesignThemes.Wpf;
using System.Diagnostics;
using System.Windows.Controls;
using Newtonsoft.Json;
using System.Globalization;
using DevExpress.Xpo;
using System.Threading;
using Belet.Model.Reactions;
using System.IO;
using System.Media;
using System.Net.Http;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Data;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Npgsql;

namespace Belet.ViewModels
{
    class MainFilmPage : ViewModelBase
    {
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

         

        private ObservableCollection<MediaDatum> _necessaryMedias;
        public ObservableCollection<MediaDatum> necessaryMedias
        {
            get
            {
                return _necessaryMedias;
            }
            set
            {
                SetValue(ref _necessaryMedias, value);
            }
        }

        ObservableCollection<ObservableCollection<MainChoosePageModel>> _mainChoosePageModels;
        ObservableCollection<ObservableCollection<MainChoosePageModel>> mainChoosePageModels
        {
            get
            {
                return _mainChoosePageModels;
            }
            set
            {
                SetValue(ref _mainChoosePageModels, value);
            }
        }



        ObservableCollection<MainChoosePageModel> _mainChoosePageModel;
        ObservableCollection<MainChoosePageModel> mainChoosePageModel
        {
            get
            {
                return _mainChoosePageModel;
            }
            set
            {
                SetValue(ref _mainChoosePageModel, value);
            }
        }

        private List<string> _imageursls;
        public List<string> imageursls
        {
            get
            {
                return _imageursls;
            }
            set
            {
                SetValue(ref _imageursls, value);
            }
        }

        private List<string> _imageursls2;
        public List<string> imageursls2
        {
            get
            {
                return _imageursls2;
            }
            set
            {
                SetValue(ref _imageursls2, value);
            }
        }

        private List<string> _imageursls3;
        public List<string> imageursls3
        {
            get
            {
                return _imageursls3;
            }
            set
            {
                SetValue(ref _imageursls3, value);
            }
        }

        private List<string> _imageursls4;
        public List<string> imageursls4
        {
            get
            {
                return _imageursls4;
            }
            set
            {
                SetValue(ref _imageursls4, value);
            }
        }

        private List<int> _MoveIdLike;
        public List<int> MoveIdLike
        {
            get
            {
                return _MoveIdLike;
            }
            set
            {
                SetValue(ref _MoveIdLike, value);
            }
        }

        private List<int> _MoveIdSave;
        public List<int> MoveIdSave
        {
            get
            {
                return _MoveIdSave;
            }
            set
            {
                SetValue(ref _MoveIdSave, value);
            }
        }

        private WrapPanel _LikeWrapanel;
        public WrapPanel LikeWrapanel
        {
            get
            {
                return _LikeWrapanel;
            }
            set
            {
                SetValue(ref _LikeWrapanel, value);
            }
        }

        private WrapPanel _NewAddedWrapanel;
        public WrapPanel NewAddedWrapanel
        {
            get
            {
                return _NewAddedWrapanel;
            }
            set
            {
                SetValue(ref _NewAddedWrapanel, value);
            }
        }

        private WrapPanel _NewWrapanel;
        public WrapPanel NewWrapanel
        {
            get
            {
                return _NewWrapanel;
            }
            set
            {
                SetValue(ref _NewWrapanel, value);
            }
        }

        private WrapPanel _SaveWrapanel;
        public WrapPanel SaveWrapanel
        {
            get
            {
                return _SaveWrapanel;
            }
            set
            {
                SetValue(ref _SaveWrapanel, value);
            }
        }

        private PreviousMediaModel _previousMediaModel;
        public PreviousMediaModel previousMediaModel
        {
            get
            {
                return _previousMediaModel;
            }
            set
            {
                SetValue(ref _previousMediaModel, value);
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

        public DelegateCommand goldawmerkezi { get; set; }
        public DelegateCommand LogOutBtn { get; set; }
        public DelegateCommand presentBtn { get; set; }
        public DelegateCommand cmdLogin { get; set; }
        public MyDelegateCommand InitializeCommand { get; set; }
        public DelegateCommand sizechangebtn { get; set; }

        static HttpClient httpClient;
        private readonly PaletteHelper paletteHelper = new PaletteHelper();
        
        bool checker = false;
        bool helper = true;
        bool wndstate = false; 
        int MaxYear = 0;
        int counter = 0;
        int counter1 = 0;

        int counter2 = 0;
        bool FirstScip = false;
        string imageurl = " ";
        string medianame = " ";
        string path;

        public MainFilmPage()
        {
            MoveIdSave = new List<int>();
            MoveIdLike = new List<int>();
            imageursls = new List<string>();
            imageursls2 = new List<string>();
            imageursls3 = new List<string>();
            imageursls4 = new List<string>();
            mainChoosePageModels = new ObservableCollection<ObservableCollection<MainChoosePageModel>>();

            ITheme theme = paletteHelper.GetTheme();
            theme.SetBaseTheme(Theme.Dark);
            paletteHelper.SetTheme(theme);

            path = System.AppDomain.CurrentDomain.BaseDirectory + "config.json";


            InitializeCommand = new MyDelegateCommand(w => InitializeCommand_cmd(w));
            sizechangebtn = new DelegateCommand(sizechangebtn_cmd);

            goldawmerkezi = new DelegateCommand(goldawmerkezi_cmd);
            LogOutBtn = new DelegateCommand(LogOutBtn_cmd);
            presentBtn = new DelegateCommand(goldawmerkezi_cmd);
            cmdLogin = new DelegateCommand(cmdLogin_cmd);

            previousMediaModel = new PreviousMediaModel();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:1337/api/");
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

        private void cmdLogin_cmd()
        {
            wnd.WindowState = WindowState.Minimized;
        }

        private void presentBtn_cmd()
        {
            Process.Start("https://film.belet.me/cerificate");
        }
        private void goldawmerkezi_cmd()
        {
            Process.Start("https://help.belet.com.tm/");
        }
        private void sizechangebtn_cmd()
        {
            if (wndstate == false)
            {
                wnd.WindowState = WindowState.Maximized;
                wndstate = true;
                previousMediaModel.IsBigOrNormal = "Normal Mode";
            }
            else
            {
                wnd.WindowState = WindowState.Normal;
                wndstate = false;
                previousMediaModel.IsBigOrNormal = "Big Mode";

            }
        }

        private async void InitializeCommand_cmd(object o)
        {
            object[] wind = o as object[];
            wnd = (Window)wind[0];
            LikeWrapanel = (WrapPanel)wind[1];
            SaveWrapanel = (WrapPanel)wind[2];
            NewWrapanel = (WrapPanel)wind[3];
            NewAddedWrapanel = (WrapPanel)wind[4];
            LOB = (Button)wind[5];
            FirstScip = true;

            HttpResponseMessage response1 = await httpClient.GetAsync($"user-reactions?filters[user_id][$eq]=0");
            string str1 = response1.Content.ReadAsStringAsync().Result;
            Reaction mediaReaction = JsonConvert.DeserializeObject<Reaction>(str1);

                //if (mediaReaction.Meta.Pagination.PageCount != 0)
                //{
                //    foreach (DatumReactions datumReaction in mediaReaction.Data)
                //    {
                //        if (datumReaction.Attributes.ReactionTypeId.Contains("1"))
                //        {
                //            if (datumReaction.Attributes.ReactionTypeId == "1")
                //            {
                //                MoveIdLike.Add(Convert.ToInt32(datumReaction.Attributes.MoveId));
                //            }
                //            else if (datumReaction.Attributes.ReactionTypeId == "01")
                //            {
                //                continue;
                //            }

                //        }

                //        if (datumReaction.Attributes.ReactionTypeId.Contains("2"))
                //        {
                //            if (datumReaction.Attributes.ReactionTypeId == "2")
                //            {
                //                MoveIdSave.Add(Convert.ToInt32(datumReaction.Attributes.MoveId));
                //            }
                //            else if (datumReaction.Attributes.ReactionTypeId == "02")
                //            {
                //                continue;
                //            }

                //        }
                //    }
                //}

            #region
            HttpResponseMessage response2 = await httpClient.GetAsync("company-infos?populate=*");
            string str2 = response2.Content.ReadAsStringAsync().Result;
            Media mediaObject = JsonConvert.DeserializeObject<Media>(str2);
            necessaryMedias = new ObservableCollection<MediaDatum>();

            string[] itemsplit2 = mediaObject.Data[0].Attributes.MediaName.Split(' ');

            previousMediaModel.brush1 =AppDomain.CurrentDomain.BaseDirectory +  mediaObject.Data[0].Attributes.MediaPicture2;
            previousMediaModel.brush2 = itemsplit2[0];
            foreach (MediaDatum item in mediaObject.Data)
            {
                if (MoveIdLike.Contains(Convert.ToInt32(item.Id)))
                {
                    mainChoosePageModel = new ObservableCollection<MainChoosePageModel>();

                    foreach (ObservableCollection<MainChoosePageModel> item1 in mainChoosePageModels)
                    {
                        helper = true;
                        string[] itemsplit = item.Attributes.MediaName.Split(' ');
                        MainChoosePageModel mainChoose = new MainChoosePageModel();


                        for (int i = 0; i < itemsplit.Length; i++)
                        {
                            if (i == itemsplit.Length - 1)
                            {
                                mainChoose.txtforbtninfo += itemsplit[i];

                            }
                            else
                            {
                                mainChoose.txtforbtninfo += itemsplit[i] + " ";

                            }

                        }

                        foreach (MainChoosePageModel item3 in item1)
                        {
                            if (item3.txtforbtninfo == mainChoose.txtforbtninfo)
                            {
                                helper = false;
                                continue;
                            }
                        }


                    }
                    if (helper == true)
                    {

                        string[] itemsplit = item.Attributes.MediaName.Split(' ');
                        helper = true;



                        Button button = new Button();
                        Image image = new Image();



                        image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + item.Attributes.MediaPicture1, UriKind.Absolute));

                        checker = true;

                        foreach (string item3 in imageursls)
                        {
                            if (item3 == item.Attributes.MediaPicture1)
                                checker = false;


                        }


                        if (checker == true)
                        {
                            button.Width = 130;
                            button.Height = 180;
                            button.Name = itemsplit[0];
                            button.Background = new SolidColorBrush(Colors.Transparent);
                            button.Margin = new Thickness(0, 0, 1, 0);
                            button.BorderThickness = new Thickness(0);
                            button.Content = image;

                            button.Click += Button_Click;
                            imageursls.Add(item.Attributes.MediaPicture1);

                            LikeWrapanel.Children.Add(button);




                        }
                        checker = true;

                    }
                }
                if (MoveIdSave.Contains(Convert.ToInt32(item.Id)))
                {
                    mainChoosePageModel = new ObservableCollection<MainChoosePageModel>();

                    foreach (ObservableCollection<MainChoosePageModel> item1 in mainChoosePageModels)
                    {
                        helper = true;
                        string[] itemsplit = item.Attributes.MediaName.Split(' ');
                        MainChoosePageModel mainChoose = new MainChoosePageModel();


                        for (int i = 0; i < itemsplit.Length; i++)
                        {
                            if (i == itemsplit.Length - 1)
                            {
                                mainChoose.txtforbtninfo += itemsplit[i];

                            }
                            else
                            {
                                mainChoose.txtforbtninfo += itemsplit[i] + " ";

                            }

                        }

                        foreach (MainChoosePageModel item3 in item1)
                        {
                            if (item3.txtforbtninfo == mainChoose.txtforbtninfo)
                            {
                                helper = false;
                                continue;
                            }
                        }


                    }
                    if (helper == true)
                    {

                        string[] itemsplit = item.Attributes.MediaName.Split(' ');
                        helper = true;



                        Button button = new Button();
                        Image image = new Image();



                        image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + item.Attributes.MediaPicture1, UriKind.Absolute));

                        checker = true;

                        foreach (string item3 in imageursls2)
                        {
                            if (item3 == item.Attributes.MediaPicture1)
                                checker = false;


                        }


                        if (checker == true)
                        {
                            button.Width = 130;
                            button.Height = 180;
                            button.Name = itemsplit[0];
                            button.Background = new SolidColorBrush(Colors.Transparent);
                            button.Margin = new Thickness(0, 0, 1, 0);
                            button.BorderThickness = new Thickness(0);
                            button.Content = image;

                            button.Click += Button_Click;
                            imageursls2.Add(item.Attributes.MediaPicture1);

                            SaveWrapanel.Children.Add(button);




                        }
                        checker = true;

                    } 
                }
                if (Convert.ToInt32(item.Attributes.TblRbYear.Data.Attributes.Year) == DateTime.Now.Year)
                {
                    counter++;
                    mainChoosePageModel = new ObservableCollection<MainChoosePageModel>();

                    foreach (ObservableCollection<MainChoosePageModel> item1 in mainChoosePageModels)
                    {
                        helper = true;
                        string[] itemsplit = item.Attributes.MediaName.Split(' ');
                        MainChoosePageModel mainChoose = new MainChoosePageModel();


                        for (int i = 0; i < itemsplit.Length; i++)
                        {
                            if (i == itemsplit.Length - 1)
                            {
                                mainChoose.txtforbtninfo += itemsplit[i];

                            }
                            else
                            {
                                mainChoose.txtforbtninfo += itemsplit[i] + " ";

                            }

                        }

                        foreach (MainChoosePageModel item3 in item1)
                        {
                            if (item3.txtforbtninfo == mainChoose.txtforbtninfo)
                            {
                                helper = false;
                                continue;
                            }
                        }


                    }
                    if (helper == true)
                    {

                        string[] itemsplit = item.Attributes.MediaName.Split(' ');
                        helper = true;



                        Button button = new Button();
                        Image image = new Image();



                        image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + item.Attributes.MediaPicture1, UriKind.Absolute));

                        checker = true;

                        foreach (string item3 in imageursls3)
                        {
                            if (item3 == item.Attributes.MediaPicture1)
                                checker = false;


                        }


                        if (checker == true)
                        {
                            button.Width = 130;
                            button.Height = 180;
                            button.Name = itemsplit[0];
                            button.Background = new SolidColorBrush(Colors.Transparent);
                            button.Margin = new Thickness(0, 0, 1, 0);
                            button.BorderThickness = new Thickness(0);
                            button.Content = image;

                            button.Click += Button_Click;
                            imageursls3.Add(item.Attributes.MediaPicture1);

                            NewWrapanel.Children.Add(button);




                        }
                        checker = true;

                    }

                } 
                if (counter < 6 && counter1 < 8)
                {
                    
                    mainChoosePageModel = new ObservableCollection<MainChoosePageModel>();

                    foreach (ObservableCollection<MainChoosePageModel> item1 in mainChoosePageModels)
                    {
                        helper = true;
                        string[] itemsplit = item.Attributes.MediaName.Split(' ');
                        MainChoosePageModel mainChoose = new MainChoosePageModel();


                        for (int i = 0; i < itemsplit.Length; i++)
                        {
                            if (i == itemsplit.Length - 1)
                            {
                                mainChoose.txtforbtninfo += itemsplit[i];

                            }
                            else
                            {
                                mainChoose.txtforbtninfo += itemsplit[i] + " ";

                            }

                        }

                        foreach (MainChoosePageModel item3 in item1)
                        {
                            if (item3.txtforbtninfo == mainChoose.txtforbtninfo)
                            {
                                helper = false;
                                continue;
                            }
                        }


                    }
                    if (helper == true)
                    {

                        string[] itemsplit = item.Attributes.MediaName.Split(' ');
                        helper = true;



                        Button button = new Button();
                        Image image = new Image();



                        image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + item.Attributes.MediaPicture1, UriKind.Absolute));

                        checker = true;

                        foreach (string item3 in imageursls3)
                        {
                            if (item3 == item.Attributes.MediaPicture1)
                                checker = false;


                        }


                        if (checker == true)
                        {
                            counter1++;

                            button.Width = 130;
                            button.Height = 180;
                            button.Name = itemsplit[0];
                            button.Background = new SolidColorBrush(Colors.Transparent);
                            button.Margin = new Thickness(0, 0, 1, 0);
                            button.BorderThickness = new Thickness(0);
                            button.Content = image;

                            button.Click += Button_Click;
                            imageursls3.Add(item.Attributes.MediaPicture1);

                            NewWrapanel.Children.Add(button);




                        }
                        checker = true;

                    }
                }
                if (counter2 < 15)
                {

                    mainChoosePageModel = new ObservableCollection<MainChoosePageModel>();

                    foreach (ObservableCollection<MainChoosePageModel> item1 in mainChoosePageModels)
                    {
                        helper = true;
                        string[] itemsplit = item.Attributes.MediaName.Split(' ');
                        MainChoosePageModel mainChoose = new MainChoosePageModel();


                        for (int i = 0; i < itemsplit.Length; i++)
                        {
                            if (i == itemsplit.Length - 1)
                            {
                                mainChoose.txtforbtninfo += itemsplit[i];

                            }
                            else
                            {
                                mainChoose.txtforbtninfo += itemsplit[i] + " ";

                            }

                        }

                        foreach (MainChoosePageModel item3 in item1)
                        {
                            if (item3.txtforbtninfo == mainChoose.txtforbtninfo)
                            {
                                helper = false;
                                continue;
                            }
                        }


                    }
                    if (helper == true)
                    {

                        string[] itemsplit = item.Attributes.MediaName.Split(' ');
                        helper = true;



                        Button button = new Button();
                        Image image = new Image();



                        image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + item.Attributes.MediaPicture1, UriKind.Absolute));

                        checker = true;

                        foreach (string item3 in imageursls4)
                        {
                            if (item3 == item.Attributes.MediaPicture1)
                                checker = false;


                        }


                        if (checker == true)
                        {
                            counter2++;


                            button.Width = 130;
                            button.Height = 180;
                            button.Name = itemsplit[0];
                            button.Background = new SolidColorBrush(Colors.Transparent);
                            button.Margin = new Thickness(0, 0, 1, 0);
                            button.BorderThickness = new Thickness(0);
                            button.Content = image;

                            button.Click += Button_Click;
                            imageursls4.Add(item.Attributes.MediaPicture1);

                            NewAddedWrapanel.Children.Add(button);




                        }
                        checker = true;

                    }
                }





            }
            #endregion

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
