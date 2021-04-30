using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aeronaves
{
    class Drone : IAeronave
    {
        public void IniciarRota()
        {
            TestarVento();
            PegarCarga();
            Console.WriteLine("Iniciando voo de drone.");
        }

        public void PegarCarga()
        {
            Console.WriteLine("Coletou encomenda.");
        }

        public void TestarVento()
        {
            Console.WriteLine("Vento fraco. Ok para drone.");
        }
    }
}
