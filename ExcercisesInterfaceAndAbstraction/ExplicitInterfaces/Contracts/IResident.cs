using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaces.Contracts
{
    public interface IResident
    {
        //a name, country and a method GetName(). 
        string Name { get; }
        string Country { get; }
        string GetName();
    }
}
