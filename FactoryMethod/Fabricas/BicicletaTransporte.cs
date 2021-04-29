using FactoryMethod.Veiculos;
using System;

namespace FactoryMethod.Fabricas
{
    class BicicletaTransporte : Transporte
    {
        protected override IVeiculo CriarTransporte()
        {
            return new Bicicleta();
        }
    }
}
