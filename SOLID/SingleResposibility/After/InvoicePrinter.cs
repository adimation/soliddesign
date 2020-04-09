using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SingleResposibility.After
{
    public class InvoicePrinter
    {
        public void Print(Invoice invoice)
        {
            Console.WriteLine($"Total: {invoice.CalculateTotal()} including tax rate: ${invoice.TaxRate}");
        }
    }
}
