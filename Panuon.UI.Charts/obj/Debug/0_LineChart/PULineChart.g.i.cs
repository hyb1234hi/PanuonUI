﻿#pragma checksum "..\..\..\0_LineChart\PULineChart.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BC8AD831D39469D72C683DFA39EB0833F0A841D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Panuon.UI.Charts;
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


namespace Panuon.UI.Charts {
    
    
    /// <summary>
    /// PULineChart
    /// </summary>
    public partial class PULineChart : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\0_LineChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel YAxisCells;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\0_LineChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path gridPath;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\0_LineChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Polyline polyline;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\0_LineChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Polygon polygon;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\0_LineChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas pointCanvas;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\0_LineChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblOriginCell;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\0_LineChart\PULineChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel XAxisCells;
        
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
            System.Uri resourceLocater = new System.Uri("/Panuon.UI.Charts;component/0_linechart/pulinechart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\0_LineChart\PULineChart.xaml"
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
            this.YAxisCells = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.gridPath = ((System.Windows.Shapes.Path)(target));
            return;
            case 3:
            this.polyline = ((System.Windows.Shapes.Polyline)(target));
            return;
            case 4:
            this.polygon = ((System.Windows.Shapes.Polygon)(target));
            return;
            case 5:
            this.pointCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 6:
            this.lblOriginCell = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.XAxisCells = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
