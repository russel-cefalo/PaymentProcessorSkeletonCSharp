using System;
using PaymentProcessor.Instrument;
using PaymentProcessor.Processor;
namespace PaymentProcessor
{
    public class Program
    {
        static void Main(string[] args){
            var debitcard = new DebitCard();
            debitcard.SetCustomerName("Mohiuddin");
            debitcard.SetInstrumentType(InstrumentType.Card);
            debitcard.SetFinancialOrganizationName("EBL");

            var paymentProcessor = new PaymentProcessor.Processor.PaymentProcessor();
            paymentProcessor.Process(debitcard, 100);
        }
    }
}
