using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IDiscount
    {
        double Calculate(double price);
    }
}
