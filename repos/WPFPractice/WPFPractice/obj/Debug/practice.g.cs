﻿#pragma checksum "..\..\practice.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7368ADF9CFC852C826E139C1F88B02C955B5B6E50F21BB208F70CD59E806A8F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using WPFPractice;


namespace WPFPractice {
    
    
    /// <summary>
    /// practice
    /// </summary>
    public partial class practice : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\practice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mybutton;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\practice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button myimp;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\practice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button green_button;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\practice.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button red_button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFPractice;component/practice.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\practice.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mybutton = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.myimp = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\practice.xaml"
            this.myimp.Click += new System.Windows.RoutedEventHandler(this.myimp_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.green_button = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\practice.xaml"
            this.green_button.Click += new System.Windows.RoutedEventHandler(this.green_button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.red_button = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\practice.xaml"
            this.red_button.Click += new System.Windows.RoutedEventHandler(this.red_button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
