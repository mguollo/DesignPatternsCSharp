using FactoryMethod.Fabricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Transporte transporte = null;
            if (args.Length > 0 && args[0] == "--uber")
            {
                transporte = new CarroTransporte();
            } else if (args.Length > 0 && args[0] == "--log")
            {
                transporte = new MotoTransporte();
            }
            else if (args.Length > 0 && args[0] == "--ubereats")
            {
                transporte = new BicicletaTransporte();
            }
            else
            {
                Console.WriteLine("Selecione o tipo de serviço");
            }

            if (transporte != null)
            {
                transporte.IniciarTransporte();
            }

            Console.ReadLine();
        }
    }
}
