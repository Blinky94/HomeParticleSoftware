﻿#pragma checksum "..\..\MinMaxRGBColorControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A4C45EE42DF7FE8990C2E545D0C3CFADB71D9D89BC67DDA02A460628B32E16BA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HomeParticlesSoftware;
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


namespace HomeParticlesSoftware {
    
    
    /// <summary>
    /// MinMaxRGBColorControl
    /// </summary>
    public partial class MinMaxRGBColorControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\MinMaxRGBColorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MainTitleBLock;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MinMaxRGBColorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle RectangleRGBColor;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\MinMaxRGBColorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderRColor;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\MinMaxRGBColorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderGColor;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\MinMaxRGBColorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SliderBColor;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\MinMaxRGBColorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxRColor;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\MinMaxRGBColorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxGColor;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\MinMaxRGBColorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxBColor;
        
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
            System.Uri resourceLocater = new System.Uri("/HomeParticlesSoftware;component/minmaxrgbcolorcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MinMaxRGBColorControl.xaml"
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
            this.MainTitleBLock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.RectangleRGBColor = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.SliderRColor = ((System.Windows.Controls.Slider)(target));
            return;
            case 4:
            this.SliderGColor = ((System.Windows.Controls.Slider)(target));
            return;
            case 5:
            this.SliderBColor = ((System.Windows.Controls.Slider)(target));
            return;
            case 6:
            this.TextBoxRColor = ((System.Windows.Controls.TextBox)(target));
            
            #line 121 "..\..\MinMaxRGBColorControl.xaml"
            this.TextBoxRColor.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxRColor_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TextBoxGColor = ((System.Windows.Controls.TextBox)(target));
            
            #line 132 "..\..\MinMaxRGBColorControl.xaml"
            this.TextBoxGColor.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxGColor_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TextBoxBColor = ((System.Windows.Controls.TextBox)(target));
            
            #line 144 "..\..\MinMaxRGBColorControl.xaml"
            this.TextBoxBColor.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxBColor_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

