using System;

namespace PaymentProcessor.Instrument
{
    public interface Instrument{
        void SetFinancialOrganizationName(String financialOrganizationName);
        void SetCustomerName(String customerName);
        void SetInstrumentType(InstrumentType instrumentType);
        InstrumentType getInstrumentType();
    }
}
