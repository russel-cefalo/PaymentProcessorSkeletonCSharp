﻿using ThirdParty.API;

namespace TestConsole
{
    class TestThirdPartyApi
    {
        static void Main(string[] args)
        {
            testEasternCardPayment();
            testGenericCardPayment();
            testGenericMobilePayment();
            testUcashPayment();
        }


        private static void testUcashPayment()
        {
            UcashPaymentHandler paymentHandler = new UcashPaymentHandler();
            paymentHandler.processPayment("0494949", 4000);
        }

        private static void testGenericMobilePayment()
        {
            GenericMobilePaymentHandler.handlePayment("blink", "003930", 2000);
        }

        private static void testGenericCardPayment()
        {
            GenericCardHandler handler = GenericCardHandler.createHandler("232323", "Zaki", "2022");
            handler.processAmount(9000);
        }

        private static void testEasternCardPayment()
        {
            EBLCardHandler.processPayment("112312", "Jobaer", "2019", 2000);
        }
    }
}
