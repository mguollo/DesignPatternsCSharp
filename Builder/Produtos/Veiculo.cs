using Builder.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Produtos
{
    class Veiculo
    {
        public TipoVeiculo TipoVeiculo { get; set; }
        public int Assentos { get; set; }
        public Motor Motor { get; set; }
        public Transmissao Transmissao { get; set; }
        public AirBag airBag { get; set; }
        public Boolean TemAirBag()
        {
            return airBag != null;
        }

    }
}
