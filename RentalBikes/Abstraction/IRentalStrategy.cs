using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalBikes.Abstraction
{
    public interface IRentalStrategy
    {
        decimal GetPrice();
    }
}
