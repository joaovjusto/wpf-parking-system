﻿#pragma checksum "..\..\..\Views\CadastroEstada.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7333C3B06E2662AB2445BE47A8E6220DEB4447AB5FCC46ED3DCC847CCEACC4FF"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using SistemaEstacionamento.Views;
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


namespace SistemaEstacionamento.Views {
    
    
    /// <summary>
    /// CadastroEstada
    /// </summary>
    public partial class CadastroEstada : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\CadastroEstada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tipo;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Views\CadastroEstada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker entrada;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\CadastroEstada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCadastrarEstada;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\CadastroEstada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker saida;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\CadastroEstada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usuario;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\CadastroEstada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox vaga;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\CadastroEstada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox area;
        
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
            System.Uri resourceLocater = new System.Uri("/SistemaEstacionamento;component/views/cadastroestada.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CadastroEstada.xaml"
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
            this.tipo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\..\Views\CadastroEstada.xaml"
            this.tipo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.entrada = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.btnCadastrarEstada = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Views\CadastroEstada.xaml"
            this.btnCadastrarEstada.Click += new System.Windows.RoutedEventHandler(this.BtnCadastrarEstada_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.saida = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.usuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.vaga = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.area = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

