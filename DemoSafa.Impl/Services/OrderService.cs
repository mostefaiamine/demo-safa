using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSafa
{
    /// <summary>
    /// This is the implementation of the order service
    /// </summary>
    public class OrderService : IOrderService
    {
        /// <summary>
        /// The current id
        /// </summary>
        private int _currentId = 1;

        /// <summary>
        /// The list of order
        /// </summary>
        private readonly List<Order> _orders = new List<Order>();

        /// <summary>
        /// The product service
        /// </summary>
        private readonly IProductService _productService;

        private readonly ITVAService _tva;

        public OrderService(IProductService productService, ITVAService tva)
        {
            _tva = tva;
            _productService = productService;
        }

        /// <summary>
        /// Creates an order
        /// </summary>
        /// <param name="product">The product to order</param>
        /// <param name="quantity">The quantity to order</param>
        /// <returns>The newly created order</returns>
        public async Task<Order> CreateOrder(string product, int quantity)
        {
            await Task.Delay(1000);
            var price = await _productService.GetProductPrice(product);
            var order = new Order
            {
                Amount = price * quantity,
                Date = DateTime.Now,
                Id = _currentId++,
                Product = product,
                Quantity = quantity,
                Status = OrderStatus.Pending,
                UnitPrice = price
            };
            order.Amount += (order.Amount * _tva.GetTaux()) / 100;
            _orders.Add(order);
            return order;

        }
        /// <summary>
        /// Gets all the orders
        /// </summary>
        /// <returns></returns>
        public async Task<List<Order>> GetAllOrders()
        {
            await Task.Delay(1000);
            return  _orders;
        }
    }
}
