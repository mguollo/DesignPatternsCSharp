using Builder.Builder;
using Builder.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Diretores
{
    class Diretor
    {
        IBuilder builder;

        public Diretor(IBuilder builder)
        {
            this.builder = builder;

        }
        public void ConstrutorCarroSedan()
        {
            builder.SetTipoVeiculo(TipoVeiculo.SEDAN);
            builder.SetMotor(new Motor(2000));
            builder.SetAssentos(5);
            builder.SetTransmissao(Transmissao.AUTOMATIC);
        }

        public void ConstrutorCaminhao()
        {
            builder.SetTipoVeiculo(TipoVeiculo.TRUCK);
            builder.SetMotor(new Motor(4000));
            builder.SetAssentos(2);
            builder.SetTransmissao(Transmissao.MANUAL);
        }

        public void ConstrutorSUV()
        {
            builder.SetTipoVeiculo(TipoVeiculo.SUV);
            builder.SetMotor(new Motor(3000));
            builder.SetAssentos(6);
            builder.SetTransmissao(Transmissao.AUTOMATIC);
            builder.SetAirBags(new AirBag());
        }
    }
}
