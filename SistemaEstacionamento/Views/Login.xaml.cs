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
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            User u = new User
            {
                usuario = usuario.Text,
                senha = senha.Text
            };

            UsuarioDAL usuarioDAL = new UsuarioDAL();

            var cadastroEstada = await usuarioDAL.BuscarPorLogin(u);

            if (cadastroEstada)
            {
                TelaPrincipal c = new TelaPrincipal();
                this.Close();
                c.Show();
            }
            else
            {
                MessageBox.Show("Usuário inexistente no banco de dados!",
                    "WPF Vendas", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}
