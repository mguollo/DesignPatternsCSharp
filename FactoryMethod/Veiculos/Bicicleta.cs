using System;

namespace FactoryMethod.Veiculos
{
    class Bicicleta : IVeiculo
    {
        public void IniciarRota()
        {
            PegarCarga();
            Console.WriteLine("Iniciamos a entrega do lanche.");
        }

        public void PegarCarga()
        {
            Console.WriteLine("Pegamos o lanche.");
        }
    }
}
