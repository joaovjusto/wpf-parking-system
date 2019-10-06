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
    public partial class AlterarEstada : Window
    {
        public AlterarEstada()
        {
            InitializeComponent();
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
                vaga = Convert.ToInt32(vaga.Text),
                area = areas.Text,
                usuario = estadas.Text
            };

            EstadaDAL estadaDal = new EstadaDAL();

            var cadastroEstada = await estadaDal.AlterarEstada(u);

            if (cadastroEstada)
            {
                MessageBox.Show("Estada alterada com sucesso!",
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

        private async void Areas_Loaded(object sender, RoutedEventArgs e)
        {
            AreaEstacionamentoDAL areaDAL = new AreaEstacionamentoDAL();

            List<AreaEstacionamento> areasEstacionamento = await areaDAL.BuscaTodasAreas();

            areas.ItemsSource = areasEstacionamento;
        }

        private async void Estadas_Loaded(object sender, RoutedEventArgs e)
        {
            EstadaDAL estadaDAL = new EstadaDAL();

            List<Estada> todas = await estadaDAL.BuscaTodasEstadas();

            estadas.ItemsSource = todas;
        }

        private async void Usuarios_Loaded(object sender, RoutedEventArgs e)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();

            List<User> todas = await usuarioDAL.BuscaTodosUsuarios();

            usuarios.ItemsSource = todas;
        }
    }
}
