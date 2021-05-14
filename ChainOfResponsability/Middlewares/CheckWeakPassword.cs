using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Middlewares
{
    class CheckWeakPassword : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password == "123456")
            {
                Console.WriteLine("Sua senha é fraca. Considere trocá-la por uma mais forte.");
            }

            return true;
        }
    }
}
