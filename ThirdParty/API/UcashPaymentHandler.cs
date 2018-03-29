using System;

namespace ThirdParty.API
{
    public class UcashPaymentHandler
    {
        public void processPayment(String mobileNumber, double amount)
        {
            Console.WriteLine($"\nHandling Ucash payment for mobileNumber: {mobileNumber}, amount: {amount}");
        }
    }
}
