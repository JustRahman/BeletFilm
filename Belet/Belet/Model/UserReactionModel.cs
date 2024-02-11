using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace Belet.Model
{
    class UserReactionModel:ViewModelBase
    {
        private int _MediaReactionType;
        public int MediaReactionType
        {
            get
            {
                return _MediaReactionType;
            }
            set
            {
                SetValue(ref _MediaReactionType, value);
            }
        }

        private string _UserReactionType;
        public string UserReactionType
        {
            get
            {
                return _UserReactionType;
            }
            set
            {
                SetValue(ref _UserReactionType, value);
            }
        }

        private int _MediaID;
        public int MediaID
        {
            get
            {
                return _MediaID;
            }
            set
            {
                SetValue(ref _MediaID, value);
            }
        }

        private int _UserId;
        public int UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                SetValue(ref _UserId, value);
            }
        }

        
    }
}
