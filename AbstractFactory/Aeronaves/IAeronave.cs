using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aeronaves
{
    interface IAeronave
    {
        void IniciarRota();
        void PegarCarga();
        void TestarVento();
    }
}
