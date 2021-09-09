using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSafa
{
    /// <summary>
    /// This services exposes product operations
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Gets the list of all products
        /// </summary>
        /// <returns>The list of product</returns>
        Task<List<Product>> GetAllProducts();

        /// <summary>
        /// Gets the price of a given product
        /// </summary>
        /// <param name="productCode">The product code</param>
        /// <returns>The product price</returns>
        Task<Decimal> GetProductPrice(string productCode);
    }
}
