using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID.DependencyInversion.Before
{
    public class ValidateInvoice
    {
        private List<InvoiceValidator> Validators;

        public ValidateInvoice(List<InvoiceValidator> validators)
        {
            this.Validators = validators;
        }

        public bool Validate(Invoice invoice)
        {
            return this.Validators.All(v => v.Validate(invoice));
        }
    }
}
