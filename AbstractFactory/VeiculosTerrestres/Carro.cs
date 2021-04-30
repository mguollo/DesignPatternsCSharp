using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.VeiculosTerrestres
{
    class Carro : IVeiculoTerrestre
    {
        public void IniciarRota()
        {
            PegarCarga();
            Console.WriteLine("Iniciando o trajeto.");
        }

        public void PegarCarga()
        {
            Console.WriteLine("Pegamos os passageiros, estamos prontos.");
        }
    }
}
