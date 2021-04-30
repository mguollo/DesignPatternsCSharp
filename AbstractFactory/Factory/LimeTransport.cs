using AbstractFactory.Aeronaves;
using AbstractFactory.VeiculosTerrestres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    class LimeTransport : ITransportFactory
    {
        public IAeronave CriarTransporteAeronave()
        {
            return new Drone();
        }

        public IVeiculoTerrestre CriarTransporteTerrestre()
        {
            return new Patinete();
        }
    }
}
