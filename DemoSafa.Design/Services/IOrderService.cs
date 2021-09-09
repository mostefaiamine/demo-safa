using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSafa
{
    /// <summary>
    /// This service exposes order operations
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Creates an order
        /// </summary>
        /// <param name="product">The product to order</param>
        /// <param name="quantity">The quantity to order</param>
        /// <returns>The newly created order</returns>
        Task<Order> CreateOrder(string product, int quantity);


        /// <summary>
        /// Gets all the orders
        /// </summary>
        /// <returns></returns>
        Task<List<Order>> GetAllOrders();
    }
}
