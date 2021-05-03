using Builder.Builder;
using Builder.Diretores;
using Builder.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            VeiculoBuilder builder = new VeiculoBuilder();
            Diretor diretor = new Diretor(builder);

            diretor.ConstrutorCarroSedan();

            Veiculo sedan = builder.GetVeiculo();

            Console.WriteLine($"Criado um veiculo do tipo: {sedan.TipoVeiculo}");
            Console.WriteLine($"Tem airbags? {sedan.TemAirBag()}");

            diretor.ConstrutorCaminhao();
            Veiculo truck = builder.GetVeiculo(); 

            Console.WriteLine($"Criado um veiculo do tipo: {truck.TipoVeiculo}");
            Console.WriteLine($"Tem airbags? {truck.TemAirBag()}");

            diretor.ConstrutorSUV();
            Veiculo suv = builder.GetVeiculo();

            Console.WriteLine($"Criado um veiculo do tipo: {suv.TipoVeiculo}");            
            Console.WriteLine($"Tem airbags? {suv.TemAirBag()}");

            Console.ReadLine();

        }
    }
}
