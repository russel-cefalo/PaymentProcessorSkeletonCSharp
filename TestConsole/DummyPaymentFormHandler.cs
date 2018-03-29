using System;
using System.Collections.Generic;

namespace TestConsole
{
    public class DummyPaymentFormHandler : IPaymentFormHandler
    {
        public void handlePaymentFormSubmission(Dictionary<string, string> formdata)
        {
            Console.WriteLine("TODO");
        }
    }
}
