﻿#pragma checksum "C:\Users\Owner\Source\Repos\SENG403_G6_v2\SENG403_AlarmClock_V3\AlarmNotificationPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C358C7CDDAABEFC1E28AD3D04D245724"
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
    partial class AlarmNotificationPage : 
        global::Windows.UI.Xaml.Controls.Page, 
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
                    this.DismissButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 11 "..\..\..\AlarmNotificationPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DismissButton).Click += this.DismissButton_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.SnoozeButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 12 "..\..\..\AlarmNotificationPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.SnoozeButton).Click += this.SnoozeButton_Click;
                    #line default
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

