using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.LiskovSubstitution.Before
{
    public class Invoice
    {
        public decimal SubTotal { get; set; }
        public decimal TaxRate { get; set; }

        public decimal CalculateTax()
        {
            return SubTotal * TaxRate / 100;
        }

        public decimal CalculateTotal()
        {
            return SubTotal + CalculateTax();
        }
    }
}
