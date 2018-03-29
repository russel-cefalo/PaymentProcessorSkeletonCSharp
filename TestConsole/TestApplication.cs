using System.Collections.Generic;

namespace TestConsole
{
    class Program
    {
        // Uncomment below section when you want to test this
        
        //static void Main(string[] args)
        //{
        //    IPaymentFormHandler handler = new DummyPaymentFormHandler();
        //    var testForm = CardTypeForm();
        //    handler.handlePaymentFormSubmission(testForm);
        //}


        private static Dictionary<string, string> CardTypeForm()
        {
            Dictionary<string, string> testForm = new Dictionary<string, string>
            {
                {PaymentFormConstants.PAYMENT_TYPE_KEY, "card"},
                {PaymentFormConstants.ACCOUNT_NAME_KEY, "jobaer"},
                {PaymentFormConstants.ORGANIZATION_KEY, "EBL"},
                {PaymentFormConstants.EXPIRY_DATE_KEY, "2019"},
                {PaymentFormConstants.AMOUNT_KEY, "4000"}
            };
            return testForm;
        }

        private static Dictionary<string, string> MobilePaymentTypeForm()
        {
            Dictionary<string, string> testForm = new Dictionary<string, string>
            {
                {PaymentFormConstants.PAYMENT_TYPE_KEY, "mobile"},
                {PaymentFormConstants.MOBILE_NUMBER_KEY, "0993993"},
                {PaymentFormConstants.AMOUNT_KEY, "5000"}
            };
            return testForm;
        }

        private static Dictionary<string, string> UcashPaymentTypeForm()
        {
            Dictionary<string, string> testForm = new Dictionary<string, string>
            {
                {PaymentFormConstants.PAYMENT_TYPE_KEY, "mobile"},
                {PaymentFormConstants.MOBILE_PAYMENT_VENDOR_KEY, "ucash"},
                {PaymentFormConstants.MOBILE_NUMBER_KEY, "0993993"},
                {PaymentFormConstants.AMOUNT_KEY, "2000"}
            };
            return testForm;
        }
    }
}
