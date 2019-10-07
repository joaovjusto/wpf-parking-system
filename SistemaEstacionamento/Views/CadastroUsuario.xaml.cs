using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SistemaEstacionamento.Model;
using SistemaEstacionamento.DAL;

namespace SistemaEstacionamento.Views
{

    public partial class CadastroUsuario : Window
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }
        private void LimparFormulario()
        {
            usuario.Clear();
            senha.Clear();
            idade.Clear();
            nome.Clear();
        }

        private async void BtnCadastrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Cheguei na tela chamei o dal");
            User u = new User
            {
                nome = nome.Text,
                idade = Convert.ToInt32(idade.Text),
                senha = senha.Text,
                usuario = usuario.Text,
                tipo = tipo.Text
            };

            UsuarioDAL userDal = new UsuarioDAL();

            var cadastroUser = await userDal.CadastrarUsuario(u);

            if (cadastroUser)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!",
                    "Sistema de estacionamento", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("Esse Usuário já existe!",
                    "WPF Vendas", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
        private void Usuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
