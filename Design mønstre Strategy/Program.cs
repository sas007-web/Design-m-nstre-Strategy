using Design_mønstre_Strategy.Strategies;

namespace Design_mønstre_Strategy
{
    internal class Program
    {  
        static void Main(string[] args) {

            // Opret ordre med betaling via kontanter
            Order order1 = new Order(new CashPayment());
            order1.ProcessOrder(500); // Betal 500 kr. kontant

            // Opret ordre med betaling via kreditkort
            Order order2 = new Order(new CreditCardPayment());
            order2.ProcessOrder(750); // Betal 750 kr. med kreditkort

            // Opret ordre med betaling via mobilbetaling
            Order order3 = new Order(new MobilePayment());
            order3.ProcessOrder(300); // Betal 300 kr. via mobilbetaling
        }
    }
}