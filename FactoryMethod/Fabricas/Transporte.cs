using FactoryMethod.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Fabricas
{
    abstract class Transporte
    {
        public void IniciarTransporte()
        {
            IVeiculo veiculo = CriarTransporte();
            veiculo.IniciarRota();
        }
        protected abstract IVeiculo CriarTransporte();
    }
}
