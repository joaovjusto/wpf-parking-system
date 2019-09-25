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
    /// Interaction logic for TelaPrincipal.xaml
    /// </summary>
    public partial class TelaPrincipal : Window
    {
        public TelaPrincipal()
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

                var user1 = new User
                {
                    nome = "João Justo",
                    idade = 20,
                    senha = "DASDAs34234fedf234",
                    usuario = "jvjusto"
                };

                //await firebaseClient
                // .Child("usuarios")
                //.PostAsync(user1);

                // await firebaseClient
                //.Child("usuarios")
                //.DeleteAsync();

                //var users = await firebaseClient.Child("usuarios").OrderByKey().OnceAsync<User>();

                var users = await firebaseClient.Child("usuarios").OrderByKey().EqualTo("-LpaAP22-_YfzY_t1c4a").OnceAsync<User>();

                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Object.nome}");
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