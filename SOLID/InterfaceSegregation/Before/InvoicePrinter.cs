using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation.Before
{
    public class InvoicePrinter : IInvoicePrinter
    {
        public void Print(Invoice invoice)
        {
            Console.WriteLine($"Invoice Total: {invoice.CalculateTotal()} including tax rate: ${invoice.TaxRate}");
        }

        public void PrintComplex(ComplexInvoice invoice)
        {
            Console.WriteLine($"Complex Invoice Total: {invoice.CalculateTotal()} including tax rate: ${invoice.TaxRate}");
        }

        //[Obsolete]
        public void SomeOtherPrint(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
