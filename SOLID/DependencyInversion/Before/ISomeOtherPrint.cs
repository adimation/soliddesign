using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion.Before
{
    public interface ISomeOtherPrint
    {
        void SomeOtherPrint(Invoice invoice);
    }
}
