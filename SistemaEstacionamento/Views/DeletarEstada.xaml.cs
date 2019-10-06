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
    public partial class DeletarEstada : Window
    {
        public DeletarEstada()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void BtnCadastrarEstada_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Cheguei na tela chamei o dal");

            Estada b = (Estada)estadas.SelectedItem;

            EstadaDAL estadaDal = new EstadaDAL();

            var cadastroEstada = await estadaDal.DeleteEstada(b);

            if (cadastroEstada)
            {
                MessageBox.Show("Estada deletada com sucesso!",
                    "Sistema de estacionamento", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Erro desconhecido!!!",
                    "WPF Vendas", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private async void Estadas_Loaded(object sender, RoutedEventArgs e)
        {
            EstadaDAL estadaDAL = new EstadaDAL();

            List<Estada> todas = await estadaDAL.BuscaTodasEstadas();

            estadas.ItemsSource = todas;
        }
    }
}
