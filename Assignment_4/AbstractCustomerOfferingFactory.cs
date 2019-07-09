using System;

namespace MidTerm
{
    abstract class AbstractCustomerOfferingFactory
    {
        public abstract Product GetObject(string csvData);
    }
}
