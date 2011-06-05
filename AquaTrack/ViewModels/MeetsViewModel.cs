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


namespace AquaTrack
{
    public class MeetsViewModel : INotifyPropertyChanged
    {
        public MeetsViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
            this.Events = new ObservableCollection<ItemViewModel>();
            this.Swimmers = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }
        public ObservableCollection<ItemViewModel> Events { get; private set; }
        public ObservableCollection<ItemViewModel> Swimmers { get; set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
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

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel() { LineOne = "Master's Nationals", LineTwo = "07/05/2011", LineThree = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu" });
            this.Items.Add(new ItemViewModel() { LineOne = "SmokeScreen Invitational", LineTwo = "08/20/2011", LineThree = "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus" });
            this.Items.Add(new ItemViewModel() { LineOne = "Gee Wiz Duel", LineTwo = "09/21/2011", LineThree = "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent" });
            this.Items.Add(new ItemViewModel() { LineOne = "Charity Invitational", LineTwo = "09/25/2011", LineThree = "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos" });

            this.Events.Add(new ItemViewModel() { LineOne = "200 Medley Relay", LineTwo = "3 Swimmers", LineThree = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu" });
            this.Events.Add(new ItemViewModel() { LineOne = "500 Freestyle", LineTwo = "2 Swimmers", LineThree = "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus" });
            this.Events.Add(new ItemViewModel() { LineOne = "100 Freestyle", LineTwo = "3 Swimmers", LineThree = "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent" });
            this.Events.Add(new ItemViewModel() { LineOne = "200 Individual Medley", LineTwo = "1 Swimmers", LineThree = "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos" });
            this.Events.Add(new ItemViewModel() { LineOne = "50 Freestyle", LineTwo = "2 Swimmers", LineThree = "" });
            this.Events.Add(new ItemViewModel() { LineOne = "1000 Freestyle", LineTwo = "2 Swimmers", LineThree = "" });

            this.Swimmers.Add(new ItemViewModel() { LineOne = "Cameron Webb", LineTwo = "", LineThree= ""});
            this.Swimmers.Add(new ItemViewModel() { LineOne = "Nathan Ostlie", LineTwo = "", LineThree = "" });
            this.Swimmers.Add(new ItemViewModel() { LineOne = "Lance Huber", LineTwo = "", LineThree = "" });

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