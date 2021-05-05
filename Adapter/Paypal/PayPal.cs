using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PayPal : IPayPalPayment
    {
        private Token token;
        public Token authToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            token = authToken();
            Console.WriteLine("Enviando pagamento com PayPal");
        }

        public void PayPalReceive()
        {
            Console.WriteLine("Recebendo pagamento com PayPal");
        }
    }
}
