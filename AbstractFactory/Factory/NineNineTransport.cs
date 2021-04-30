using AbstractFactory.Aeronaves;
using AbstractFactory.VeiculosTerrestres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    class NineNineTransport : ITransportFactory
    {
        public IAeronave CriarTransporteAeronave()
        {
            return new Helicoptero();
        }

        public IVeiculoTerrestre CriarTransporteTerrestre()
        {
            return new Moto();
        }
    }
}
