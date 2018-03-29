using System;

namespace ThirdParty.API
{
    public class GenericMobilePaymentHandler
    {
        public static void handlePayment(String provider, String mobileNumber, double amount)
        {
            Console.WriteLine($"\nHandling mobile payment for provider: {provider}, number: {mobileNumber}, amount: {amount}");
        }
    }
}
