using AbstractFactory.Aeronaves;
using AbstractFactory.VeiculosTerrestres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    interface ITransportFactory
    {
        IAeronave CriarTransporteAeronave();
        IVeiculoTerrestre CriarTransporteTerrestre();
    }
}
