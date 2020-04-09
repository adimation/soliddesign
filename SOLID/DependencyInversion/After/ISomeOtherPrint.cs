using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion.After
{
    public interface ISomeOtherPrint
    {
        void SomeOtherPrint(Invoice invoice);
    }
}
