using System;

namespace MidTerm
{
    class CustomerOffering : Product, IBillable
    {

        public int GetUsage()
        {
            throw new NotImplementedException();
        }

        public decimal GetCharges(int multiplier, decimal fees)
        {
            throw new NotImplementedException();
        }

    }
}
