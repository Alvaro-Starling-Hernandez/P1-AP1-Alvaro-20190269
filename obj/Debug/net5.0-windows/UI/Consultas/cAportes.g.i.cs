﻿#pragma checksum "..\..\..\..\..\UI\Consultas\cAportes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C70C07E43D3324507AB7A667FDBA2AB51E089659"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using P1_AP1_Alvaro_20190269.UI.Consultas;
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


namespace P1_AP1_Alvaro_20190269.UI.Consultas {
    
    
    /// <summary>
    /// cAportes
    /// </summary>
    public partial class cAportes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\..\UI\Consultas\cAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Desde_DataPicker;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\UI\Consultas\cAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Filtro_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\UI\Consultas\cAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Hasta_DatePicker;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\UI\Consultas\cAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Criterio_TextBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\UI\Consultas\cAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Buscar_Button;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\UI\Consultas\cAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DatosDataGrid;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\UI\Consultas\cAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ConteoTextBox;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\UI\Consultas\cAportes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/P1-AP1-Alvaro-20190269;component/ui/consultas/caportes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Consultas\cAportes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Desde_DataPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.Filtro_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Hasta_DatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.Criterio_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Buscar_Button = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\..\UI\Consultas\cAportes.xaml"
            this.Buscar_Button.Click += new System.Windows.RoutedEventHandler(this.Buscar_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DatosDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.ConteoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TotalTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

