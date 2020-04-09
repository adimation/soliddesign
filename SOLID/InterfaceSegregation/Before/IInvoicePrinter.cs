using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation.Before
{
    public interface IInvoicePrinter
    {
        void Print(Invoice invoice);
        void PrintComplex(ComplexInvoice invoice);
        void SomeOtherPrint(Invoice invoice);
    }
}
