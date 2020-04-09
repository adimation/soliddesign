using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LiskovSubstitution.Before
{
    public class InvoiceModifier
    {
        private Invoice Invoice;

        public InvoiceModifier(Invoice invoice)
        {
            Invoice = invoice;
        }

        public void SetSubTotal(decimal subtotal)
        {
            Invoice.SubTotal = subtotal;
        }

        public void SetTaxRate(decimal taxrate)
        {
            Invoice.TaxRate = taxrate;
        }

        public Invoice GenerateInvoice()
        {
            return Invoice;
        }
    }
}
