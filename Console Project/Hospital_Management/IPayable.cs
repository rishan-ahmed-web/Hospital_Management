using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Management
{
    public interface IPayable
    {
        bool Pay(decimal amount);
    }
}
