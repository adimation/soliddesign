using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversion.Before
{
    public class InvoiceTaxRateValidator : InvoiceValidator
    {
        public override bool Validate(Invoice invoice)
        {
            if (invoice.TaxRate < 0)
                return false;

            return true;
        }
    }
}
