using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSalesSystem
{
    public enum OrderStatus
    {
        Ordered,
        Processing,
        Completed,
        Filled,
        Shipped,
        BackOrdered,
        NotAvailable,
    }
}
