using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SingleResposibility.Before
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

        // If you look at this class all the methods are dealing with the calculations using properties of this class
        // Where this method is printing the invoice which could be a method that uses third party libraries, complex and could have multiple implementations in future.
        // It also has the parameter of invoice which could be any other instance of invoice.
        // There are too many indications that this method does not belong to this class and should be moved to a seperate class.
        public void Print(Invoice invoice)
        {
            // logic here
        }
    }
}
