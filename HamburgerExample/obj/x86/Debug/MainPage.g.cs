﻿#pragma checksum "C:\Users\parlinr\Desktop\xaml-practice\HamburgerExample\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "99E9423F944A73A119441E3E82DC32D8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HamburgerExample
{
    partial class MainPage : 
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
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.IconsListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 53 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.IconsListBox).SelectionChanged += this.IconsListBox_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.ShareListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 4:
                {
                    this.FavoritesListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 5:
                {
                    this.ResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 33 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackButton).Click += this.BackButton_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.PageTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.SearchButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 9:
                {
                    this.SearchTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 22 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
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

