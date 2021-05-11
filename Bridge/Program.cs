using Bridge.Plataforma;
using Bridge.Transmissoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void IniciarLive(IPlataforma plataforma)
        {
            Console.WriteLine("Aguarde...");
            Live live = new Live(plataforma);

            live.Broadcasting();
            live.Result();
        }

        static void IniciarLiveAvancada(IPlataforma plataforma)
        {
            Console.WriteLine("Aguarde...");
            LiveAvancada live = new LiveAvancada(plataforma);

            live.Broadcasting();            
            live.Legendas();
            live.Comentarios();
            live.Result();
        }

        static void Main(string[] args)
        {
            IniciarLive(new YouTube());
            IniciarLiveAvancada(new Facebook());
            IniciarLive(new TwitchTV());

            Console.ReadLine();
        }
    }
}
