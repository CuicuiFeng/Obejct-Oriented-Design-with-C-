using System;

namespace MidTerm
{
    interface IBillable
    {
        int GetUsage();
        decimal GetCharges(int multiplier, decimal fees);
    }
}
