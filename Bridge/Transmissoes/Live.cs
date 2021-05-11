using Bridge.Plataforma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissoes
{
    class Live : ITransmissao
    {
        private IPlataforma _plataforma;

        public Live(IPlataforma plataforma)
        {
            _plataforma = plataforma;
        }
        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando transmissão na {_plataforma}");
        }

        public void Result()
        {
            Console.WriteLine("****** NO AR *******");
        }
    }
}
