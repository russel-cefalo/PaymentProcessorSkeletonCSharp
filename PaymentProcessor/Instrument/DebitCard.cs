using System;
namespace PaymentProcessor.Instrument
{
    public class DebitCard: Instrument
    {
        private String FinancialOrganizationName;
        private String CustomerName;
        private InstrumentType InstrumentType;
        private String ObscuredCardNumber;

        public InstrumentType getInstrumentType()
        {
            return InstrumentType;
        }

        public void SetCustomerName(string customerName)
        {
            this.CustomerName = customerName;
        }

        public void SetFinancialOrganizationName(string financialOrganizationName)
        {
            this.FinancialOrganizationName = financialOrganizationName;
        }

        public void SetInstrumentType(InstrumentType instrumentType)
        {
            this.InstrumentType = instrumentType;
        }
    }
}
