﻿#pragma checksum "C:\Users\tcai\Documents\Visual Studio 2015\Projects\AlarmMobileApp\SENG403_AlarmClock_V3\AlarmUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F76C0FEEF0EECB364CB71590515E809C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SENG403_AlarmClock_V3
{
    partial class AlarmUserControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.bg = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.AlarmEnabledToggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 17 "..\..\..\AlarmUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.AlarmEnabledToggle).Toggled += this.AlarmEnableToggled;
                    #line default
                }
                break;
            case 3:
                {
                    this.AlarmTypeLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.AlarmTimeLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.EditAlarm_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\AlarmUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.EditAlarm_Button).Click += this.EditAlarm_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.SnoozeAlarmButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\AlarmUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SnoozeAlarmButton).Click += this.SnoozeAlarmButtonClick;
                    #line default
                }
                break;
            case 7:
                {
                    this.DeleteAlarm_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\AlarmUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DeleteAlarm_Button).Click += this.DeleteAlarm_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.DismissAlarmButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\AlarmUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DismissAlarmButton).Click += this.DismissAlarmButtonClick;
                    #line default
                }
                break;
            case 9:
                {
                    this.AlarmLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.WarningMessage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.DeleteButtonImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

