using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.VeiculosTerrestres
{
    class Moto : IVeiculoTerrestre
    {
        public void IniciarRota()
        {
            PegarCarga();
            Console.WriteLine("Iniciando a entrega de encomenda.");
        }

        public void PegarCarga()
        {
            Console.WriteLine("Pegamos a encomenda.");
        }
    }
}
