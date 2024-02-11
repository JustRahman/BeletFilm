using Belet.Command;
using Belet.Model;
using Belet.Model.NewMedia;
using Belet.Model.MediaCountry;
using Belet.Model.MediaGener;
using Belet.Model.MediaType;
using Belet.Model.Reactions;
using Belet.Model;
using Belet.Model.UserReaction;
using DevExpress.Mvvm;
using MaterialDesignThemes.Wpf;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Security.Cryptography;
using System.IO;
using System.Security.Cryptography;

namespace Belet.ViewModels
{
    class MainChoosePageViewModel : ViewModelBase
    {

         //смотреть фильмы


        //private ObservableCollection<NecessaryMedia> _necessaryMedias;
        //public ObservableCollection<NecessaryMedia> necessaryMedias
        //{
        //    get
        //    {
        //        return _necessaryMedias;
        //    }
        //    set
        //    {
        //        SetValue(ref _necessaryMedias , value);
        //    }
        //}

        private ScrollViewer _scrollViewer;
        public ScrollViewer scrollViewer
        {
            get
            {
                return _scrollViewer;
            }
            set
            {
                SetValue(ref _scrollViewer, value);
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

        private Grid _firstgrid;
        public Grid firstgrid
        {
            get
            {
                return _firstgrid;
            }
            set
            {
                SetValue(ref _firstgrid, value);
            }
        }

        private WrapPanel _wrapPanel;
        public WrapPanel wrapPanel
        {
            get
            {
                return _wrapPanel;
            }
            set
            {
                SetValue(ref _wrapPanel, value);
            }
        }

        

        private StackPanel _stackPanel;
        public StackPanel stackPanel
        {
            get
            {
                return _stackPanel;
            }
            set
            {
                SetValue(ref _stackPanel, value);
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

     

        private Window _wnd;
        public Window wnd
        {
            get
            {
                return _wnd;
            }
            set
            {
                SetValue(ref _wnd,value);
            }
        }


        private ComboBox _MediatypeComboBox;
        public ComboBox MediatypeComboBox
        {
            get
            {
                return _MediatypeComboBox;
            }
            set
            {
                SetValue(ref _MediatypeComboBox,value);
            }
        }

        private ComboBox _GenersComboBox;
        public ComboBox GenersComboBox
        {
            get
            {
                return _GenersComboBox;
            }
            set
            {
                SetValue(ref _GenersComboBox, value);
            }
        }

        private ComboBox _CountryComboBox;
        public ComboBox CountryComboBox
        {
            get
            {
                return _CountryComboBox;
            }
            set
            {
                SetValue(ref _CountryComboBox, value);
            }
        }


        private List<int> _MoveIdLike2;
        public List<int> MoveIdLike2
        {
            get
            {
                return _MoveIdLike2;
            }
            set
            {
                SetValue(ref _MoveIdLike2, value);
            }
        }

        private List<int> _MoveIdNoLike2;
        public List<int> MoveIdNoLike2
        {
            get
            {
                return _MoveIdNoLike2;
            }
            set
            {
                SetValue(ref _MoveIdNoLike2, value);
            }
        }

        private List<int> _MoveIdNoSave2;
        public List<int> MoveIdNoSave2
        {
            get
            {
                return _MoveIdNoSave2;
            }
            set
            {
                SetValue(ref _MoveIdNoSave2, value);
            }
        }

        private List<int> _MediaReactionTypeSave2;
        public List<int> MediaReactionTypeSave2
        {
            get
            {
                return _MediaReactionTypeSave2;
            }
            set
            {
                SetValue(ref _MediaReactionTypeSave2, value);
            }
        }

        private List<int> _MediaReactionTypeLike2;
        public List<int> MediaReactionTypeLike2
        {
            get
            {
                return _MediaReactionTypeLike2;
            }
            set
            {
                SetValue(ref _MediaReactionTypeLike2, value);
            }
        }

        private List<int> _MoveIdSave2;
        public List<int> MoveIdSave2
        {
            get
            {
                return _MoveIdSave2;
            }
            set
            {
                SetValue(ref _MoveIdSave2, value);
            }
        }



        private int _MoveIdLike;
        public int MoveIdLike
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

        private int _MoveIdNoLike;
        public int MoveIdNoLike
        {
            get
            {
                return _MoveIdNoLike;
            }
            set
            {
                SetValue(ref _MoveIdNoLike, value);
            }
        }

        private int _MoveIdNoSave;
        public int MoveIdNoSave
        {
            get
            {
                return _MoveIdNoSave;
            }
            set
            {
                SetValue(ref _MoveIdNoSave, value);
            }
        }

        private int _MediaReactionTypeSave;
        public int MediaReactionTypeSave
        {
            get
            {
                return _MediaReactionTypeSave;
            }
            set
            {
                SetValue(ref _MediaReactionTypeSave, value);
            }
        }

        private int _MediaReactionTypeLike;
        public int MediaReactionTypeLike
        {
            get
            {
                return _MediaReactionTypeLike;
            }
            set
            {
                SetValue(ref _MediaReactionTypeLike, value);
            }
        }

        private int _MoveIdSave;
        public int MoveIdSave
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


        private ComboBox _SortMediaCombobox;
        public ComboBox SortMediaCombobox
        {
            get
            {
                return _SortMediaCombobox;
            }
            set
            {
                SetValue(ref _SortMediaCombobox, value);
            }
        }

        private TextBox _SearchText;
        public TextBox SearchText
        {
            get
            {
                return _SearchText;
            }
            set
            {
                SetValue(ref _SearchText, value);
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

        public INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }

        bool wndstate = false;
 

        private ObservableCollection<string> _geners;

        public ObservableCollection<string> Geners
        {
            get
            {
                return _geners;
            }
            set
            {
                SetValue(ref _geners,value);
            }
        }


        private ObservableCollection<string> _SortMedia;

        public ObservableCollection<string> SortMedia
        {
            get
            {
                return _SortMedia;
            }
            set
            {
                SetValue(ref _SortMedia, value);
            }
        }


        private ObservableCollection<string> _katagory;

        public ObservableCollection<string> Kategory
        {
            get
            {
                return _katagory;
            }
            set
            {
                SetValue(ref _katagory, value);
            }
        }

        private ObservableCollection<UserReactionModel> _UserMediaReaction;

        public ObservableCollection<UserReactionModel> UserMediaReaction
        {
            get
            {
                return _UserMediaReaction;
            }
            set
            {
                SetValue(ref _UserMediaReaction, value);
            }
        }

        private ObservableCollection<string> _countries;

        public ObservableCollection<string> Countries
        {
            get
            {
                return _countries;
            }
            set
            {
                SetValue(ref _countries, value);
            }
        }


        private readonly PaletteHelper paletteHelper = new PaletteHelper();


        static HttpClient httpClient;



        private MainChoosePageModel _filmModel;
        public MainChoosePageModel filmModel
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


        bool checkertype = true;
        public MyDelegateCommand BtnInfoForAll { get; set; }
        public MyDelegateCommand SizeChangedEvent { get; set; }
        public DelegateCommand goldawmerkezi { get; set; }
        public DelegateCommand OnViewLoadedCommand { get; set; }
        public DelegateCommand presentBtn { get; set; }
        public DelegateCommand close_application { get; set; }
        public DelegateCommand sizechangebtn { get; set; }
        public DelegateCommand cmdLogin { get; set; }

        public MyDelegateCommand InitializeCommand { get; set; }
        public DelegateCommand back { get; set; } 
        public DelegateCommand LogOutBtn { get; set; }
        string path;
        string pathKey;
        string pathIV;
        bool checker = true;
        bool helper = true;
        bool FirstScip = false;
        string imageurl = " ";
        string medianame = " ";
        int counter = 0;
        int counter1 = 0;

        int counter2 = 0;


        public MainChoosePageViewModel()
        {
            imageursls = new List<string>();
            mainChoosePageModels = new ObservableCollection<ObservableCollection<MainChoosePageModel>>();
            filmModel = new MainChoosePageModel();
            Geners = new ObservableCollection<string>();
            Kategory = new ObservableCollection<string>();
            Countries = new ObservableCollection<string>();
            SortMedia = new ObservableCollection<string>();

            path = System.AppDomain.CurrentDomain.BaseDirectory + "config.json";
            pathKey = System.AppDomain.CurrentDomain.BaseDirectory + "configKey.json";
            pathIV = System.AppDomain.CurrentDomain.BaseDirectory + "configIV.json";

            LogOutBtn = new DelegateCommand(() => LogOutBtn_cmd());
            goldawmerkezi = new DelegateCommand(() => goldawmerkezi_cmd());
            close_application = new DelegateCommand(() => close_application_cmd());

            cmdLogin = new DelegateCommand(cmdLogin_cmd);

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:1337/api/");

            ITheme theme = paletteHelper.GetTheme();
            theme.SetBaseTheme(Theme.Dark);
            paletteHelper.SetTheme(theme);
            
            
            sizechangebtn = new DelegateCommand(()=> sizechangebtn_cmd());
            InitializeCommand = new MyDelegateCommand(w => InitializeCommand_cmd(w));
            back = new DelegateCommand(()=> back_cmd());
            presentBtn = new DelegateCommand(()=> presentBtn_cmd());
            SizeChangedEvent = new MyDelegateCommand(qwe => SizeChangedEvent_cmd(qwe));
            filmModel.IsBigOrNormal = "Big Mode";

            MoveIdLike2 = new List<int>();
            MoveIdSave2 = new List<int>();
            MoveIdNoLike2 = new List<int>();
            MoveIdNoSave2 = new List<int>();
            MediaReactionTypeSave2 = new List<int>();
            MediaReactionTypeLike2 = new List<int>();

        }

        private void close_application_cmd()
        {
            wnd.Close();
        }

        private void goldawmerkezi_cmd()
        {
            Process.Start("https://help.belet.com.tm/");
        }

        private void cmdLogin_cmd()
        {
            wnd.WindowState = WindowState.Minimized;
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
        private void SizeChangedEvent_cmd(object o)
        {
            if (FirstScip == true)
            {
                wrapPanel.Width = wnd.Width;
            }
        }

        private void back_cmd()
        {
            NavigationService.GoBack();
        }


        private void sizechangebtn_cmd()
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
                filmModel.IsBigOrNormal = "Bid Mode";

            }
        }
  
        private async void InitializeCommand_cmd(object o)
        {
            Countries.Add("all");
            Geners.Add("all");
            Kategory.Add("all");
            SortMedia.Add("По умолчанию"); 
            SortMedia.Add("По рейтингу");
            SortMedia.Add("Понравившиеся");
            SortMedia.Add("Сохраненные");
            SortMedia.Add("Новые");


            HttpResponseMessage response1 = await httpClient.GetAsync("company-infos?populate=*");
            string str1 = response1.Content.ReadAsStringAsync().Result;
            //Media media1 = JsonConvert.DeserializeObject<Media>(str1);
            Media mediaObject = JsonConvert.DeserializeObject<Media>(str1);

            HttpResponseMessage response2 = await httpClient.GetAsync("tbl-rb-geners");
            string str2 = response2.Content.ReadAsStringAsync().Result;
            //MediaGener media2 = JsonConvert.DeserializeObject<MediaGener>(str2);
            MediaGener mediaObjectGener = JsonConvert.DeserializeObject<MediaGener>(str2);

            HttpResponseMessage response3 = await httpClient.GetAsync("company-media-types");
            string str3 = response3.Content.ReadAsStringAsync().Result;
            //MediaGener media3 = JsonConvert.DeserializeObject<MediaGener>(str3);
            MediaType mediaObjectType = JsonConvert.DeserializeObject<MediaType>(str3);

            HttpResponseMessage response4 = await httpClient.GetAsync("tbl-rb-countries");
            string str4 = response4.Content.ReadAsStringAsync().Result;
            //MediaGener media3 = JsonConvert.DeserializeObject<MediaGener>(str3);
            MediaCountry mediaObjectCountry = JsonConvert.DeserializeObject<MediaCountry>(str4);

            HttpResponseMessage response5 = await httpClient.GetAsync($"user-reactions?populate=*");
            string str5 = response5.Content.ReadAsStringAsync().Result;
            UserReaction mediaReaction = JsonConvert.DeserializeObject<UserReaction>(str5);



            if (mediaReaction.Meta.Pagination.PageCount != 0)
            {
                //foreach (DatumReactions datumReaction in mediaReaction.Data)
                //{
                //    //if (datumReaction.Attributes.ReactionTypeId.Contains("1"))
                //    //{
                //    //    if (datumReaction.Attributes.ReactionTypeId == "1")
                //    //    {
                //    //        MoveIdLike.Add(Convert.ToInt32(datumReaction.Attributes.MoveId));
                //    //    }
                //    //    else if (datumReaction.Attributes.ReactionTypeId == "01")
                //    //    {
                //    //        continue;
                //    //    }

                //    //}

                //    //if (datumReaction.Attributes.ReactionTypeId.Contains("2"))
                //    //{
                //    //    if (datumReaction.Attributes.ReactionTypeId == "2")
                //    //    {
                //    //        MoveIdSave.Add(Convert.ToInt32(datumReaction.Attributes.MoveId));
                //    //    }
                //    //    else if (datumReaction.Attributes.ReactionTypeId == "02")
                //    //    {
                //    //        continue;
                //    //    }



                //    //}


                //}
             
               
            }


         


            if (File.Exists(path) == true && File.Exists(pathKey) == true && File.Exists(pathIV) == true )
            {

                try
                {
                    using (RijndaelManaged myRijndael = new RijndaelManaged())
                    {
                        var numbersArray = File.ReadAllText(path).Split(null);
                        var numbersArrayKey = File.ReadAllText(pathKey).Split(null);
                        var numbersArrayIV = File.ReadAllText(pathIV).Split(null);
                        List<byte> encrypted = new List<byte>();
                        List<byte> encryptedKey = new List<byte>();
                        List<byte> encryptedIV = new List<byte>();

                        foreach (string number in numbersArray)
                        {
                            if (number != "")
                            {
                                byte byteValue = byte.Parse(number);
                                encrypted.Add(byteValue);
                            }
                            
                        }

                        foreach (string number in numbersArrayKey)
                        {
                            if (number != "")
                            {
                                byte byteValue = byte.Parse(number);
                                encryptedKey.Add(byteValue);
                            }

                        }

                        foreach (string number in numbersArrayIV)
                        {
                            if (number != "")
                            {
                                byte byteValue = byte.Parse(number);
                                encryptedIV.Add(byteValue);
                            }

                        }

                        byte[] bytesArray = encrypted.ToArray();
                        byte[] bytesArrayKey = encryptedKey.ToArray();
                        byte[] bytesArrayIV = encryptedIV.ToArray();


                        // Encrypt the string to an array of bytes. 

                        // Decrypt the bytes to a string. 
                        string roundtrip = DecryptStringFromBytes(bytesArray, bytesArrayKey, bytesArrayIV);
                        var UserLogid = JsonConvert.DeserializeObject<List<PersonInfoClass>>(roundtrip);
                        StaticsForTheme.PersonId = UserLogid[0].PersonId;
                        StaticsForTheme.PersonPhoneNumber = UserLogid[0].PersonPhoneNumber;

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                StaticsForTheme.UserMediaReactions = new ObservableCollection<UserReactionModel>();
                foreach (var item in mediaReaction.Data)
                {
                    UserMediaReaction = new ObservableCollection<UserReactionModel>();
                    if (item.Attributes.UserId == StaticsForTheme.PersonId)
                    {
                        UserReactionModel userReactionModel = new UserReactionModel();
                        userReactionModel.MediaReactionType = Convert.ToInt32(item.Id);
                        userReactionModel.MediaID = Convert.ToInt32(item.Attributes.MediaId);
                        userReactionModel.UserReactionType = item.Attributes.ReactionTypeId;
                        userReactionModel.UserId = Convert.ToInt32(item.Attributes.UserId);

                        StaticsForTheme.UserMediaReactions.Add(userReactionModel);
                    }
                    
                    //if (item.Attributes.UserId == StaticsForTheme.PersonId && item.Attributes.ReactionTypeId == "1")
                    //{
                    //    MoveIdLike2.Add(Convert.ToInt32(item.Attributes.MediaId));
                    //    MediaReactionTypeLike2.Add(Convert.ToInt32(item.Id));

                    //    continue;
                    //}
                    //else if (item.Attributes.UserId == StaticsForTheme.PersonId && item.Attributes.ReactionTypeId == "2")
                    //{
                    //    MoveIdSave2.Add(Convert.ToInt32(item.Attributes.MediaId));
                    //    MediaReactionTypeSave2.Add(Convert.ToInt32(item.Id));

                    //    continue;
                    //}
                    //else if (item.Attributes.UserId == StaticsForTheme.PersonId && item.Attributes.ReactionTypeId == "01")
                    //{
                    //    MoveIdNoLike2.Add(Convert.ToInt32(item.Attributes.MediaId));
                    //    MediaReactionTypeLike2.Add(Convert.ToInt32(item.Id));

                    //    continue;
                    //}
                    //else if (item.Attributes.UserId == StaticsForTheme.PersonId && item.Attributes.ReactionTypeId == "02")
                    //{
                    //    MoveIdNoSave2.Add(Convert.ToInt32(item.Attributes.MediaId));
                    //    MediaReactionTypeSave2.Add(Convert.ToInt32(item.Id));
                    //    continue;
                    //}


                    //StaticsForTheme.MoveIdLike2 = MoveIdLike2;
                    //StaticsForTheme.MoveIdSave2 = MoveIdSave2;
                    //StaticsForTheme.MoveIdNoSave2 = MoveIdNoSave2;
                    //StaticsForTheme.MoveIdNoLike2 = MoveIdNoLike2;
                    //StaticsForTheme.MediaReactionTypeLike2 = MediaReactionTypeLike2;
                    //StaticsForTheme.MediaReactionTypeSave2 = MediaReactionTypeSave2;


                }

            }
            else
            {
                MessageBox.Show("You cant watch media");
                Views.LogginPassword logginPassword = new Views.LogginPassword();
                wnd.Close();
                logginPassword.ShowDialog();

            }


            if (StaticsForTheme.counter == 0)
            {
                foreach (DatumGener item in mediaObjectGener.Data)
                {
                    
                    if (item.Attributes.GenerName != "all")
                    {
                        Geners.Add(item.Attributes.GenerName);
                    }
                }

                foreach (DatumCountry item in mediaObjectCountry.Data)
                {
                    if (item.Attributes.CountryName != "all")
                    {
                        Countries.Add(item.Attributes.CountryName);
                    }
                }

                foreach (DatumType item in mediaObjectType.Data)
                {
                    if (item.Attributes.MediaTypeName != "all")
                    {
                        Kategory.Add(item.Attributes.MediaTypeName);
                    }
                }


                foreach (MediaDatum item in mediaObject.Data)
                {
                    scrollViewer = new ScrollViewer();
                    wrapPanel = new WrapPanel();
                    firstgrid = new Grid();
                    stackPanel = new StackPanel();

                    object[] wind = o as object[];
                    wnd = (Window)wind[0];
                    firstgrid = (Grid)wind[1];
                    scrollViewer = (ScrollViewer)wind[2];
                    wrapPanel = (WrapPanel)wind[3];
                    MediatypeComboBox = (ComboBox)wind[4];
                    CountryComboBox = (ComboBox)wind[5];
                    GenersComboBox = (ComboBox)wind[6];
                    SortMediaCombobox = (ComboBox)wind[7];
                    LOB = (Button)wind[8];
                    SearchText = (TextBox)wind[9];

                    

                   
                    

                    //StaticsForTheme.counter++;
                    //FirstScip = true;
                    mainChoosePageModel = new ObservableCollection<MainChoosePageModel>();

                    foreach (ObservableCollection<MainChoosePageModel> item1 in mainChoosePageModels)
                    {
                        
          

                        foreach (MainChoosePageModel  item3  in item1)
                        {
                            if(item3.txtforbtninfo == item.Attributes.MediaName)
                            {
                                helper = false;
                                break;
                            }
                        }

                        
                    }
                    if (helper == true)
                    {
                        foreach (MediaDatum item1 in mediaObject.Data)
                        {
                            string[] item1split = item1.Attributes.MediaName.Split(' ');
                            string[] itemsplit = item.Attributes.MediaName.Split(' ');
                            foreach (var iitem in item.Attributes.TblRbMediaTypes.Data)
                            {
                                if (iitem.Attributes.MediaTypeName.Contains("serial"))
                                {
                                    medianame = item1split[0];
                                    checker = false;
                                }

                            }
                            if (checker == true)
                            {
                                medianame = item.Attributes.MediaName;
                            }
                            if (item1split[0] == itemsplit[0] )
                            {
                                

                                MainChoosePageModel mainChoose = new MainChoosePageModel();
                                mainChoose.txtforbtninfo = item1.Attributes.MediaName;
                                mainChoose.mediaduration = Convert.ToString(item1.Attributes.Duration);
                                mainChoose.picforbtnninfo = item1.Attributes.MediaPicture1;
                                mainChoose.picforbtnninfo1 = item1.Attributes.MediaPicture2;
                                mainChoose.txtdescription = item1.Attributes.MediaDescription;
                                mainChoose.mediaid = Convert.ToInt32(item1.Id);
                                mainChoose.tblfirstrating = double.Parse((item1.Attributes.Firstrating ?? 0.0).ToString());
                                mainChoose.tblmediasecondrating = Convert.ToInt32(item1.Attributes.Secondrating ?? 0.0);
                                mainChoose.tblmediaacceptableyear = Convert.ToString(item1.Attributes.Acceptableyear ?? 0.0);

                                foreach (var item2 in item1.Attributes.TblRbGeners.Data)
                                {


                                    mainChoose.tblmediagener += " " + item2.Attributes.GenerName;

                                }

                                foreach (var item2 in item1.Attributes.TblRbCountries.Data)
                                {
                                    mainChoose.tblmediacountry += " " + item2.Attributes.CountryName;
                                }

                                foreach (var item2 in item1.Attributes.TblRbMediaActors.Data)
                                {
                                    mainChoose.tblmediaactors += " " + item2.Attributes.ActorName;
                                }

                                foreach (var item2 in item1.Attributes.TblRbMediaDirectors.Data)
                                {
                                    mainChoose.tblmediadirector += " " + item2.Attributes.DirectorName;
                                }
                                foreach (var item2 in item1.Attributes.TblRbLanguages.Data)
                                {
                                    mainChoose.medialanguage = item2.Attributes.LanguageName;
                                }
                                foreach (var item2 in item1.Attributes.TblRbMediaTypes.Data)
                                {
                                    mainChoose.tblRbMediaType += " " + item2.Attributes.MediaTypeName;
                                }
                                mainChoose.tblmediayear = Convert.ToInt32(item1.Attributes.TblRbYear.Data.Attributes.Year);
                                mainChoose.Media_path = item1.Attributes.Media_path;


                                imageurl = item1.Attributes.MediaPicture1;




                                mainChoosePageModel.Add(mainChoose);

                            }
                            else
                            {
                                    
                            }
                        }

                        mainChoosePageModels.Add(mainChoosePageModel);
                        
                        
                        Button button = new Button();
                        Image image = new Image();



                        image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + imageurl, UriKind.Absolute));

                        button.Width = 130;
                        button.Height = 180;
                        button.Name = medianame.Split()[0];
                        button.Background = new SolidColorBrush(Colors.Transparent);
                        button.Margin = new Thickness(0, 0, 1, 0);
                        button.BorderThickness = new Thickness(0);
                        button.Content = image;

                        button.Click += Button_Click;
                        imageursls.Add(imageurl);


                        wrapPanel.Children.Add(button);
                        checker = true;
                        

                    }
                    helper = true;

                }


            }
            StaticsForTheme.StaticModelMediaContainer = mainChoosePageModels;
            MediatypeComboBox.SelectionChanged += CountryComboBox_SelectionChanged;
            GenersComboBox.SelectionChanged += CountryComboBox_SelectionChanged;
            CountryComboBox.SelectionChanged += CountryComboBox_SelectionChanged;
            SortMediaCombobox.SelectionChanged += CountryComboBox_SelectionChanged;
            SearchText.TextChanged += CountryComboBox_SelectionChanged;

        }




        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments. 
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold 
            // the decrypted text. 
            string plaintext = null;

            // Create an RijndaelManaged object 
            // with the specified key and IV. 
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                // Create the streams used for decryption. 
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream 
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }


        private void CountryComboBox_SelectionChanged(object sender, EventArgs e)
        {
            wrapPanel.Children.Clear();
            imageursls.Clear();

            void CardCreaterWithoutSpace(ObservableCollection<MainChoosePageModel> item)
            {
                if (item[0].tblRbMediaType.Contains((MediatypeComboBox.SelectedItem).ToString()) && item[0].tblmediagener.Contains((GenersComboBox.SelectedItem).ToString()) && item[0].tblmediacountry.Contains((CountryComboBox.SelectedItem).ToString()))
                {
                    Button button = new Button();
                    Image image = new Image();
                    string[] itemsplit = item[0].txtforbtninfo.Split(' ');
                    image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + item[0].picforbtnninfo, UriKind.Absolute));
                    foreach (string item3 in imageursls)
                    {
                        if (item3 == item[0].picforbtnninfo)
                            checker = false;
                    }
                    if (checker == true)
                    {
                        button.Width = 130;
                        button.Height = 180;
                        button.Background = new SolidColorBrush(Colors.Transparent);
                        button.Margin = new Thickness(0, 0, 1, 0);
                        button.BorderThickness = new Thickness(0);
                        button.Content = image;
                        button.Name = itemsplit[0];
                        button.Click += Button_Click;
                        imageursls.Add(item[0].picforbtnninfo);
                        wrapPanel.Children.Add(button);

                    }
                    checker = true;
                }
              
            }

            void CardCreaterWithSpace(ObservableCollection<MainChoosePageModel> item)
            {
                string[] item1split = item[0].txtforbtninfo.Split(' ');
                if (((item1split[0]).ToLower()).Contains((SearchText.Text).ToLower()) && item[0].tblRbMediaType.Contains((MediatypeComboBox.SelectedItem).ToString()) && item[0].tblmediagener.Contains((GenersComboBox.SelectedItem).ToString()) && item[0].tblmediacountry.Contains((CountryComboBox.SelectedItem).ToString()))
                {

                    Button button = new Button();
                    Image image = new Image();
                    string[] itemsplit = item[0].txtforbtninfo.Split(' ');
                    image.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + item[0].picforbtnninfo, UriKind.Absolute));
                    foreach (string item3 in imageursls)
                    {
                        if (item3 == item[0].picforbtnninfo)
                            checker = false;
                    }
                    if (checker == true)
                    {
                        button.Width = 130;
                        button.Height = 180;
                        button.Background = new SolidColorBrush(Colors.Transparent);
                        button.Margin = new Thickness(0, 0, 1, 0);
                        button.BorderThickness = new Thickness(0);
                        button.Content = image;
                        button.Name = itemsplit[0];
                        button.Click += Button_Click;
                        imageursls.Add(item[0].picforbtnninfo);
                        wrapPanel.Children.Add(button);

                    }
                    checker = true;
                }

            }

