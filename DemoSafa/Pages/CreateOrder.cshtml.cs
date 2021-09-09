using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoSafa.Pages
{
    /// <summary>
    /// This page is used for order creation
    /// </summary>
    public class CreateOrderModel : PageModel
    {
        #region private fields
        /// <summary>
        /// The order service
        /// </summary>
        private readonly IOrderService _orderS;

        /// <summary>
        /// The product service
        /// </summary>
        private readonly IProductService _productS;

        #endregion

        public CreateOrderModel(IProductService prs, IOrderService ord)
        {
            _productS = prs;
            _orderS = ord;
        }

        /// <summary>
        /// Displayed when the page loads
        /// </summary>
        /// <returns></returns>
        public async Task OnGet()
        {
            SelectedProductCode = FakeData.Products.Soap.Code;
            ProductItems = new List<SelectListItem>();
            var products = await _productS.GetAllProducts();
            foreach(var p in products)
            {
                ProductItems.Add(new SelectListItem(p.Name, p.Code));
            }
        }

        /// <summary>
        /// Displayed when 
        /// </summary>
        /// <returns></returns>
        public async Task OnPost() {
            var order = await _orderS.CreateOrder(SelectedProductCode, Quantity);
            var message = $"Order Created Successfully. Order Id {order.Id}, Amount : {order.Amount}";
            TempData["message"] = message;
           
        }



        /// <summary>
        /// Product items
        /// </summary>
        public List<SelectListItem> ProductItems { get; set; }

        /// <summary>
        /// The product quantity
        /// </summary>
        [BindProperty]
        public int Quantity { get; set; } = 1;

        /// <summary>
        /// Select product code
        /// </summary>
        [BindProperty]
        public string SelectedProductCode { get; set; }

    

    }
}
