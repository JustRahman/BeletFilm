using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Belet.ViewModels;
using DevExpress.Mvvm;

namespace Belet.Model
{
    class VideoBeletModel:ViewModelBase
    {
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

        private string _geometry1;
        public string geometry1
        {
            get
            {
                return _geometry1;
            }
            set
            {
                SetValue(ref _geometry1, value);
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

        private string _geometry2;
        public string geometry2
        {
            get
            {
                return _geometry2;
            }
            set
            {
                SetValue(ref _geometry2, value);
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

        private string _geometry3;
        public string geometry3
        {
            get
            {
                return _geometry3;
            }
            set
            {
                SetValue(ref _geometry3, value);
            }
        }

        private string _brush4;
        public string brush4
        {
            get
            {
                return _brush4;
            }
            set
            {
                SetValue(ref _brush4, value);
            }
        }

        private string _geometry4;
        public string geometry4
        {
            get
            {
                return _geometry4;
            }
            set
            {
                SetValue(ref _geometry4, value);
            }
        }

        private string _brush5;
        public string brush5
        {
            get
            {
                return _brush5;
            }
            set
            {
                SetValue(ref _brush5, value);
            }
        }

        private string _geometry5;
        public string geometry5
        {
            get
            {
                return _geometry5;
            }
            set
            {
                SetValue(ref _geometry5, value);
            }
        }

        private string _videophone;
        public string videophone
        {
            get
            {
                return _videophone;
            }
            set
            {
                SetValue(ref _videophone, value);
            }
        }
    }
}
