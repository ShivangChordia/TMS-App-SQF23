﻿#pragma checksum "..\..\..\AdminPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A0832D8DA9AF60C03676FEF859C60203947FDCE1"
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
using TMS_Front_nd;


namespace TMS_Front_nd {
    
    
    /// <summary>
    /// AdminPage
    /// </summary>
    public partial class AdminPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LogFileDirectoryTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PrintLogFilesButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid LogFileGrid;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReviewLogFilesButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveLogFilesButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid carrierDataGrid;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveCarrierDataButton;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RouteDataGrid;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageRouteTableButton;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BackupDirectoryTextBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InitiateBackupButton;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\AdminPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RefreshButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TMS_FRONT_END;component/adminpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LogFileDirectoryTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PrintLogFilesButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\AdminPage.xaml"
            this.PrintLogFilesButton.Click += new System.Windows.RoutedEventHandler(this.PrintLogFilesButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LogFileGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.ReviewLogFilesButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\AdminPage.xaml"
            this.ReviewLogFilesButton.Click += new System.Windows.RoutedEventHandler(this.ReviewLogFilesButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RemoveLogFilesButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\AdminPage.xaml"
            this.RemoveLogFilesButton.Click += new System.Windows.RoutedEventHandler(this.RemoveLogFilesButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.carrierDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.SaveCarrierDataButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\AdminPage.xaml"
            this.SaveCarrierDataButton.Click += new System.Windows.RoutedEventHandler(this.SaveCarrierDataButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RouteDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.ManageRouteTableButton = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\AdminPage.xaml"
            this.ManageRouteTableButton.Click += new System.Windows.RoutedEventHandler(this.ManageRouteTableButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BackupDirectoryTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.InitiateBackupButton = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\AdminPage.xaml"
            this.InitiateBackupButton.Click += new System.Windows.RoutedEventHandler(this.BackupButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.RefreshButton = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\AdminPage.xaml"
            this.RefreshButton.Click += new System.Windows.RoutedEventHandler(this.RefreshButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

