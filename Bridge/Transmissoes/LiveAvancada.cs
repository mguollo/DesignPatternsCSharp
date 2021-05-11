using Bridge.Plataforma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Transmissoes
{
    class LiveAvancada : Live
    {
        public LiveAvancada(IPlataforma plataforma): base(plataforma)
        {

        }
        public void Legendas()
        {
            Console.WriteLine("Legendas ativadas na transmissão");
        }

        public void Comentarios()
        {
            Console.WriteLine("Comentarios ativados na transmissão");
        }
    }
}
