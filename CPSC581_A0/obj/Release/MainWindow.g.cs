﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B7E6B3F05F067768F3E06ECFFFD21376"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CPSC581_A0;
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


namespace CPSC581_A0 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 458 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 462 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image buttonBottom;
        
        #line default
        #line hidden
        
        
        #line 463 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image buttonTop;
        
        #line default
        #line hidden
        
        
        #line 473 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas ButtonLines;
        
        #line default
        #line hidden
        
        
        #line 474 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path path;
        
        #line default
        #line hidden
        
        
        #line 484 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path path1;
        
        #line default
        #line hidden
        
        
        #line 494 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path path2;
        
        #line default
        #line hidden
        
        
        #line 504 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path path3;
        
        #line default
        #line hidden
        
        
        #line 514 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path path4;
        
        #line default
        #line hidden
        
        
        #line 524 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path path5;
        
        #line default
        #line hidden
        
        
        #line 534 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path path6;
        
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
            System.Uri resourceLocater = new System.Uri("/CPSC581_A0;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 458 "..\..\MainWindow.xaml"
            this.MainGrid.MouseMove += new System.Windows.Input.MouseEventHandler(this.OnMouseMovement);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonBottom = ((System.Windows.Controls.Image)(target));
            
            #line 462 "..\..\MainWindow.xaml"
            this.buttonBottom.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_MouseDown);
            
            #line default
            #line hidden
            
            #line 462 "..\..\MainWindow.xaml"
            this.buttonBottom.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Button_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonTop = ((System.Windows.Controls.Image)(target));
            
            #line 463 "..\..\MainWindow.xaml"
            this.buttonTop.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Button_MouseDown);
            
            #line default
            #line hidden
            
            #line 463 "..\..\MainWindow.xaml"
            this.buttonTop.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Button_MouseUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonLines = ((System.Windows.Controls.Canvas)(target));
            return;
            case 5:
            this.path = ((System.Windows.Shapes.Path)(target));
            return;
            case 6:
            this.path1 = ((System.Windows.Shapes.Path)(target));
            return;
            case 7:
            this.path2 = ((System.Windows.Shapes.Path)(target));
            return;
            case 8:
            this.path3 = ((System.Windows.Shapes.Path)(target));
            return;
            case 9:
            this.path4 = ((System.Windows.Shapes.Path)(target));
            return;
            case 10:
            this.path5 = ((System.Windows.Shapes.Path)(target));
            return;
            case 11:
            this.path6 = ((System.Windows.Shapes.Path)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
