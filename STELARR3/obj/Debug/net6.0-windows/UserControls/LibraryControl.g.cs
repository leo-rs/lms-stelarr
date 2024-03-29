﻿#pragma checksum "..\..\..\..\UserControls\LibraryControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46A551596A980C1872798937F9CB500892B432AA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using STELARR3.UserControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace STELARR3.UserControls {
    
    
    /// <summary>
    /// LibraryControl
    /// </summary>
    public partial class LibraryControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\UserControls\LibraryControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadNumbers;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\UserControls\LibraryControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadMath;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\UserControls\LibraryControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadLetters;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\UserControls\LibraryControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviousPage;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\UserControls\LibraryControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextPage;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\UserControls\LibraryControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Content;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\UserControls\LibraryControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Print;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/STELARR3;component/usercontrols/librarycontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UserControls\LibraryControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LoadNumbers = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\UserControls\LibraryControl.xaml"
            this.LoadNumbers.Click += new System.Windows.RoutedEventHandler(this.LoadNumbers_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LoadMath = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\UserControls\LibraryControl.xaml"
            this.LoadMath.Click += new System.Windows.RoutedEventHandler(this.LoadMath_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LoadLetters = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\UserControls\LibraryControl.xaml"
            this.LoadLetters.Click += new System.Windows.RoutedEventHandler(this.LoadLetters_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PreviousPage = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\UserControls\LibraryControl.xaml"
            this.PreviousPage.Click += new System.Windows.RoutedEventHandler(this.PreviousPage_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NextPage = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\UserControls\LibraryControl.xaml"
            this.NextPage.Click += new System.Windows.RoutedEventHandler(this.NextPage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Content = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.Print = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\UserControls\LibraryControl.xaml"
            this.Print.Click += new System.Windows.RoutedEventHandler(this.Print_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

