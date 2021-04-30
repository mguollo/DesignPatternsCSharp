using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.VeiculosTerrestres
{
    class Patinete : IVeiculoTerrestre
    {
        public void IniciarRota()
        {
            PegarCarga();
            Console.WriteLine("Iniciando trajeto de patinete.");
        }

        public void PegarCarga()
        {
            Console.WriteLine("Abrindo patinete e colocando sacola.");
        }
    }
}
