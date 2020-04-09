using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LiskovSubstitution.Before
{
    public class ComplexInvoice : Invoice
    {
        public decimal SecondTaxRate { get; set; }

        public new decimal CalculateTax()
        {
            return (SubTotal * TaxRate / 100) + (SubTotal * SecondTaxRate / 100);
        }
    }
}
