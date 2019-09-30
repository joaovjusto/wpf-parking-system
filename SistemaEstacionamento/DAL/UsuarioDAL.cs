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
    class UsuarioDAL
    {
        public async Task<bool> BuscarUsuarioPorNome(User u)
        {
            Console.WriteLine("Cheguei no buscausuario");

            var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

            var users = await firebaseClient.Child("usuarios").OrderByKey().OnceAsync<User>();

            Console.WriteLine($"{u.nome}");

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Object.nome}");

                if (u.nome == user.Object.nome) {
                    return false;
                }
            }

            return true;
        }
        
        public async Task<bool> CadastrarUsuario(User u)
        {
            if (await BuscarUsuarioPorNome(u))
            {
                Console.WriteLine("Cheguei no cadastro");

                var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

                //var user1 = new User
                //{
                  //  nome = "João Justo",
                    //idade = 20,
                    //senha = "DASDAs34234fedf234",
                    //usuario = "jvjusto"
                //};

                await firebaseClient
                 .Child("usuarios")
                .PostAsync(u);

                return true;
            }else {
                return false;
            }
        }
    }
}
