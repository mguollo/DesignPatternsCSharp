using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aeronaves
{
    class Helicoptero : IAeronave
    {
        public void IniciarRota()
        {
            TestarVento();
            PegarCarga();

            Console.WriteLine("Iniciando decolagem!!!");
        }

        public void PegarCarga()
        {
            Console.WriteLine("Pegando passageiros. Ligando as Hélices");
        }

        public void TestarVento()
        {
            Console.WriteLine("Verificando os ventos! Tudo OK para Helicopetro!");
        }
    }
}