            if (string.IsNullOrWhiteSpace(SearchText.Text) == true)
            {
                foreach (ObservableCollection<MainChoosePageModel> item in mainChoosePageModels)
                {
                    if (SortMediaCombobox.SelectedItem == "Понравившиеся")
                    {
                        foreach (var iitem in item)
                        {
                            if (MoveIdLike2.Contains(Convert.ToInt32(iitem.mediaid)))
                            {
                                CardCreaterWithoutSpace(item);
                            }
                        }

                    }
                    else if (SortMediaCombobox.SelectedItem == "Новые")
                    {
                        if (Convert.ToInt32(item[0].tblmediayear) == DateTime.Now.Year)
                        {
                            CardCreaterWithoutSpace(item);
                        }
                    }
                    else if (SortMediaCombobox.SelectedItem == "Сохраненные")
                    {
                        foreach (var iitem in item)
                        {
                            if (MoveIdSave2.Contains(Convert.ToInt32(iitem.mediaid)))
                            {
                                CardCreaterWithoutSpace(item);
                            }
                        }

                    }
                    else if (SortMediaCombobox.SelectedItem == "По рейтингу")
                    {
                        var sortedList = mainChoosePageModels.OrderBy(i => i[0].tblfirstrating).ToList();

                        foreach (ObservableCollection<MainChoosePageModel> item1 in sortedList)
                        {

                            CardCreaterWithoutSpace(item);
                        }

                    }
                    else
                    {
                        CardCreaterWithoutSpace(item);

                    }

                }
            }
            else
            {
                foreach (ObservableCollection<MainChoosePageModel> item in mainChoosePageModels)
                {
                    if (SortMediaCombobox.SelectedItem == "Понравившиеся")
                    {
                        foreach (var iitem in item)
                        {
                            if (MoveIdLike2.Contains(Convert.ToInt32(iitem.mediaid)))
                            {
                                CardCreaterWithSpace(item);
                            }
                        }

                    }
                    else if (SortMediaCombobox.SelectedItem == "Новые")
                    {
                        if (Convert.ToInt32(item[0].tblmediayear) == DateTime.Now.Year)
                        {
                            CardCreaterWithSpace(item);
                        }
                    }
                    else if (SortMediaCombobox.SelectedItem == "Сохраненные")
                    {
                        foreach (var iitem in item)
                        {
                            if (MoveIdSave2.Contains(Convert.ToInt32(iitem.mediaid)))
                            {
                                CardCreaterWithSpace(item);
                            }
                        }

                    }
                    else if (SortMediaCombobox.SelectedItem == "По рейтингу")
                    {
                        var sortedList = mainChoosePageModels.OrderBy(i => i[0].tblfirstrating).ToList();

                        foreach (ObservableCollection<MainChoosePageModel> item1 in sortedList)
                        {

                            CardCreaterWithSpace(item);
                        }

                    }
                    else
                    {
                        CardCreaterWithSpace(item);

                    }

                }
            }
          


        }


        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            StaticsForTheme.GeneralMainChoosePageModels = new ObservableCollection<ObservableCollection<MainChoosePageModel>>();
            helper = false;
            string content = (sender as Button).Name.ToString();
            foreach (ObservableCollection<MainChoosePageModel> item in mainChoosePageModels)
            {
                string[] itemsplit = item[0].txtforbtninfo.Split(' ');
                if (itemsplit[0] == content)
                {
                    if (item[0].txtforbtninfo.Contains("Сезон"))
                    {
                        for (int i = 1; i < 1000; i++)
                        {
                            mainChoosePageModel = new ObservableCollection<MainChoosePageModel>();
                            foreach (var iitem in item)
                            {
                                if (iitem.txtforbtninfo.Contains($"{i}Сезон"))
                                {

                                    mainChoosePageModel.Add(iitem);
                                }
                            }
                            if (mainChoosePageModel.Count > 0)
                            {
                                StaticsForTheme.GeneralMainChoosePageModels.Add(mainChoosePageModel);
                            }
                        }
                    }
                    else
                    {
                        StaticsForTheme.GeneralMainChoosePageModels.Add(item);
                        
                    }
                    StaticsForTheme.media_path_for_last = item[0].Media_path;
                    break;
                  
                }



            }

            //HttpResponseMessage response5 = await httpClient.GetAsync($"user-reactions?populate=*");
            //string str5 = response5.Content.ReadAsStringAsync().Result;
            //UserReaction mediaReaction = JsonConvert.DeserializeObject<UserReaction>(str5);







            Views.MainFilmInfoPage mainFilmInfoPage = new Views.MainFilmInfoPage();
            mainFilmInfoPage.Show();


        }


    }

    
}
