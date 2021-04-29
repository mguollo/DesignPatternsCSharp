using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Veiculos
{
    class Carro : IVeiculo
    {
        public void IniciarRota()
        {
            PegarCarga();
            Console.WriteLine("Iniciamos o trajeto.");
        }

        public void PegarCarga()
        {
            Console.WriteLine("Pegamos os passageiros.");           
        }
    }
}
