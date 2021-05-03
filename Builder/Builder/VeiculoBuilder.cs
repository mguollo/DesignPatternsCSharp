using Builder.Componentes;
using Builder.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class VeiculoBuilder : IBuilder
    {
        private Veiculo veiculo = new Veiculo();
        public Veiculo GetVeiculo()
        {
            Veiculo result = veiculo;
            Reset();
            return result;
        }

        public void Reset()
        {
            veiculo = new Veiculo();
        }

        public void SetAssentos(int assentos)
        {
            veiculo.Assentos = assentos;
        }

        public void SetMotor(Motor motor)
        {
            veiculo.Motor = motor;
        }

        public void SetTipoVeiculo(TipoVeiculo tipoVeiculo)
        {
            veiculo.TipoVeiculo = tipoVeiculo;
        }

        public void SetTransmissao(Transmissao transmissao)
        {
            veiculo.Transmissao = transmissao;
        }

        public void SetAirBags(AirBag airBag)
        {
            veiculo.airBag = airBag;
        }
    }
}
