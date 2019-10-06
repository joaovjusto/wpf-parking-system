using System;
using Firebase.Database;
using Firebase.Database.Query;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEstacionamento.Model;

namespace SistemaEstacionamento.DAL
{
    class EstadaDAL
    {
        public async Task<bool> BuscarEstadaPorNome(Estada u)
        {
            Console.WriteLine("Cheguei no busca usuario");

            var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

            var estadas = await firebaseClient.Child("estadas").OrderByKey().OnceAsync<Estada>();

            Console.WriteLine($"{u.usuario}");

            foreach (var estada in estadas)
            {
                Console.WriteLine($"{estada.Object.usuario}");

                if (u.usuario == estada.Object.usuario)
                {
                    return false;
                }
            }

            return true;
        }

        public async Task<bool> CadastrarEstada(Estada u)
        {
            if (await BuscarEstadaPorNome(u))
            {
                Console.WriteLine("Cheguei no cadastro");

                var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

                await firebaseClient
                 .Child("estadas")
                .PostAsync(u);

                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<Estada>> BuscaTodasEstadas()
        {
            Console.WriteLine("Cheguei no busca todas estadas");

            var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

            var estadas = await firebaseClient.Child("estadas").OrderByKey().OnceAsync<Estada>();

            List<Estada> items = new List<Estada>();

            foreach (var estada in estadas)
            {
                items.Add(new Estada() {
                    entrada = estada.Object.entrada,
                    saida = estada.Object.saida,
                    vaga = estada.Object.vaga,
                    area = estada.Object.area,
                    tipo = estada.Object.tipo,
                    usuario = estada.Object.usuario
                });
            }

            return items;
        }

        public async Task<bool> AlterarEstada(Estada u)
        {
            Console.WriteLine("Cheguei no alterar estada estadas");

            var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

            var estadas = await firebaseClient.Child("estadas").OrderByKey().OnceAsync<Estada>();

            foreach (var estada in estadas)
            {
                Console.WriteLine(estada.Object.usuario);
                Console.WriteLine(u.usuario);
                if (u.usuario == estada.Object.usuario)
                {
                    await firebaseClient
                      .Child("estadas")
                      .Child(estada.Key)
                      .DeleteAsync();

                    Console.WriteLine("dasds");
                    await firebaseClient
                     .Child("estadas")
                        .PostAsync(u);
                    return true;
                }
            }
            return false;
        }

        public async Task<bool> DeleteEstada(Estada u)
        {
            Console.WriteLine("Cheguei no alterar estada estadas");

            var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

            var estadas = await firebaseClient.Child("estadas").OrderByKey().OnceAsync<Estada>();

            foreach (var estada in estadas)
            {
                Console.WriteLine(estada.Object.usuario);
                if (u.usuario == estada.Object.usuario)
                {
                    await firebaseClient
                      .Child("estadas")
                      .Child(estada.Key)
                      .DeleteAsync();
                    return true;
                }
            }
            return false;
        }
    }
}
