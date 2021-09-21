﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53FAA3457FC400D92EB4CD4AFBC87F8B36ACC4E9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FileManager;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace FileManager {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 239 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TitleBar;
        
        #line default
        #line hidden
        
        
        #line 242 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseApplication;
        
        #line default
        #line hidden
        
        
        #line 243 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WinState;
        
        #line default
        #line hidden
        
        
        #line 244 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Minimize;
        
        #line default
        #line hidden
        
        
        #line 249 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenDirectory;
        
        #line default
        #line hidden
        
        
        #line 256 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FolderDirectory;
        
        #line default
        #line hidden
        
        
        #line 260 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenTools;
        
        #line default
        #line hidden
        
        
        #line 267 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer Content;
        
        #line default
        #line hidden
        
        
        #line 268 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel FilesContainer;
        
        #line default
        #line hidden
        
        
        #line 271 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel ActionsContainer;
        
        #line default
        #line hidden
        
        
        #line 272 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RenameAll;
        
        #line default
        #line hidden
        
        
        #line 273 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteAll;
        
        #line default
        #line hidden
        
        
        #line 274 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteDup;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FileManager;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TitleBar = ((System.Windows.Controls.Grid)(target));
            
            #line 239 "..\..\..\MainWindow.xaml"
            this.TitleBar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DragControl);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CloseApplication = ((System.Windows.Controls.Button)(target));
            
            #line 242 "..\..\..\MainWindow.xaml"
            this.CloseApplication.Click += new System.Windows.RoutedEventHandler(this.ButtonHandler);
            
            #line default
            #line hidden
            return;
            case 3:
            this.WinState = ((System.Windows.Controls.Button)(target));
            
            #line 243 "..\..\..\MainWindow.xaml"
            this.WinState.Click += new System.Windows.RoutedEventHandler(this.ButtonHandler);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Minimize = ((System.Windows.Controls.Button)(target));
            
            #line 244 "..\..\..\MainWindow.xaml"
            this.Minimize.Click += new System.Windows.RoutedEventHandler(this.ButtonHandler);
            
            #line default
            #line hidden
            return;
            case 5:
            this.OpenDirectory = ((System.Windows.Controls.Button)(target));
            
            #line 249 "..\..\..\MainWindow.xaml"
            this.OpenDirectory.Click += new System.Windows.RoutedEventHandler(this.ButtonHandler);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FolderDirectory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.OpenTools = ((System.Windows.Controls.Button)(target));
            
            #line 260 "..\..\..\MainWindow.xaml"
            this.OpenTools.Click += new System.Windows.RoutedEventHandler(this.ButtonHandler);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Content = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 9:
            this.FilesContainer = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 10:
            this.ActionsContainer = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 11:
            this.RenameAll = ((System.Windows.Controls.Button)(target));
            
            #line 272 "..\..\..\MainWindow.xaml"
            this.RenameAll.Click += new System.Windows.RoutedEventHandler(this.ButtonHandler);
            
            #line default
            #line hidden
            return;
            case 12:
            this.DeleteAll = ((System.Windows.Controls.Button)(target));
            
            #line 273 "..\..\..\MainWindow.xaml"
            this.DeleteAll.Click += new System.Windows.RoutedEventHandler(this.ButtonHandler);
            
            #line default
            #line hidden
            return;
            case 13:
            this.DeleteDup = ((System.Windows.Controls.Button)(target));
            
            #line 274 "..\..\..\MainWindow.xaml"
            this.DeleteDup.Click += new System.Windows.RoutedEventHandler(this.ButtonHandler);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

