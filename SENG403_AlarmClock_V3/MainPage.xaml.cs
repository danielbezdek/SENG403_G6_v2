﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SENG403_AlarmClock_V3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void PhoneAddAlarmButton_Click(object sender, RoutedEventArgs e)
        {
            
            TimeDateGrid.Margin = new Thickness(40, 90, 58, 420);
            AlarmUserControl alarmControl = new AlarmUserControl(AlarmList_Panel);
            AlarmList_Panel.Children.Add(alarmControl);
        }

        private void PhoneAlarmSideBarButton_Click(object sender, RoutedEventArgs e)
        {
            if(AlarmList_Panel.Visibility ==  Visibility.Visible)
            {
                TimeDateGrid.Margin = new Thickness(40, 208, 58, 300);
                AlarmList_Panel.Visibility = Visibility.Collapsed;
            }
            else if(AlarmList_Panel.Visibility == Visibility.Collapsed)
            {
                TimeDateGrid.Margin = new Thickness(40, 90, 58, 420);
                AlarmList_Panel.Visibility = Visibility.Visible;
            }
        }
    }
}
