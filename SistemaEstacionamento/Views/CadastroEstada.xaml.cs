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
    /// Lógica interna para CadastroEstada.xaml
    /// </summary>
    public partial class CadastroEstada : Window
    {
        public CadastroEstada()
        {
            InitializeComponent();
        }

        private void Estada_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void BtnCadastrarEstada_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Cheguei na tela chamei o dal");
            Estada u = new Estada
            {
                entrada = Convert.ToDateTime(entrada.Text),
                saida = Convert.ToDateTime(saida.Text),
                tipo = tipo.Text,
                usuario = usuario.Text
            };

            EstadaDAL estadaDal = new EstadaDAL();

            var cadastroEstada = await estadaDal.CadastrarEstada(u);

            if (cadastroEstada)
            {
                MessageBox.Show("Estada cadastrada com sucesso!",
                    "Sistema de estacionamento", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Essa Estada já existe!",
                    "WPF Vendas", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}
