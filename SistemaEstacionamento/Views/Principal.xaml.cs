using Firebase.Database;
using Firebase.Database.Query;
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

namespace SistemaEstacionamento.Views
{
    /// <summary>
    /// Interaction logic for Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar a janela?",
                "WPF Vendas", MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            CadastroUsuario c = new CadastroUsuario();
            c.ShowDialog();

            GetUser();

            async Task GetUser()
            {
                Console.WriteLine("Cheguei aki");

                var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

                 await firebaseClient
                  .Child("usuarios")
                  .PostAsync(new User());

                var users = await firebaseClient.Child("usuarios").OrderByKey().OnceAsync<User>();

                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Object.Idade}");
                }
            }
        }


        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            //frmCadastrarVenda f =
            //    new frmCadastrarVenda();
            //f.ShowDialog();
        }
    }
}