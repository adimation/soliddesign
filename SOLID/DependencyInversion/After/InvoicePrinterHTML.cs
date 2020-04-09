using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion.After
{
    public class InvoicePrinterHTML : IInvoicePrinter
    {
        public void Print(Invoice invoice)
        {
            // logic
        }

        public void PrintComplex(ComplexInvoice invoice)
        {
            // logic
        }
    }
}
