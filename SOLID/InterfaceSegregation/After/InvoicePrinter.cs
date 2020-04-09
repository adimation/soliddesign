using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation.After
{
    public class InvoicePrinter : IInvoicePrinter, ISomeOtherPrint
    {
        public void Print(Invoice invoice)
        {
            Console.WriteLine($"Invoice Total: {invoice.CalculateTotal()} including tax rate: ${invoice.TaxRate}");
        }

        public void PrintComplex(ComplexInvoice invoice)
        {
            Console.WriteLine($"Complex Invoice Total: {invoice.CalculateTotal()} including tax rate: ${invoice.TaxRate}");
        }

        public void SomeOtherPrint(Invoice invoice)
        {
            // logic here.
        }
    }
}
