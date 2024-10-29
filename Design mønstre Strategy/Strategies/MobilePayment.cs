﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_mønstre_Strategy.Strategies
{
    internal class MobilePayment : IPaymentStrategy
    {
        public void Pay(decimal amount) {
            Console.WriteLine($"Betaling modtaget: {amount} kr. via mobilbetaling.");
        }
    }
}
