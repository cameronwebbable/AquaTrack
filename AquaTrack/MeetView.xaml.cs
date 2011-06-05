using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace AquaTrack
{
    public partial class MeetView : PhoneApplicationPage
    {
        string meetName;
        public MeetView()
        {
            InitializeComponent();
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MeetView_Loaded);
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            meetName = NavigationContext.QueryString["selection"];
            PageTitle.Text = meetName;
        }
        private void MeetView_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }
        private void eventView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = (sender as ListBox).SelectedIndex;

            if (selectedIndex != -1)
            {
                string meetName = App.ViewModel.Events[selectedIndex].LineOne;

                NavigationService.Navigate(new Uri("/TimerView.xaml?selection=" + meetName, UriKind.Relative));
                (sender as ListBox).SelectedIndex = -1;
            }
        }
    }
}
