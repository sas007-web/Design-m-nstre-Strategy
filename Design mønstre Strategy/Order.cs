using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mønstre_Strategy
{
    internal class Order
    {
        private IPaymentStrategy _paymentStrategy;

        public Order(IPaymentStrategy paymentStrategy) {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessOrder(decimal amount) {
            _paymentStrategy.Pay(amount); // Brug den valgte betalingsstrategi
        }
    }
}
