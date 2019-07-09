using System;
namespace MidTerm
{
    public abstract class AbstractPersonFactory
    {
        public abstract Employee GetObject();

        public abstract Employee GetObject(string csvData);
    }
}
