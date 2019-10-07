﻿using System;
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
            Console.WriteLine("Cheguei no busca usuario");

            var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

            var users = await firebaseClient.Child("usuarios").OrderByKey().OnceAsync<User>();

            Console.WriteLine($"{u.nome}");

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Object.nome}");

                if (u.usuario == user.Object.usuario) {
                    return false;
                }
            }

            return true;
        }

        public async Task<bool> BuscarPorLogin(User u)
        {
            Console.WriteLine("Cheguei no busca usuario");

            var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

            var users = await firebaseClient.Child("usuarios").OrderByKey().OnceAsync<User>();

            Console.WriteLine($"{u.nome}");

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Object.nome}");

                if (u.usuario == user.Object.usuario && u.senha == user.Object.senha && user.Object.tipo != "Cliente")
                {
                    return true;
                }
            }

            return false;
        }

        public async Task<bool> CadastrarUsuario(User u)
        {
            if (await BuscarUsuarioPorNome(u))
            {
                Console.WriteLine("Cheguei no cadastro");

                var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

                await firebaseClient
                 .Child("usuarios")
                .PostAsync(u);

                return true;
            }else {
                return false;
            }
        }

        public async Task<List<User>> BuscaTodosUsuarios()
        {
            Console.WriteLine("Cheguei no busca todas usuarios");

            var firebaseClient = new FirebaseClient("https://parking-sharp.firebaseio.com/");

            var usuarios = await firebaseClient.Child("usuarios").OrderByKey().OnceAsync<User>();

            List<User> items = new List<User>();

            foreach (var usuario in usuarios)
            {
                if(usuario.Object.tipo != "Funcionário")
                {
                    items.Add(new User()
                    {
                        nome = usuario.Object.nome,
                        idade = usuario.Object.idade,
                        senha = usuario.Object.senha,
                        usuario = usuario.Object.usuario,
                        tipo = usuario.Object.tipo
                    });
                }
            }

            return items;
        }
    }
}
