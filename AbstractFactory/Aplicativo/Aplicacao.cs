using AbstractFactory.Aeronaves;
using AbstractFactory.Factory;
using AbstractFactory.VeiculosTerrestres;

namespace AbstractFactory.Aplicativo
{
    class Aplicacao
    {
        private IAeronave aeronave;
        private IVeiculoTerrestre veiculoTerrestre;

        public Aplicacao(ITransportFactory factory)
        {
            aeronave = factory.CriarTransporteAeronave();
            veiculoTerrestre = factory.CriarTransporteTerrestre();
        }

        public void IniciarRota()
        {
            veiculoTerrestre.IniciarRota();
            aeronave.IniciarRota();
        }

    }
}
