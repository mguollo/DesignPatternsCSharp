using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforma
{
    class YouTube : IPlataforma
    {
        public YouTube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: transmissão iniciada.");
        }
        public void AuthToken()
        {
            Console.WriteLine("Youtube: autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: configurando RMTP.");
        }
    }
}
