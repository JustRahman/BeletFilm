using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belet.ViewModels;
using DevExpress.Mvvm;

namespace Belet.Model
{
    class MainChoosePageModel:ViewModelBase
    {
        private string _IsBigOrNormal;
        public string IsBigOrNormal
        {
            get
            {
                return _IsBigOrNormal;
            }
            set
            {
                SetValue(ref _IsBigOrNormal, value);
            }
        }

        private string _Media_path;
        public string Media_path
        {
            get
            {
                return _Media_path;
            }
            set
            {
                SetValue(ref _Media_path, value);
            }
        }

        private string _brush1;
        public string brush1
        {
            get
            {
                return _brush1;
            }
            set
            {
                SetValue(ref _brush1, value);
            }
        }

        private string _brush2;
        public string brush2
        {
            get
            {
                return _brush2;
            }
            set
            {
                SetValue(ref _brush2, value);
            }
        }


        private string _brush3;
        public string brush3
        {
            get
            {
                return _brush3;
            }
            set
            {
                SetValue(ref _brush3, value);
            }
        }




        private string _picforbtnninfo;
        public string picforbtnninfo
        {
            get
            {
                return _picforbtnninfo;
            }
            set
            {
                SetValue(ref _picforbtnninfo, value);
            }
        }

        private string _picforbtnninfo1;
        public string picforbtnninfo1
        {
            get
            {
                return _picforbtnninfo1;
            }
            set
            {
                SetValue(ref _picforbtnninfo1, value);
            }
        }

        private string _mediaduration;
        public string mediaduration
        {
            get
            {
                return _mediaduration;
            }
            set
            {
                SetValue(ref _mediaduration, value);
            }
        }


        private string _durationvisibility;
        public string durationvisibility
        {
            get
            {
                return _durationvisibility;
            }
            set
            {
                SetValue(ref _durationvisibility, value);
            }
        }



        private string _txtforbtninfo;
        public string txtforbtninfo
        {
            get
            {
                return _txtforbtninfo;
            }
            set
            {
                SetValue(ref _txtforbtninfo, value);
            }
        }

        private string _tblRbMediaType;
        public string tblRbMediaType
        {
            get
            {
                return _tblRbMediaType;
            }
            set
            {
                SetValue(ref _tblRbMediaType, value);
            }
        }

        private string _txtdescription;
        public string txtdescription
        {
            get
            {
                return _txtdescription;
            }
            set
            {
                SetValue(ref _txtdescription, value);
            }
        }

        private string _tblmediacountry;
        public string tblmediacountry
        {
            get
            {
                return _tblmediacountry;
            }
            set
            {
                SetValue(ref _tblmediacountry, value);
            }
        }

        private string _tblmediacountry2;
        public string tblmediacountry2
        {
            get
            {
                return _tblmediacountry2;
            }
            set
            {
                SetValue(ref _tblmediacountry2, value);
            }
        }



        private string _tblmedialanguage;
        public string tblmedialanguage
        {
            get
            {
                return _tblmedialanguage;
            }
            set
            {
                SetValue(ref _tblmedialanguage, value);
            }
        }

        private string _medialanguage2;
        public string medialanguage2
        {
            get
            {
                return _medialanguage2;
            }
            set
            {
                SetValue(ref _medialanguage2, value);
            }
        }

        private string _tblmediaactors;
        public string tblmediaactors
        {
            get
            {
                return _tblmediaactors;
            }
            set
            {
                SetValue(ref _tblmediaactors, value);
            }
        }

        private string _tblmediaactors2;
        public string tblmediaactors2
        {
            get
            {
                return _tblmediaactors2;
            }
            set
            {
                SetValue(ref _tblmediaactors2, value);
            }
        }

        private string _tblmediadirector;
        public string tblmediadirector
        {
            get
            {
                return _tblmediadirector;
            }
            set
            {
                SetValue(ref _tblmediadirector, value);
            }
        }

        private string _tblmediadirector2;
        public string tblmediadirector2
        {
            get
            {
                return _tblmediadirector2;
            }
            set
            {
                SetValue(ref _tblmediadirector2, value);
            }
        }

        private string _medialanguage;
        public string medialanguage
        {
            get
            {
                return _medialanguage;
            }
            set
            {
                SetValue(ref _medialanguage, value);
            }
        }

        private int _tblmediayear;
        public int tblmediayear
        {
            get
            {
                return _tblmediayear;
            }
            set
            {
                SetValue(ref _tblmediayear, value);
            }
        }

   


        private double _tblfirstrating;
        public double tblfirstrating
        {
            get
            {
                return _tblfirstrating;
            }
            set
            {
                SetValue(ref _tblfirstrating, value);
            }
        }
      
        private string _tblfirstratingbcgr;
        public string tblfirstratingbcgr
        {
            get
            {
                return _tblfirstratingbcgr;
            }
            set
            {
                SetValue(ref _tblfirstratingbcgr, value);
            }
        }


        private string _tblsecondratingbcgr;
        public string tblsecodndtratingbcgr
        {
            get
            {
                return _tblsecondratingbcgr;
            }
            set
            {
                SetValue(ref _tblsecondratingbcgr, value);
            }
        }


        private double _tblmediasecondrating;
        public double tblmediasecondrating
        {
            get
            {
                return _tblmediasecondrating;
            }
            set
            {
                SetValue(ref _tblmediasecondrating, value);
            }
        }

        private int _mediaid;
        public int mediaid
        {
            get
            {
                return _mediaid;
            }
            set
            {
                SetValue(ref _mediaid, value);
            }
        }

        private string _tblmediaseasonquality;
        public string tblmediaseasonquality
        {
            get
            {
                return _tblmediaseasonquality;
            }
            set
            {
                SetValue(ref _tblmediaseasonquality, value);
            }
        }

        private string _seasonvisibility;
        public string seasonvisibility
        {
            get
            {
                return _seasonvisibility;
            }
            set
            {
                SetValue(ref _seasonvisibility, value);
            }
        }



        private string _tblmediaacceptableyear;
        public string tblmediaacceptableyear
        {
            get
            {
                return _tblmediaacceptableyear;
            }
            set
            {
                SetValue(ref _tblmediaacceptableyear, value);
            }
        }

        private string _tblmediagener;
        public string tblmediagener
        {
            get
            {
                return _tblmediagener;
            }
            set
            {
                SetValue(ref _tblmediagener, value);
            }
        }

        private string _tblmediagener2;
        public string tblmediagener2
        {
            get
            {
                return _tblmediagener2;
            }
            set
            {
                SetValue(ref _tblmediagener2, value);
            }
        }
          

    }
}
