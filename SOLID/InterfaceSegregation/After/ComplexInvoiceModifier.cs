using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation.After
{
    public class ComplexInvoiceModifier
    {
        private ComplexInvoice Invoice;

        public ComplexInvoiceModifier(ComplexInvoice invoice)
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

        public void SetSecondTaxRate(decimal secondtaxrate)
        {
            Invoice.SecondTaxRate = secondtaxrate;
        }

        public ComplexInvoice GenerateInvoice()
        {
            return Invoice;
        }
    }
}
