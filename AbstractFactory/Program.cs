using AbstractFactory.Aplicativo;
using AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static Aplicacao CriarAplicacao()
        {
            Aplicacao app;

            ITransportFactory transportFactory;
            string companhia = "99";

            if (companhia == "Uber")
            {
                transportFactory = new UberTransport();
            } else if (companhia == "99")
            {
                transportFactory = new NineNineTransport();
            }
            else
            {
                transportFactory = new LimeTransport();
            }

            app = new Aplicacao(transportFactory);

            return app;
        }
        static void Main(string[] args)
        {
            Aplicacao app = CriarAplicacao();

            app.IniciarRota();

            Console.ReadLine();
        }
    }
}
