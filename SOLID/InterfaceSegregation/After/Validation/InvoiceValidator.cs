using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.InterfaceSegregation.After
{
    public abstract class InvoiceValidator
    {
        public abstract bool Validate(Invoice invoice);
    }
}
