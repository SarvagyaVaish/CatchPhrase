using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace Catch_Phrase
{
    public class MainViewModel : INotifyPropertyChanged
    {

        // constructor
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
            Phrase = "";
            ScoreTeamA = 0;
            ScoreTeamB = 0;
            Timer = 0;
            DefaultTimerValue = 30;
        }

        /*
        static readonly object padlock = new object();
        private static MainViewModel instance = null;
        public static MainViewModel Instance
        {
            get 
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MainViewModel();
                    }
                    return instance;
                }
            }
        }
        */


        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }



        private string _phrase = "";
        public string Phrase
        {
            get
            {
                return _phrase;
            }
            set
            {
                if (value != _phrase)
                {
                    _phrase = value;
                    NotifyPropertyChanged("Phrase");
                }
            }
        }



        private int _timer = 0;
        public int Timer
        {
            get
            {
                return _timer;
            }
            set
            {
                if (value != _timer)
                {
                    _timer = value;
                    NotifyPropertyChanged("Timer");
                }
            }
        }



        private int _defaultTimerValue = 45;
        public int DefaultTimerValue
        {
            get
            {
                return _defaultTimerValue;
            }
            set
            {
                if (value != _defaultTimerValue)
                {
                    _defaultTimerValue = value;
                    NotifyPropertyChanged("DefaultTimerValue");
                }
            }
        }



        private int _scoreTeamA = 0;
        public int ScoreTeamA
        {
            get
            {
                return _scoreTeamA;
            }
            set
            {
                if (value != _scoreTeamA)
                {
                    _scoreTeamA = value;
                    NotifyPropertyChanged("ScoreTeamA");
                }
            }
        }



        private int _scoreTeamB = 0;
        public int ScoreTeamB
        {
            get
            {
                return _scoreTeamB;
            }
            set
            {
                if (value != _scoreTeamB)
                {
                    _scoreTeamB = value;
                    NotifyPropertyChanged("ScoreTeamB");
                }
            }
        }



        public bool IsDataLoaded
        {
            get;
            private set;
        }

        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel() { LineOne = "runtime one", LineTwo = "Maecenas praesent accumsan bibendum", LineThree = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime two", LineTwo = "Dictumst eleifend facilisi faucibus", LineThree = "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus" });
            
            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}