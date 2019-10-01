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
    /// Lógica interna para CadastroArea.xaml
    /// </summary>
    public partial class CadastroArea : Window
    {
        public CadastroArea()
        {
            InitializeComponent();
        }

        private void Estada_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void BtnCadastrarArea_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Cheguei na tela chamei o dal");
            AreaEstacionamento u = new AreaEstacionamento
            {
                nome = nome.Text,
                qtdeVagas = Convert.ToInt32(vagas.Text),
            };

            AreaEstacionamentoDAL areaDal = new AreaEstacionamentoDAL();

            var cadastroEstada = await areaDal.CadastrarArea(u);

            if (cadastroEstada)
            {
                MessageBox.Show("Area cadastrada com sucesso!",
                    "Sistema de estacionamento", MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Essa Area já existe!",
                    "Sistema Estacionamento", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}
