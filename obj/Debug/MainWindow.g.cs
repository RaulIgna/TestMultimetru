﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "08CB6DA6788B280516DEEFA987F6C7E84F8F118955EDF53CB458792418C0E39C"
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
using TestMultimetru;


namespace TestMultimetru {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ResourceName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ResourceNameTip;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectedAutoRange;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectedRange;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectedNPLC;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox InputAutoImpedance;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox InputNullState;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputNullValue;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NullValueTip;
        
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
            System.Uri resourceLocater = new System.Uri("/TestMultimetru;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.ResourceName = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\MainWindow.xaml"
            this.ResourceName.Initialized += new System.EventHandler(this.ResourceName_OnInitialized);
            
            #line default
            #line hidden
            
            #line 15 "..\..\MainWindow.xaml"
            this.ResourceName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ResourceName_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ResourceNameTip = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.SelectedAutoRange = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\MainWindow.xaml"
            this.SelectedAutoRange.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AutoRange_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SelectedRange = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\MainWindow.xaml"
            this.SelectedRange.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectedIndex_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SelectedNPLC = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.SelectedNPLC.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectedNPLC_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.InputAutoImpedance = ((System.Windows.Controls.CheckBox)(target));
            
            #line 50 "..\..\MainWindow.xaml"
            this.InputAutoImpedance.Checked += new System.Windows.RoutedEventHandler(this.InputAutoImpedance_OnChecked);
            
            #line default
            #line hidden
            
            #line 50 "..\..\MainWindow.xaml"
            this.InputAutoImpedance.Unchecked += new System.Windows.RoutedEventHandler(this.InputAutoImpedance_OnChecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.InputNullState = ((System.Windows.Controls.CheckBox)(target));
            
            #line 51 "..\..\MainWindow.xaml"
            this.InputNullState.Checked += new System.Windows.RoutedEventHandler(this.InputNullState_OnChecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.InputNullValue = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\MainWindow.xaml"
            this.InputNullValue.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.InputNullValue_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.NullValueTip = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            
            #line 59 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Send_OnClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 60 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

