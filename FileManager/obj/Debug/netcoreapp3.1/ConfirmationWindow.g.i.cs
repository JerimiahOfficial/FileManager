#pragma checksum "..\..\..\ConfirmationWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EB4254973D8412302CF9E346EED4D30C836E4550"
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
    /// ConfirmationWindow
    /// </summary>
    public partial class ConfirmationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 79 "..\..\..\ConfirmationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button No;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\ConfirmationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Yes;
        
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
            System.Uri resourceLocater = new System.Uri("/FileManager;V1.0.0.0;component/confirmationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ConfirmationWindow.xaml"
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
            
            #line 73 "..\..\..\ConfirmationWindow.xaml"
            ((System.Windows.Controls.WrapPanel)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DragControl);
            
            #line default
            #line hidden
            return;
            case 2:
            this.No = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\ConfirmationWindow.xaml"
            this.No.Click += new System.Windows.RoutedEventHandler(this.ButtonHandler);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Yes = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\ConfirmationWindow.xaml"
            this.Yes.Click += new System.Windows.RoutedEventHandler(this.ButtonHandler);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

