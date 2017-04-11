﻿

using System;
using System.Media;
using System.Threading;
using System.Windows.Media;
using System.Windows.Threading;

namespace SENG403_AlarmClock_V2
{
    [Serializable]
    public class Alarm
    {
        private const string defaultSoundFile = @"C:\Users\tcai\Documents\Visual Studio 2015\Projects\SENG403_G6_v2\SENG403_AlarmClock_V2\Sounds\missileAlert.wav";

        //instance variables
        public DateTime defaultAlarmTime { get; set; } //default time (for repeated alarms)

        public DateTime notifyTime { get; set; } //when the alarm should go off after being snoozed
        public double snoozeTime { get; set; }
        SoundPlayer alarmSound = new SoundPlayer(defaultSoundFile);
        public bool enabled { get; set; }
        public bool alreadyRung { get; set; }

        public int repeatIntervalDays { get; set; } //how many days before alarm goes off
        public string label { get; set; }

        public static Alarm createDailyAlarm(DateTime alarmTime, double snoozeTime)
        {
            TimeSpan ts = new TimeSpan(alarmTime.Hour, alarmTime.Minute, alarmTime.Second);
            DateTime dt = DateTime.Today.Add(ts);
            Console.WriteLine(dt);
            return new Alarm(dt, 1, snoozeTime);
        }

        public Alarm(DateTime alarmTime, int repeatInterval, double snoozeTime)
        {
            defaultAlarmTime = notifyTime = alarmTime;
            this.repeatIntervalDays = repeatInterval;
            this.snoozeTime = snoozeTime;
        }

        /// <summary>
        /// Alarm class constructor, takes in path filename for sound file
        /// </summary>
        /// <param name="alarmFile"></param>
        public Alarm(string alarmFile, double snoozeTime)
        {
            alarmSound.SoundLocation = alarmFile;
            this.snoozeTime = snoozeTime;
        }

        internal void setDailyAlarm(DateTime alarmTime)
        {
            enabled = false;
            repeatIntervalDays = 1;
            TimeSpan ts = new TimeSpan(alarmTime.Hour, alarmTime.Minute, alarmTime.Second);
            defaultAlarmTime = MainWindow.currentTime.Date.Add(ts);
            if (defaultAlarmTime.CompareTo(MainWindow.currentTime) <= 0)
                defaultAlarmTime = defaultAlarmTime.AddDays(repeatIntervalDays);
            notifyTime = defaultAlarmTime;
            Console.WriteLine(notifyTime);
        }

        public void SetLabel(string label)
        {
            this.label = label;
        }

        public string GetLabel()
        {
            return label;
        }
        public Boolean getStatus()
        {
            return enabled;
        }

        /// <summary>
        /// Stops playing SoundPlayer file for alarm
        /// </summary>
        public void stop()
        {
            alarmSound.Stop();
        }

        public void snooze()
        {
            notifyTime = MainWindow.currentTime.AddMinutes(snoozeTime);
            stop();
        }

        /// <summary>
        /// Set time for alarm instance
        /// </summary>
        /// <param name="newTime"></param>
        public void SetTime(DateTime newTime)
        {
            defaultAlarmTime = newTime;
        }

        /// <summary>
        /// Set time interval for alarm snooze in minutes
        /// </summary>
        /// <param name="snoozeMinutes"></param>
        public void setSnooze(double snoozeMinutes)
        {
            snoozeTime = snoozeMinutes;
        }

        /// <summary>
        /// Snooze an existing alarm by adding minutes until next alarm time
        /// </summary>
        /// <param name="currentTime"></param>
        public void Snooze(DateTime currentTime)
        {
            defaultAlarmTime = currentTime.AddMinutes(snoozeTime);
        }

        /// <summary>
        /// Sets the sound for the alarm
        /// </summary>
        /// <returns></returns>
        public void SetSound(String newSound)
        {
            Console.WriteLine(newSound);
            alarmSound.SoundLocation = newSound;
        }

        public override string ToString()
        {
            return "Default Alarm Time: " + defaultAlarmTime + " Snooze Time: " + snoozeTime +
                " Repeat Interval: " + repeatIntervalDays;
        }

        internal void setWeeklyAlarm(DayOfWeek day, DateTime alarmTime)
        {
            enabled = true;
            repeatIntervalDays = 7;
            TimeSpan ts = new TimeSpan(alarmTime.Hour, alarmTime.Minute, alarmTime.Second);
            defaultAlarmTime = DateTime.Today.AddDays(day - DateTime.Now.DayOfWeek).Add(ts);
            if (defaultAlarmTime.CompareTo(DateTime.Now) <= 0)
                defaultAlarmTime = defaultAlarmTime.AddDays(repeatIntervalDays);
            notifyTime = defaultAlarmTime;
        }

        public void update()
        {
            alarmSound.Stop();
            if (repeatIntervalDays != -1)
            {
                defaultAlarmTime = MainWindow.currentTime.AddDays(repeatIntervalDays);
                notifyTime = defaultAlarmTime;
                Console.WriteLine(defaultAlarmTime);
                Console.WriteLine(repeatIntervalDays);
            }
            else
            {
                enabled = false;
            }
        }
    }
}