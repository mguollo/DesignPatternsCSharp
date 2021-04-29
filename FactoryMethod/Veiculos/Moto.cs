using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Veiculos
{
    class Moto : IVeiculo
    {
        public void IniciarRota()
        {
            PegarCarga();
            Console.WriteLine("Iniciando a entrega");
        }

        public void PegarCarga()
        {
            Console.WriteLine("Pegarmos a encomenda");
        }
    }
}
