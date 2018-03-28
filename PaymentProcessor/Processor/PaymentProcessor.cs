using System;
using PaymentProcessor;

namespace PaymentProcessor.Processor
{
    public class PaymentProcessor
    {
        public void Process(Instrument.Instrument instrument, double amount) 
        {
            SaveIntoDatabase(instrument, amount);
        }

        public void SaveIntoDatabase(Instrument.Instrument instrument, double amount)
        {
            Console.WriteLine("Saving data into database");
        }
    }
}
