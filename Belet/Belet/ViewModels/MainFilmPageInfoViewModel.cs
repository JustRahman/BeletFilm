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
using Belet.Model.UserReaction;
using System.Net.Http;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Data;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Npgsql;
using System.IO;
using System.Security.Cryptography;

namespace Belet.ViewModels
{
    class MainFilmPageInfoViewModel : ViewModelBase
    {

        #region valuables

        private MainChoosePageModel _pageModel;
        public MainChoosePageModel pageModel
        {
            get
            {
                return _pageModel;
            }
            set
            {
                SetValue(ref _pageModel, value);
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


        private ComboBox _SeasonComboBox;
        public ComboBox SeasonComboBox
        {
            get
            {
                return _SeasonComboBox;
            }
            set
            {
                SetValue(ref _SeasonComboBox, value);
            }
        }


        private ObservableCollection<string> _SeasonAmount;
        public ObservableCollection<string> SeasonAmount
        {
            get
            {
                return _SeasonAmount;
            }
            set
            {
                SetValue(ref _SeasonAmount, value);
            }
        }


        ObservableCollection<ObservableCollection<Border>> _mainChoosePageModels;
        ObservableCollection<ObservableCollection<Border>> mainChoosePageModels
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



        ObservableCollection<Border> _mainChoosePageModel;
        ObservableCollection<Border> mainChoosePageModel
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

        MainChoosePageModel _SingleGeneralMainChoosePageModel;
        MainChoosePageModel SingleGeneralMainChoosePageModel
        {
            get
            {
                return _SingleGeneralMainChoosePageModel;
            }
            set
            {
                SetValue(ref _SingleGeneralMainChoosePageModel, value);
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

        static HttpClient httpClient;
        private readonly PaletteHelper paletteHelper2 = new PaletteHelper();
        private readonly PaletteHelper paletteHelper = new PaletteHelper();
        public INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }


        public MyDelegateCommand InitializeCommand { get; set; }
        public DelegateCommand SaveBtn { get; set; }
        public DelegateCommand PlayerMedia { get; set; }
        public DelegateCommand LikeBtn { get; set; }
        public DelegateCommand presentBtn { get; set; }
        public DelegateCommand close_application { get; set; }
        public DelegateCommand cmdLogin { get; set; }
        public DelegateCommand back { get; set; }
        public DelegateCommand goldawmerkezi { get; set; }

        bool checker = false;
        bool wndstate = false;
        bool TypeChecker = true;
        bool ReactionTypeIdChecker = false;

        string gener_collector;
        string MediaNameContainer;

        int n;
        int DataId;
        int counter = 1;
        int seasoncounter;


        #endregion

        public MainFilmPageInfoViewModel()
        {
            back = new DelegateCommand(() => back_cmd());
            SaveBtn = new DelegateCommand(() => SaveBtn_cmd());
            LikeBtn = new DelegateCommand(() => LikeBtn_cmd());
            cmdLogin = new DelegateCommand(() => cmdLogin_cmd());
            presentBtn = new DelegateCommand(() => presentBtn_cmd());
            PlayerMedia = new DelegateCommand(() => PlayerMedia_cmd());
            goldawmerkezi = new DelegateCommand(() => goldawmerkezi_cmd());
            close_application = new DelegateCommand(() => close_application_cmd());
            InitializeCommand = new MyDelegateCommand(w => InitializeCommand_cmd(w));

            wnd = new Window();
            httpClient = new HttpClient();
            stackPanel = new StackPanel();

            SeasonAmount = new ObservableCollection<string>();
            SingleGeneralMainChoosePageModel = new MainChoosePageModel();
            mainChoosePageModels = new ObservableCollection<ObservableCollection<Border>>();

            SingleGeneralMainChoosePageModel = StaticsForTheme.GeneralMainChoosePageModels[0][0];

        }

        private void goldawmerkezi_cmd()
        {
            Process.Start("https://help.belet.com.tm/");
        }

        private void cmdLogin_cmd()
        {
            wnd.WindowState = WindowState.Minimized;
        }

        private void back_cmd()
        {
            NavigationService.GoBack();
        }

        private void presentBtn_cmd()
        {
            Process.Start("https://film.belet.me/cerificate");
        }

        private void close_application_cmd()
        {
            wnd.Close();
        }

        private void PlayerMedia_cmd()
        {
            Views.BeletVideoPlayer beletVideoPlayer = new BeletVideoPlayer();
            wnd.Close();
            beletVideoPlayer.ShowDialog();
        }

        private async void LikeBtn_cmd()
        {

            foreach (var mediaitem in StaticsForTheme.GeneralMainChoosePageModels)
            {

                if (pageModel.brush1 == "ThumbUpOutline")
                {
                    foreach (var usermediaitem in StaticsForTheme.UserMediaReactions)
                    {
                        foreach (var mediaitemid in mediaitem)
                        {
                            if (mediaitemid.mediaid == usermediaitem.MediaID && usermediaitem.UserReactionType == "01")
                            {
                                ReactionTypeIdChecker = true;

                                var newPost = new Data2();
                                using (var client = new HttpClient())
                                {
                                    var endpoint = new Uri($"http://localhost:1337/api/user-reactions/{usermediaitem.MediaReactionType}");
                                    newPost = new Data2()
                                    {
                                        user_id = StaticsForTheme.PersonId,
                                        media_id = mediaitemid.mediaid,
                                        reaction_type_id = "1"
                                    };
                                    var newPostJson2 = new PutCreateClass()
                                    {
                                        data2 = newPost
                                    };
                                    var newPostJson = JsonConvert.SerializeObject(newPostJson2);
                                    var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                                    var result = await client.PutAsync(endpoint, payload);

                                }
                                pageModel.brush1 = "ThumbUp";
                                usermediaitem.UserReactionType = "1";

                                break;
                            }
                        }

                    }
                    if (ReactionTypeIdChecker == false)
                    {
                        var newPost = new Data2();
                        using (var client = new HttpClient())
                        {
                            var endpoint = new Uri($"http://localhost:1337/api/user-reactions");
                            newPost = new Data2()
                            {
                                user_id = StaticsForTheme.PersonId,
                                media_id = StaticsForTheme.GeneralMainChoosePageModels[0][0].mediaid,
                                reaction_type_id = "1"
                            };
                            var newPostJson2 = new PutCreateClass()
                            {
                                data2 = newPost
                            };
                            var newPostJson = JsonConvert.SerializeObject(newPostJson2);
                            var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                            var result = await client.PostAsync(endpoint, payload);

                        }
                        pageModel.brush1 = "ThumbUp";
                        HttpResponseMessage response1 = await httpClient.GetAsync($"http://localhost:1337/api/user-reactions?filters[user_id][$eq]={StaticsForTheme.PersonId}&filters[media_id][$eq]={StaticsForTheme.GeneralMainChoosePageModels[0][0].mediaid}&filters[reaction_type_id][$eq]=1&populate=*");
                        string str1 = response1.Content.ReadAsStringAsync().Result;
                        UserReaction mediaObject = JsonConvert.DeserializeObject<UserReaction>(str1);

                        UserReactionModel userReactionModel = new UserReactionModel();
                        userReactionModel.MediaID = Convert.ToInt32(mediaObject.Data[0].Attributes.MediaId);
                        userReactionModel.MediaReactionType = Convert.ToInt32(mediaObject.Data[0].Id);
                        userReactionModel.UserReactionType = mediaObject.Data[0].Attributes.ReactionTypeId;
                        userReactionModel.UserId = Convert.ToInt32(mediaObject.Data[0].Attributes.UserId);
                        StaticsForTheme.UserMediaReactions.Add(userReactionModel);


                        break;
                    }

                    break;

                }
                else if (pageModel.brush1 == "ThumbUp")
                {
                    foreach (var usermediaitem in StaticsForTheme.UserMediaReactions)
                    {
                        foreach (var mediaitemid in mediaitem)
                        {
                            if (mediaitemid.mediaid == usermediaitem.MediaID && usermediaitem.UserReactionType == "1")
                            {
                                var newPost = new Data2();
                                using (var client = new HttpClient())
                                {
                                    var endpoint = new Uri($"http://localhost:1337/api/user-reactions/{usermediaitem.MediaReactionType}");
                                    newPost = new Data2()
                                    {
                                        user_id = StaticsForTheme.PersonId,
                                        media_id = mediaitemid.mediaid,
                                        reaction_type_id = "01"
                                    };
                                    var newPostJson2 = new PutCreateClass()
                                    {
                                        data2 = newPost
                                    };
                                    var newPostJson = JsonConvert.SerializeObject(newPostJson2);
                                    var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                                    var result = await client.PutAsync(endpoint, payload);

                                    usermediaitem.UserReactionType = "01";
                                }
                                pageModel.brush1 = "ThumbUpOutline";
                                break;

                            }

                        }

                    }
                    break;

                }
            }
            ReactionTypeIdChecker = false;


        }

        private async void SaveBtn_cmd()
        {
            foreach (var mediaitem in StaticsForTheme.GeneralMainChoosePageModels)
            {

                if (pageModel.brush2 == "BookmarkOutline")
                {
                    foreach (var usermediaitem in StaticsForTheme.UserMediaReactions)
                    {
                        foreach (var mediaitemid in mediaitem)
                        {
                            if (mediaitemid.mediaid == usermediaitem.MediaID && usermediaitem.UserReactionType == "02")
                            {
                                ReactionTypeIdChecker = true;

                                var newPost = new Data2();
                                using (var client = new HttpClient())
                                {
                                    var endpoint = new Uri($"http://localhost:1337/api/user-reactions/{usermediaitem.MediaReactionType}");
                                    newPost = new Data2()
                                    {
                                        user_id = StaticsForTheme.PersonId,
                                        media_id = mediaitemid.mediaid,
                                        reaction_type_id = "2"
                                    };
                                    var newPostJson2 = new PutCreateClass()
                                    {
                                        data2 = newPost
                                    };
                                    var newPostJson = JsonConvert.SerializeObject(newPostJson2);
                                    var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                                    var result = await client.PutAsync(endpoint, payload);

                                }
                                pageModel.brush2 = "Bookmark";
                                usermediaitem.UserReactionType = "2";

                                break;
                            }
                        }
                    }
                    if (ReactionTypeIdChecker == false)
                    {
                        var newPost = new Data2();
                        using (var client = new HttpClient())
                        {
                            var endpoint = new Uri($"http://localhost:1337/api/user-reactions");
                            newPost = new Data2()
                            {
                                user_id = StaticsForTheme.PersonId,
                                media_id = StaticsForTheme.GeneralMainChoosePageModels[0][0].mediaid,
                                reaction_type_id = "2"
                            };
                            var newPostJson2 = new PutCreateClass()
                            {
                                data2 = newPost
                            };
                            var newPostJson = JsonConvert.SerializeObject(newPostJson2);
                            var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                            var result = await client.PostAsync(endpoint, payload);

                        }
                        pageModel.brush2 = "Bookmark";
                        HttpResponseMessage response1 = await httpClient.GetAsync($"http://localhost:1337/api/user-reactions?filters[user_id][$eq]={StaticsForTheme.PersonId}&filters[media_id][$eq]={StaticsForTheme.GeneralMainChoosePageModels[0][0].mediaid}&filters[reaction_type_id][$eq]=2&populate=*");
                        string str1 = response1.Content.ReadAsStringAsync().Result;
                        UserReaction mediaObject = JsonConvert.DeserializeObject<UserReaction>(str1);
                        UserReactionModel userReactionModel = new UserReactionModel();
                        userReactionModel.MediaID = Convert.ToInt32(mediaObject.Data[0].Attributes.MediaId);
                        userReactionModel.MediaReactionType = Convert.ToInt32(mediaObject.Data[0].Id);
                        userReactionModel.UserReactionType = mediaObject.Data[0].Attributes.ReactionTypeId;
                        userReactionModel.UserId = Convert.ToInt32(mediaObject.Data[0].Attributes.UserId);
                        StaticsForTheme.UserMediaReactions.Add(userReactionModel);


                        break;
                    }
                    break;
                }
                else if (pageModel.brush2 == "Bookmark")
                {
                    foreach (var usermediaitem in StaticsForTheme.UserMediaReactions)
                    {
                        foreach (var mediaitemid in mediaitem)
                        {
                            if (mediaitemid.mediaid == usermediaitem.MediaID && usermediaitem.UserReactionType == "2")
                            {
                                var newPost = new Data2();
                                using (var client = new HttpClient())
                                {
                                    var endpoint = new Uri($"http://localhost:1337/api/user-reactions/{usermediaitem.MediaReactionType}");
                                    newPost = new Data2()
                                    {
                                        user_id = StaticsForTheme.PersonId,
                                        media_id = mediaitemid.mediaid,
                                        reaction_type_id = "02"
                                    };
                                    var newPostJson2 = new PutCreateClass()
                                    {
                                        data2 = newPost
                                    };
                                    var newPostJson = JsonConvert.SerializeObject(newPostJson2);
                                    var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                                    var result = await client.PutAsync(endpoint, payload);

                                    usermediaitem.UserReactionType = "02";
                                }
                                pageModel.brush2 = "BookmarkOutline";
                                break;
                            }
                        }
                    }
                    break;

                }
            }
            ReactionTypeIdChecker = false;
        }

        private async void InitializeCommand_cmd(object o)
        {
            object[] wind = o as object[];
            wnd = (Window)wind[0];
            stackPanel = (StackPanel)wind[1];
            SeasonComboBox = (ComboBox)wind[2];
            pageModel = new MainChoosePageModel();

            foreach (var mediaitem in StaticsForTheme.GeneralMainChoosePageModels)
            {

                foreach (var usermediaitem in StaticsForTheme.UserMediaReactions)
                {

                    foreach (var mediaitemid in mediaitem)
                    {
                        if (mediaitemid.mediaid == usermediaitem.MediaID && usermediaitem.UserReactionType == "01")
                        {
                            pageModel.brush1 = "ThumbUpOutline";
                        }
                        else if (mediaitemid.mediaid == usermediaitem.MediaID && usermediaitem.UserReactionType == "1")
                        {
                            pageModel.brush1 = "ThumbUp";
                        }

                        else if (mediaitemid.mediaid == usermediaitem.MediaID && usermediaitem.UserReactionType == "02")
                        {
                            pageModel.brush2 = "BookmarkOutline";
                        }
                        else if (mediaitemid.mediaid == usermediaitem.MediaID && usermediaitem.UserReactionType == "2")
                        {
                            pageModel.brush2 = "Bookmark";
                        }
                    }
                }



            }
            if (pageModel.brush1 == null)
            {
                pageModel.brush1 = "ThumbUpOutline";
            }
            if (pageModel.brush2 == null)
            {
                pageModel.brush2 = "BookmarkOutline";
            }

            string picforwall = SingleGeneralMainChoosePageModel.picforbtnninfo1;
            if(SingleGeneralMainChoosePageModel.tblRbMediaType.Contains("serial"))
            {
                string[] itemsplit2 = SingleGeneralMainChoosePageModel.txtforbtninfo.Split(' ');
                MediaNameContainer = itemsplit2[0];
            }
            else
            {
                MediaNameContainer = SingleGeneralMainChoosePageModel.txtforbtninfo;
            }

            if (SingleGeneralMainChoosePageModel.tblRbMediaType.Contains("serial"))
            {
                for (int i = 1; i < StaticsForTheme.GeneralMainChoosePageModels.Count + 1; i++)
                {
                    SeasonAmount.Add(Convert.ToString(i) + " season");
                }
            }
            else
            {
                SeasonComboBox.Visibility = Visibility.Hidden;
                TypeChecker = false;
            }

            if (SingleGeneralMainChoosePageModel.tblRbMediaType.Contains("serial"))
            {
                pageModel.durationvisibility = "Collapsed";
                pageModel.seasonvisibility = "Visible";
                if (StaticsForTheme.GeneralMainChoosePageModels.Count == 1)
                    pageModel.tblmediaseasonquality = Convert.ToString(StaticsForTheme.GeneralMainChoosePageModels.Count) + " season";
                else if (StaticsForTheme.GeneralMainChoosePageModels.Count > 1)
                    pageModel.tblmediaseasonquality = Convert.ToString(StaticsForTheme.GeneralMainChoosePageModels.Count) + " seasons";

            }
            else
            {
                pageModel.durationvisibility = "Visible";
                pageModel.seasonvisibility = "Collapsed";

                string[] durationsplit = SingleGeneralMainChoosePageModel.mediaduration.Split(',');
                if (durationsplit[0] != "")
                {
                    if (durationsplit[0] == "1")
                    {
                        pageModel.mediaduration += "1 hour";
                    }
                    else if (int.Parse(durationsplit[0]) > 1)
                    {
                        pageModel.mediaduration += $"{durationsplit[0]} hours";
                    }
                    else if (int.Parse(SingleGeneralMainChoosePageModel.mediaduration) == 0)
                    {
                        pageModel.durationvisibility += "Hidden";
                    }
                }

                if (durationsplit.Length > 1)
                {
                    if (int.Parse(durationsplit[1]) == 1)
                    {
                        pageModel.mediaduration += "1 minute";
                    }
                    else if (int.Parse(durationsplit[1]) > 1)
                    {
                        pageModel.mediaduration += " " + $"{durationsplit[1]} minutes";
                    }
                }




            }

            pageModel.medialanguage = "Language:";
            pageModel.txtforbtninfo = MediaNameContainer;
            pageModel.tblmediayear = SingleGeneralMainChoosePageModel.tblmediayear;
            pageModel.txtdescription = SingleGeneralMainChoosePageModel.txtdescription;
            pageModel.tblfirstrating = SingleGeneralMainChoosePageModel.tblfirstrating;
            pageModel.picforbtnninfo = AppDomain.CurrentDomain.BaseDirectory + picforwall;
            pageModel.tblmediasecondrating = SingleGeneralMainChoosePageModel.tblmediasecondrating;
            pageModel.tblmediaacceptableyear = SingleGeneralMainChoosePageModel.tblmediaacceptableyear + "+";
            pageModel.medialanguage2 = char.ToUpper(SingleGeneralMainChoosePageModel.medialanguage[0]) + SingleGeneralMainChoosePageModel.medialanguage.Substring(1);


            if (SingleGeneralMainChoosePageModel.tblmediagener == null || SingleGeneralMainChoosePageModel.tblmediagener == " ")
            {
                pageModel.tblmediagener = "Geners:";
                pageModel.tblmediagener2 = "information non-attendand";
            }
            else
            {
                pageModel.tblmediagener = "Geners:";
                string[] genersplit = SingleGeneralMainChoosePageModel.tblmediagener.Split(' ');
                string sleshshower = " ";
                foreach (string item in genersplit)
                {


                    int counter = genersplit.Length - 1;
                    if (item == null || item == " " || item == "")
                        continue;
                    else if ((item != null || item != " ") && item != "all")
                    {
                        if (item.Contains("_"))
                        {
                            string[] sleshobjects = item.Split('_');
                            foreach (string item2 in sleshobjects)
                            {
                                sleshshower += " " + char.ToUpper(item2[0]) + item2.Substring(1);
                            }
                            pageModel.tblmediagener2 += sleshshower;
                        }
                        else
                        {
                            pageModel.tblmediagener2 += " " + char.ToUpper(item[0]) + item.Substring(1);
                        }



                        if (item != genersplit[counter])
                            pageModel.tblmediagener2 += ",";

                    }
                }
            }

            if (SingleGeneralMainChoosePageModel.tblmediacountry == null || SingleGeneralMainChoosePageModel.tblmediacountry == " ")
            {
                pageModel.tblmediacountry = "Country:";
                pageModel.tblmediacountry2 = "information non-attendand";
            }
            else
            {
                pageModel.tblmediacountry = "Country:";
                string sleshshower = " ";
                string[] countrysplit = SingleGeneralMainChoosePageModel.tblmediacountry.Split(' ');
                foreach (string item in countrysplit)
                {

                    int counter = countrysplit.Length - 1;
                    if (item == null || item == " " || item == "")
                        continue;
                    else if ((item != null || item != " ") && item != "all")
                    {
                        if (item.Contains("_"))
                        {
                            string[] sleshobjects = item.Split('_');
                            foreach (string item2 in sleshobjects)
                            {
                                sleshshower += " " + char.ToUpper(item2[0]) + item2.Substring(1);
                            }
                            pageModel.tblmediacountry2 += sleshshower;
                        }
                        else
                        {
                            pageModel.tblmediacountry2 += " " + char.ToUpper(item[0]) + item.Substring(1);
                        }



                        if (item != countrysplit[counter])
                            pageModel.tblmediacountry2 += ",";

                        sleshshower = " ";

                    }


                }
            }

            if (SingleGeneralMainChoosePageModel.tblmediadirector == null || SingleGeneralMainChoosePageModel.tblmediadirector == " ")
            {
                pageModel.tblmediadirector = "Directors:";
                pageModel.tblmediadirector2 = "information non-attendand";
            }
            else
            {
                pageModel.tblmediadirector = "Directors:";
                string sleshshower = " ";
                string[] directorsplit = SingleGeneralMainChoosePageModel.tblmediadirector.Split(' ');
                foreach (string item in directorsplit)
                {


                    int counter = directorsplit.Length - 1;
                    if (item == null || item == " " || item == "")
                        continue;
                    else if (item != null || item != " ")
                    {
                        if (item.Contains("_"))
                        {
                            string[] sleshobjects = item.Split('_');
                            foreach (string item2 in sleshobjects)
                            {
                                sleshshower += " " + char.ToUpper(item2[0]) + item2.Substring(1);
                            }
                            pageModel.tblmediadirector2 += sleshshower;
                        }
                        else
                        {
                            pageModel.tblmediadirector2 += " " + char.ToUpper(item[0]) + item.Substring(1);
                        }



                        if (item != directorsplit[counter])
                            pageModel.tblmediadirector2 += ",";

                        sleshshower = " ";

                    }
                }
            }

            if (SingleGeneralMainChoosePageModel.tblmediaactors == null || SingleGeneralMainChoosePageModel.tblmediaactors == " ")
            {
                pageModel.tblmediaactors = "Actors:";
                pageModel.tblmediaactors2 = "information non-attendand";
            }
            else
            {
                pageModel.tblmediaactors = "Actors:";
                string sleshshower = " ";
                string[] actorssplit = SingleGeneralMainChoosePageModel.tblmediaactors.Split(' ');
                foreach (string item in actorssplit)
                {

                    int counter = actorssplit.Length - 1;
                    if (item == null || item == " " || item == "")
                        continue;
                    else if (item != null || item != " ")
                    {
                        if (item.Contains("_"))
                        {
                            string[] sleshobjects = item.Split('_');
                            foreach (string item2 in sleshobjects)
                            {
                                sleshshower += " " + char.ToUpper(item2[0]) + item2.Substring(1);
                            }
                            pageModel.tblmediaactors2 += sleshshower;
                        }
                        else
                        {
                            pageModel.tblmediaactors2 += " " + char.ToUpper(item[0]) + item.Substring(1);
                        }



                        if (item != actorssplit[counter])
                            pageModel.tblmediaactors2 += ",";

                        sleshshower = " ";

                    }
                }
            }

            foreach (ObservableCollection<MainChoosePageModel> item in StaticsForTheme.GeneralMainChoosePageModels)
            {
                mainChoosePageModel = new ObservableCollection<Border>();

                foreach (MainChoosePageModel item2 in item)
                {
                    for (int i = 1; i < SeasonAmount.Count + 1; i++)
                    {
                        if (item2.txtforbtninfo.Contains(i + "Сезон"))
                        {
                            Button button = new Button();
                            Border border1 = new Border();
                            Border border2 = new Border();
                            Grid grid1 = new Grid();
                            StackPanel stackPnl1 = new StackPanel();
                            StackPanel stackPnl2 = new StackPanel();
                            TextBlock textBlock1 = new TextBlock();
                            TextBlock textBlock2 = new TextBlock();
                            TextBlock textBlock3 = new TextBlock();
                            TextBlock textBlock4 = new TextBlock();
                            ImageBrush image = new ImageBrush();



                            image.ImageSource = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + item2.picforbtnninfo, UriKind.Absolute));
                            image.Stretch = Stretch.UniformToFill;
                            border2.CornerRadius = new CornerRadius(15);
                            border2.Width = 100;
                            border2.Height = 70;
                            border2.BorderThickness = new Thickness(0.5);
                            border2.BorderBrush = new SolidColorBrush(Color.FromRgb(143, 143, 140));
                            border2.Background = image;
                            border2.Margin = new Thickness(0, 0, 0, 15);
                            textBlock1.Text = Convert.ToString(counter) + ".";
                            textBlock1.Foreground = new SolidColorBrush(Color.FromRgb(143, 143, 140));
                            textBlock1.FontSize = 20;
                            textBlock1.FontWeight = FontWeights.Normal;
                            textBlock1.Background = new SolidColorBrush(Colors.Transparent);
                            textBlock1.Margin = new Thickness(0, 0, 30, 0);
                            stackPnl1.Orientation = Orientation.Horizontal;
                            stackPnl1.Children.Add(textBlock1);
                            stackPnl1.Children.Add(border2);
                            stackPnl1.HorizontalAlignment = HorizontalAlignment.Left;
                            stackPnl1.VerticalAlignment = VerticalAlignment.Center;
                            textBlock4.Text = item2.Media_path;
                            textBlock4.Visibility = Visibility.Collapsed;




                            textBlock2.Text = " " + Convert.ToString(counter) + " Серия";
                            textBlock2.Foreground = new SolidColorBrush(Color.FromRgb(143, 143, 140));
                            textBlock2.FontSize = 14;
                            textBlock2.FontWeight = FontWeights.Normal;
                            textBlock2.Background = new SolidColorBrush(Colors.Transparent);
                            textBlock3.Margin = new Thickness(0, 0, 0, 20);
                            textBlock3.Foreground = new SolidColorBrush(Color.FromRgb(143, 143, 140));
                            textBlock3.FontSize = 14;
                            textBlock3.FontWeight = FontWeights.Normal;
                            textBlock3.Background = new SolidColorBrush(Colors.Transparent);
                            string[] durationsplit = item2.mediaduration.Split(',');
                            if (durationsplit[0] == "1")
                            {
                                textBlock3.Text += "1 hour";
                            }
                            else if (int.Parse(durationsplit[0]) > 1)
                            {
                                textBlock3.Text += $"{durationsplit[0]} hours";
                            }
                            if (int.Parse(durationsplit[1]) == 1)
                            {
                                textBlock3.Text += "1 minute";
                            }
                            else if (int.Parse(durationsplit[1]) > 1)
                            {
                                textBlock3.Text += " " + $"{durationsplit[1]} minutes";
                            }

                            stackPnl2.Children.Add(textBlock2);
                            stackPnl2.Children.Add(textBlock3);
                            stackPnl2.HorizontalAlignment = HorizontalAlignment.Right;
                            stackPnl2.VerticalAlignment = VerticalAlignment.Center;


                            grid1.Width = 500;
                            grid1.Height = 100;
                            grid1.Children.Add(stackPnl1);
                            grid1.Children.Add(stackPnl2);
                            grid1.Children.Add(textBlock4);


                            button.Width = 600;
                            button.Height = 120;
                            button.Background = new SolidColorBrush(Colors.Transparent);
                            button.BorderBrush = new SolidColorBrush(Colors.Transparent);
                            button.Click += Button_Click;
                            button.Content = grid1;
                            border1.Width = 600;
                            border1.Height = 100;
                            border1.Background = new SolidColorBrush(Colors.Transparent);
                            border1.BorderThickness = new Thickness(0, 0.3, 0, 0.3);
                            border1.Margin = new Thickness(0, 0, 0, 1);
                            border1.BorderBrush = new SolidColorBrush(Color.FromRgb(201, 201, 201));
                            border1.CornerRadius = new CornerRadius(10);
                            border1.Child = button;

                            mainChoosePageModel.Add(border1);
                            counter++;
                        }

                    }



                }
                mainChoosePageModels.Add(mainChoosePageModel);
            }

            if (TypeChecker == true)
            {
                for (int i = 1; i < mainChoosePageModels.Count + 1; i++)
                {
                    if (SeasonComboBox.SelectedItem.ToString().Contains(Convert.ToString(i)))
                    {
                        foreach (Border item in mainChoosePageModels[i - 1])
                        {
                            stackPanel.Children.Add(item);
                        }
                    }
                }

                SeasonComboBox.SelectionChanged += SeasonComboBox_SelectionChanged;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Grid grid = (Grid)button.Content;
            TextBlock textBlock = (TextBlock)grid.Children[2];
            StaticsForTheme.media_path_for_last = textBlock.Text;

            Views.BeletVideoPlayer beletVideoPlayer = new BeletVideoPlayer();
            wnd.Close();
            beletVideoPlayer.ShowDialog();
        }

        private void SeasonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            stackPanel.Children.Clear();
            for (int i = 1; i < mainChoosePageModels.Count + 1; i++)
            {
                if (SeasonComboBox.SelectedItem.ToString().Contains(Convert.ToString(i)))
                {
                    foreach (Border item in mainChoosePageModels[i - 1])
                    {
                        stackPanel.Children.Add(item);
                    }
                }
            }
        }
    }


}
