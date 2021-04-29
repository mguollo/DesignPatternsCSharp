using FactoryMethod.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Fabricas
{
    class MotoTransporte : Transporte
    {
        protected override IVeiculo CriarTransporte()
        {
            return new Moto();
        }
    }
}
