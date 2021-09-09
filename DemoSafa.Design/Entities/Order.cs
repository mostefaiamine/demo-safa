using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSafa
{
    /// <summary>
    /// This represents an order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// The total amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The order date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The order id
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// The order product
        /// </summary>
        public string Product { get; set; }

        /// <summary>
        /// The product quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The unit price used for this order
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The order status
        /// </summary>
        public OrderStatus Status { get; set; }
    }
}
