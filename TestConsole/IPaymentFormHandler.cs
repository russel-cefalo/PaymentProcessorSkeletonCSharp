using System.Collections.Generic;

namespace TestConsole
{
    public interface IPaymentFormHandler
    {
        void handlePaymentFormSubmission(Dictionary<string, string> formdata);
    }
}
