using System;

namespace ThirdParty.API
{
    public class EBLCardHandler
    {
        public static void processPayment(String cardNumber, String account, String expiry, double amount)
        {
            Console.WriteLine($"\nHandling Eastern payment for account: {account}, amount: {amount}");
        }
    }
}
