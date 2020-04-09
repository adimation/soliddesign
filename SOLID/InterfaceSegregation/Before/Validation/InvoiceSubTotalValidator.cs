using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation.Before
{
    public class InvoiceSubTotalValidator : InvoiceValidator
    {
        public override bool Validate(Invoice invoice)
        {
            if (invoice.SubTotal < 0)
                return false;

            return true;
        }
    }
}
