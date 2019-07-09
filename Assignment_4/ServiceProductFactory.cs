using System;

namespace MidTerm
{
    class ServiceProductFactory : AbstractCustomerOfferingFactory
    {
        public override Product GetObject(string csvData)
        {
            return new ServiceProduct(csvData);
        }
    }
}
