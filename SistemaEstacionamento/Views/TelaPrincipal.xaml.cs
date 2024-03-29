﻿using Firebase.Database;
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
using SistemaEstacionamento.DAL;

namespace SistemaEstacionamento.Views
{
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

        }


        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            CadastroEstada c = new CadastroEstada();
            c.ShowDialog();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            CadastroArea c = new CadastroArea();
            c.ShowDialog();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            AlterarEstada c = new AlterarEstada();
            c.ShowDialog();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            DeletarEstada c = new DeletarEstada();
            c.ShowDialog();
        }

        private async void ListaEstadas_Loaded(object sender, RoutedEventArgs e)
        {
            EstadaDAL estadaDAL = new EstadaDAL();

            List<Estada> estadas = await estadaDAL.BuscaTodasEstadas();

            listaEstadas.ItemsSource = estadas;
        }

        private async void ListaEstadas_MouseEnter(object sender, MouseEventArgs e)
        {
            EstadaDAL estadaDAL = new EstadaDAL();

            List<Estada> estadas = await estadaDAL.BuscaTodasEstadas();

            listaEstadas.ItemsSource = estadas;
        }
    }
}