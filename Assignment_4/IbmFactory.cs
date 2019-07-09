using System;
namespace MidTerm
{
    public class IbmFactory : AbstractCompanyFactory
    {
        public override Company GetObject()
        {
            return new Ibm();
        }
    }
}
