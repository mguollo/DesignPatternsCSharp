using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforma
{
    class Facebook : IPlataforma
    {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: transmissão iniciada.");
        }
        public void AuthToken()
        {
            Console.WriteLine("Facebook: autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: configurando RMTP.");
        }
    }
}
