﻿#pragma checksum "..\..\..\Views\FlightMapWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4A4108631E6096C7CBF8769C2E22860C"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using Prism.Interactivity;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
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
using TeachingPlatformApp.Controls;
using TeachingPlatformApp.Converters;


namespace TeachingPlatformApp.Views {
    
    
    /// <summary>
    /// FlightMapWindow
    /// </summary>
    public partial class FlightMapWindow : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\Views\FlightMapWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TeachingPlatformApp.Views.FlightMapWindow Window;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\FlightMapWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid fatherGrid;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\FlightMapWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TeachingPlatformApp.Controls.GridAxes gridAxes;
        
        #line default
        #line hidden
        
        
        #line 279 "..\..\..\Views\FlightMapWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TeachingPlatformApp.Controls.NumuricTextBlock xTextBox;
        
        #line default
        #line hidden
        
        
        #line 289 "..\..\..\Views\FlightMapWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TeachingPlatformApp.Controls.NumuricTextBlock yTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/TeachingPlatformApp;component/views/flightmapwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\FlightMapWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.Window = ((TeachingPlatformApp.Views.FlightMapWindow)(target));
            
            #line 13 "..\..\..\Views\FlightMapWindow.xaml"
            this.Window.SizeChanged += new System.Windows.SizeChangedEventHandler(this.Window_SizeChanged);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Views\FlightMapWindow.xaml"
            this.Window.StateChanged += new System.EventHandler(this.Window_StateChanged);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\Views\FlightMapWindow.xaml"
            this.Window.AddHandler(System.Windows.Input.Keyboard.KeyDownEvent, new System.Windows.Input.KeyEventHandler(this.Window_KeyDown));
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\Views\FlightMapWindow.xaml"
            this.Window.AddHandler(System.Windows.Input.Keyboard.KeyUpEvent, new System.Windows.Input.KeyEventHandler(this.Window_KeyUp));
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\Views\FlightMapWindow.xaml"
            this.Window.AddHandler(System.Windows.Input.Mouse.MouseWheelEvent, new System.Windows.Input.MouseWheelEventHandler(this.Window_MouseWheel));
            
            #line default
            #line hidden
            return;
            case 2:
            this.fatherGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.gridAxes = ((TeachingPlatformApp.Controls.GridAxes)(target));
            return;
            case 4:
            this.xTextBox = ((TeachingPlatformApp.Controls.NumuricTextBlock)(target));
            return;
            case 5:
            this.yTextBox = ((TeachingPlatformApp.Controls.NumuricTextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

