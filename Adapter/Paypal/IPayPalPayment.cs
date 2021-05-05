using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface IPayPalPayment
    {
        Token authToken();
        void PayPalPayment();
        void PayPalReceive();
    }
}
