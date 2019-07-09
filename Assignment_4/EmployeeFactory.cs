using System;
namespace MidTerm
{
    public class EmployeeFactory : AbstractPersonFactory
    {
        public override Employee GetObject()
        {
            throw new NotImplementedException();
        }

        public override Employee GetObject(string csvData)
        {
            return new Employee(csvData);
        }

    }
}
