using System;
namespace MidTerm
{
    class LicensedProductFactory : AbstractCustomerOfferingFactory
    {
        public override Product GetObject(string csvData)
        {
            return new LicensedProduct(csvData);
        }
    }
}
