using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoSafa.Pages
{
    /// <summary>
    /// This page displays the list of orders
    /// </summary>
    public class OrderListModel : PageModel
    {
        /// <summary>
        /// The order service
        /// </summary>
        private readonly IOrderService _orderS;

        public OrderListModel(IOrderService ord)
        {
            _orderS = ord;
        }

        public async Task OnGet()
        {
            Orders = await _orderS.GetAllOrders();
        }

        /// <summary>
        /// The list of orders
        /// </summary>
        public List<Order> Orders { get; set; }
    }
}
