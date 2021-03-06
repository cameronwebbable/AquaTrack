﻿using System;
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
    public partial class MenuPage : PhoneApplicationPage
    {
        public MenuPage()
        {
            InitializeComponent();
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MenuPage_Loaded);
        }

        private void MenuPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void meetList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = (sender as ListBox).SelectedIndex;

            if (selectedIndex != -1)
            {
                string meetName = App.ViewModel.Items[selectedIndex].LineOne;

                NavigationService.Navigate(new Uri("/MeetView.xaml?selection=" + meetName, UriKind.Relative));
                (sender as ListBox).SelectedIndex = -1;
            }
        }
    }
}
