﻿#pragma checksum "E:\coding_and_project\C# for boyan\LifeTracer\LifeTracer\tagChoose.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D85CEDAB5A5FE8EB9408688FAADFEC56"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LifeTracer
{
    partial class tagChoose : 
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
                    this.tagInput = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 19 "..\..\..\tagChoose.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.tagInput).TextChanged += this.tagInput_TextChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.RecentTag = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 20 "..\..\..\tagChoose.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.RecentTag).SelectionChanged += this.RecentTag_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.tag1 = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 4:
                {
                    this.tag2 = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 5:
                {
                    this.tag3 = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6:
                {
                    this.tag4 = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 7:
                {
                    this.tag5 = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
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

