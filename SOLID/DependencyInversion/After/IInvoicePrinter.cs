using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion.After
{
    public interface IInvoicePrinter
    {
        void Print(Invoice invoice);
        void PrintComplex(ComplexInvoice invoice);
    }
}
