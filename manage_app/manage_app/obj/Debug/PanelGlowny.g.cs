﻿#pragma checksum "..\..\PanelGlowny.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A6D5338CD9F59805A343BB42ABC30175E0BF7BF3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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
using manage_app;


namespace manage_app {
    
    
    /// <summary>
    /// PanelGlowny
    /// </summary>
    public partial class PanelGlowny : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\PanelGlowny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnWyloguj;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\PanelGlowny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZamknij;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\PanelGlowny.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
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
            System.Uri resourceLocater = new System.Uri("/manage_app;component/panelglowny.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PanelGlowny.xaml"
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
            this.btnWyloguj = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\PanelGlowny.xaml"
            this.btnWyloguj.Click += new System.Windows.RoutedEventHandler(this.btnWyloguj_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnZamknij = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\PanelGlowny.xaml"
            this.btnZamknij.Click += new System.Windows.RoutedEventHandler(this.btnZamknij_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            case 4:
            
            #line 40 "..\..\PanelGlowny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnSymulacja_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 46 "..\..\PanelGlowny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnProdukcja_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 52 "..\..\PanelGlowny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnMontaz_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 58 "..\..\PanelGlowny.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCzas_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

