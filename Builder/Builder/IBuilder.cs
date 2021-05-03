using Builder.Componentes;
using Builder.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    interface IBuilder
    {
        void Reset();
        Veiculo GetVeiculo();

        void SetAssentos(int assentos);
        void SetMotor(Motor motor);
        void SetTransmissao(Transmissao transmissao);
        void SetTipoVeiculo(TipoVeiculo tipoVeiculo);
        void SetAirBags(AirBag airBag);

    }
}
