using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Belet.Views;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Belet.Model;
using System.Windows.Documents;
using System.Windows.Shapes;
using System.Windows.Data;
using System.Windows.Media;
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
    class BeletVideoPlayerViewModel : ViewModelBase
    {

        #region valuables

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

        private Slider _volumeSlider;
        public Slider volumeSlider
        {
            get
            {
                return _volumeSlider;
            }
            set
            {
                SetValue(ref _volumeSlider, value);
            }

        }

        private Slider _timelineSlider;
        public Slider timelineSlider
        {
            get
            {
                return _timelineSlider;
            }
            set
            {
                SetValue(ref _timelineSlider, value);
            }

        }

        private Slider _speedRatioSlider;
        public Slider speedRatioSlider
        {
            get
            {
                return _speedRatioSlider;
            }
            set
            {
                SetValue(ref _speedRatioSlider, value);
            }

        }

        private MediaElement _MediaPlayer;
        public MediaElement MediaPlayer
        {
            get
            {
                return _MediaPlayer;
            }
            set
            {
                SetValue(ref _MediaPlayer, value);
            }

        }

        #endregion

        public MyDelegateCommand MediaEndedEvent { get; set; }
        public MyDelegateCommand ChangeMediaVolumeEvent1 { get; set; }
        public MyDelegateCommand MediaOpenedEvent { get; set; }
        public MyDelegateCommand ChangeMediaVolumeEvent2 { get; set; }
        public MyDelegateCommand ChangeMediaVolumeEvent3 { get; set; }
        public MyDelegateCommand InitializeCommand { get; set; }
        public DelegateCommand Pausebtn { get; set; }

        public BeletVideoPlayerViewModel()
        {
            filmModel = new BeletFilmModel();
            Pausebtn = new DelegateCommand(()=> Pausebtn_cmd());

            MediaOpenedEvent = new MyDelegateCommand(w => MediaOpenedEvent_cmd(w));
            InitializeCommand = new MyDelegateCommand(w => InitializeCommand_cmd(w));
            MediaEndedEvent = new MyDelegateCommand(w => MediaEndedEventEvent_cmd(w));
            ChangeMediaVolumeEvent1 = new MyDelegateCommand(w => ChangeMediaVolumeEvent1_cmd(w));
            ChangeMediaVolumeEvent2 = new MyDelegateCommand(w => ChangeMediaVolumeEvent2_cmd(w));
            ChangeMediaVolumeEvent3 = new MyDelegateCommand(w => ChangeMediaVolumeEvent3_cmd(w));
          
            filmModel.videomedia = System.AppDomain.CurrentDomain.BaseDirectory + $@"{StaticsForTheme.media_path_for_last}";
            filmModel.brush5 = "Pause";
        }

        private void Pausebtn_cmd()
        {
            if (filmModel.brush5 == "Pause")
            {
                filmModel.brush5 = "Play";
                MediaPlayer.Pause();
            }
            else
            {
                MediaPlayer.Play();
                filmModel.brush5 = "Pause";
            }
        }

        private void MediaOpenedEvent_cmd(object w)
        {
            timelineSlider.Maximum = MediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds;
            MediaPlayer.Play();
        }

        private void ChangeMediaVolumeEvent3_cmd(object w)
        {
            int SliderValue = (int)timelineSlider.Value;
            TimeSpan ts = new TimeSpan(0, 0, SliderValue);
            MediaPlayer.Position = ts;
        }

        private void ChangeMediaVolumeEvent2_cmd(object w)
        {
            MediaPlayer.SpeedRatio = (double)speedRatioSlider.Value;
        }

        private void ChangeMediaVolumeEvent1_cmd(object w)
        {
            MediaPlayer.Volume = (double)volumeSlider.Value;
        }

        private void MediaEndedEventEvent_cmd(object w)
        {
            MediaPlayer.Stop();
        }

        private void InitializeCommand_cmd(object o)
        {
            object[] wind = o as object[];
            wnd = (Window)wind[0];
            MediaPlayer = (MediaElement)wind[1];
            volumeSlider = (Slider)wind[2];
            speedRatioSlider = (Slider)wind[3];
            timelineSlider = (Slider)wind[4];

            MediaPlayer.Play();

            MediaPlayer.Volume = (double)volumeSlider.Value;
            MediaPlayer.SpeedRatio = (double)speedRatioSlider.Value;
        }


    }
}
