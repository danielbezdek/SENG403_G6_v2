﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SENG403_AlarmClock_V2
{
    /// <summary>
    /// Interaction logic for NewAlarmWindow.xaml
    /// </summary>
    public partial class NewAlarmWindow : Window
    {
        private List<String> alarmSounds = new List<string>();
        AlarmUserControl alarmControl;
        public NewAlarmWindow(AlarmUserControl alarmControl)
        {
            InitializeComponent();
            RadioGrid.Visibility = Visibility.Collapsed;
            OtherProps.Margin = new Thickness(26, 149, 21, 34);
            this.alarmControl = alarmControl;
            alarmSounds.Add(@"C:\Users\tcai\Documents\Visual Studio 2015\Projects\SENG403_G6_v2\SENG403_AlarmClock_V2\Sounds\missileAlert.wav");
            alarmSounds.Add(@"C:\Users\tcai\Documents\Visual Studio 2015\Projects\SENG403_G6_v2\SENG403_AlarmClock_V2\Sounds\fogHorn.wav");
            alarmSounds.Add("pack://application:,,,/Sounds/missileAlert.wav");
            alarmSounds.Add("pack://application:,,,/Sounds/fogHorn.wav");
            AlarmTone_comboBox.ItemsSource = alarmSounds;
            AlarmTone_comboBox.SelectedIndex = 0;

        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            DateTime alarmTime;
            DateTime.TryParse(Alarm_TimePicker.Text, out alarmTime);
            if ((bool)radioButton_Daily.IsChecked)
                alarmControl.alarm = Alarm.createDailyAlarm(alarmTime, 1.0);
            else
                alarmControl.alarm = new Alarm(alarmTime, -1, 1.0);
            alarmControl.setTimeLabel(alarmTime);
            alarmControl.alarm.SetSound((String)AlarmTone_comboBox.SelectedValue);
            if (!AlarmMessage.Text.Equals("Set Alarm Label")) alarmControl.alarm.SetLabel(AlarmMessage.Text);
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void radioButton_Thu_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void repeat_checkBox_Checked(object sender, RoutedEventArgs e)
        {
            RadioGrid.Visibility = Visibility.Visible;
            OtherProps.Margin = new Thickness(26, 230, 21, 34);
        }

        private void Checkbox_Unchecked(object sender, RoutedEventArgs e)
        {

            RadioGrid.Visibility = Visibility.Collapsed;
            OtherProps.Margin = new Thickness(26, 149, 21, 34);
        }
    }
}
