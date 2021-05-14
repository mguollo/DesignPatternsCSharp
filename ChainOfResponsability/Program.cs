using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Program
    {
        private static Server _server;
        static void Init()
        {
            _server = new Server();

            _server.RegisterUser("master@123.com.br", "123456");
            _server.RegisterUser("usuario@123.com.br", "12345678");

            Middleware middleware = new CheckUserMiddleware(_server);
            middleware.LinkWith(new CheckPermissionMiddleware());
            middleware.LinkWith(new CheckWeakPassword());

            _server.middleware = middleware;
        }

        static void Main(string[] args)
        {
            Init();

            Boolean done;
            do
            {
                Console.WriteLine("Digite o seu email:");
                string email = Console.ReadLine();
                Console.WriteLine("Digite a sua senha:");
                string senha = Console.ReadLine();

                done = _server.LogIn(email, senha);
            } while (!done);

            Console.ReadLine();
        }
    }
}
