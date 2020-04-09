using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClosed.Before
{
    public class InvoiceValidator
    {
        public bool Validate(Invoice invoice)
        {
            if (invoice.SubTotal < 0)
                return false;
            if (invoice.TaxRate < 0)
                return false;

            return true;
        }
    }
}
