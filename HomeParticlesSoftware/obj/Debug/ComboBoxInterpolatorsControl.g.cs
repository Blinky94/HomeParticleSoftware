﻿#pragma checksum "..\..\ComboBoxInterpolatorsControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CAB5BEA85A2D283DD4A0F2120099F6145C4819F034A226285A6B81682BB42585"
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
    /// ComboBoxInterpolatorsControl
    /// </summary>
    public partial class ComboBoxInterpolatorsControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\ComboBoxInterpolatorsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ComboBoxInterpolatorsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ComboBoxInterpolatorsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem ColorInterpolator;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ComboBoxInterpolatorsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem HueInterpolator;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ComboBoxInterpolatorsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem OpacityInterpolator;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ComboBoxInterpolatorsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem RotationInterpolator;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ComboBoxInterpolatorsControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem ScaleInterpolator;
        
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
            System.Uri resourceLocater = new System.Uri("/HomeParticlesSoftware;component/comboboxinterpolatorscontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ComboBoxInterpolatorsControl.xaml"
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
            this.Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.ComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ColorInterpolator = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 26 "..\..\ComboBoxInterpolatorsControl.xaml"
            this.ColorInterpolator.Selected += new System.Windows.RoutedEventHandler(this.ColorInterpolator_Selected);
            
            #line default
            #line hidden
            return;
            case 4:
            this.HueInterpolator = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 27 "..\..\ComboBoxInterpolatorsControl.xaml"
            this.HueInterpolator.Selected += new System.Windows.RoutedEventHandler(this.HueInterpolator_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.OpacityInterpolator = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 28 "..\..\ComboBoxInterpolatorsControl.xaml"
            this.OpacityInterpolator.Selected += new System.Windows.RoutedEventHandler(this.OpacityInterpolator_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RotationInterpolator = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 29 "..\..\ComboBoxInterpolatorsControl.xaml"
            this.RotationInterpolator.Selected += new System.Windows.RoutedEventHandler(this.RotationInterpolator_Selected);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ScaleInterpolator = ((System.Windows.Controls.ComboBoxItem)(target));
            
            #line 30 "..\..\ComboBoxInterpolatorsControl.xaml"
            this.ScaleInterpolator.Selected += new System.Windows.RoutedEventHandler(this.ScaleInterpolator_Selected);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

