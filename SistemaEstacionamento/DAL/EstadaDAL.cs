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
    }
}
