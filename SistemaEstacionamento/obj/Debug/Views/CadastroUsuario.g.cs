﻿#pragma checksum "..\..\..\Views\CadastroUsuario.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "78887D91F3F8445F910A6F54E4D70FA50C9C32B2B82DD94A5710BD6DB9984F63"
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
    /// CadastroUsuario
    /// </summary>
    public partial class CadastroUsuario : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\CadastroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nome;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\CadastroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox senha;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\CadastroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCadastrarUsuario;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\CadastroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usuario;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Views\CadastroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idade;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Views\CadastroUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tipo;
        
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
            System.Uri resourceLocater = new System.Uri("/SistemaEstacionamento;component/views/cadastrousuario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CadastroUsuario.xaml"
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
            this.nome = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\Views\CadastroUsuario.xaml"
            this.nome.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Usuario_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.senha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnCadastrarUsuario = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Views\CadastroUsuario.xaml"
            this.btnCadastrarUsuario.Click += new System.Windows.RoutedEventHandler(this.BtnCadastrarUsuario_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.usuario = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.idade = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tipo = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

