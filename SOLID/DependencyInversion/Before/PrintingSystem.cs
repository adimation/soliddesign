using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion.Before
{
    public class PrintingSystem
    {
        private InvoicePrinter InvoicePrinter;
        public PrintingSystem(InvoicePrinter invoicePrinter)
        {
            InvoicePrinter = invoicePrinter;
        }

        public void Print(Invoice invoice)
        {
            // logic here
            InvoicePrinter.Print(invoice);
        }
    }
}
