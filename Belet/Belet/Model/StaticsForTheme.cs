using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Belet.Model
{
    class StaticsForTheme
    {
        public static string mediaid { get; set; }
        public static int UserLogid { get; set; }

        public static int MoveIdLike { get; set; }
        public static int MoveIdSave { get; set; }
        public static int MoveIdNoSave { get; set; }
        public static int MoveIdNoLike { get; set; }
        public static int MediaReactionTypeLike { get; set; }
        public static int MediaReactionTypeSave { get; set; }

        public static List<int> MoveIdLike2 { get; set; }
        public static List<int> MoveIdSave2 { get; set; }
        public static List<int> MoveIdNoSave2 { get; set; }
        public static List<int> MoveIdNoLike2 { get; set; }
        public static List<int> MediaReactionTypeLike2 { get; set; }
        public static List<int> MediaReactionTypeSave2 { get; set; }
        public static  ObservableCollection<ObservableCollection<MainChoosePageModel>> GeneralMainChoosePageModels { get; set; }
        public static  ObservableCollection<ObservableCollection<MainChoosePageModel>> StaticModelMediaContainer { get; set; }

        public static byte[] myRijndaelKey { get; set; }
        public static byte[] myRijndaelIV { get; set; }


        public static ObservableCollection<UserReactionModel> UserMediaReactions { get; set; }


        public static bool IsBtnChecked { get; set; }       
        public static string picforbtnninfo { get; set; }  
        public static string txtforbtninfo { get; set; }
        public static ObservableCollection<string> mediacountry { get; set; }
        public static ObservableCollection<string> medialanguage { get; set; }
        public static ObservableCollection<string> mediaactors { get; set; }
        public static string mediaacceptableyear { get; set; }
        public static ObservableCollection<string> mediadirector { get; set; }
        public static ObservableCollection<string> mediagener { get; set; }
        static List<MainChoosePageModel> mainChoosePageModel { get; set; }
        public static string TblRbMediaType { get; set; }
        public static string txtdescription { get; set; }
        public static int counter { get; set; }
        public static int year { get; set; }
        public static int PersonId { get; set; }
        public static string Media_path{ get; set; }
        public static string media_path_for_last{ get; set; }
        public static int firstrating { get; set; }
        public static int secondrating { get; set; }
        public static int seasonquantity { get; set; }
        public static int mediaduration { get; set; }

        public static string PersonPhoneNumber { get; set; }

        public StaticsForTheme()
        {
            
            StaticsForTheme.counter = 0;
            StaticsForTheme.GeneralMainChoosePageModels = new ObservableCollection<ObservableCollection<MainChoosePageModel>>();
            StaticsForTheme.UserMediaReactions = new ObservableCollection<UserReactionModel>();
            //mainChoosePageModel = new List<MainChoosePageModel>();
            //mediacountry = new ObservableCollection<string>();
            //mediadirector = new ObservableCollection<string>();
            //medialanguage = new ObservableCollection<string>();
            //mediagener = new ObservableCollection<string>();
        }
        
    }
    
}
