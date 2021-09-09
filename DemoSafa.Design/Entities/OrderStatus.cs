using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSafa
{
    /// <summary>
    /// Order status
    /// </summary>
    public enum OrderStatus : byte
    {
        Pending = 0,
        Validated = 1,
        Rejected =2
    }
}
