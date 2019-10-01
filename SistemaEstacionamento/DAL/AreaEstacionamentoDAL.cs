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
    class AreaEstacionamentoDAL
    {
        public async Task<bool> BuscarAreaPorNome(AreaEstacionamento u)
        {
            Console.WriteLine("Cheguei no busca usuario");

            var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

            var areaEstacionamentoList = await firebaseClient.Child("areaEstacionamento").OrderByKey().OnceAsync<AreaEstacionamento>();

            Console.WriteLine($"{u.nome}");

            foreach (var areaEstacionamento in areaEstacionamentoList)
            {
                Console.WriteLine($"{areaEstacionamento.Object.nome}");

                if (u.nome == areaEstacionamento.Object.nome)
                {
                    return false;
                }
            }

            return true;
        }

        public async Task<bool> CadastrarArea(AreaEstacionamento u)
        {
            if (await BuscarAreaPorNome(u))
            {
                Console.WriteLine("Cheguei no cadastro");

                var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

                await firebaseClient
                 .Child("areaEstacionamento")
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
