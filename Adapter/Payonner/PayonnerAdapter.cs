using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PayonnerAdapter : IPayPalPayment
    {
        private Payonner _payonner;
        public PayonnerAdapter(Payonner payonner)
        {
            _payonner = payonner;
        }

        public Token authToken()
        {
            return _payonner.AuthToken();
        }

        public void PayPalPayment()
        {
            _payonner.SendPayment();
        }

        public void PayPalReceive()
        {
            _payonner.ReceivePayment();
        }
    }
}
