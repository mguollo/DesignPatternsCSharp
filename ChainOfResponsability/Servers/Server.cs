﻿using ChainOfResponsability.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Servers
{
    class Server
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();

        public Middleware middleware { get; set; }
        
        public Boolean LogIn(string email, string password)
        {
            if (middleware.Check(email, password))
            {
                Console.WriteLine("Usuário autorizado com sucesso!");
                Console.WriteLine("Bem vindo!");
                return true;
            }

            return false;            
        }

        public void RegisterUser(string email, string password)
        {
            users[email] = password;            
        }

        public Boolean HasEmail(string email)
        {
            return users.ContainsKey(email);
        }

        public Boolean IsValidPassword(string email, string password)
        {
            string value = "";
            users.TryGetValue(email, out value);

            return password == value;
        }
    }
}
