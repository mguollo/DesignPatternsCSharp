using AbstractFactory.Aeronaves;
using AbstractFactory.VeiculosTerrestres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    class UberTransport : ITransportFactory
    {
        public IAeronave CriarTransporteAeronave()
        {
            return new Aviao();
        }

        public IVeiculoTerrestre CriarTransporteTerrestre()
        {
            return new Carro();
        }
    }
}
