using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion.After
{
    public class PrintingSystem
    {
        private IInvoicePrinter InvoicePrinter;
        public PrintingSystem(IInvoicePrinter invoicePrinter)
        {
            InvoicePrinter = invoicePrinter;
        }

        public void Print(Invoice invoice)
        {
            InvoicePrinter.Print(invoice);
        }
    }
}
