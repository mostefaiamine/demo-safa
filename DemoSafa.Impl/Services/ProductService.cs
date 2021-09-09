using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSafa
{
    /// <summary>
    /// This class is the implementation of the product service
    /// </summary>
    public class ProductService : IProductService
    {
        /// <summary>
        /// Gets the list of all products
        /// </summary>
        /// <returns>The list of product</returns>
        public async Task<List<Product>> GetAllProducts()
        {
            await Task.Delay(1000);
            return new List<Product>
            {
                FakeData.Products.Ditergent,
                FakeData.Products.Soap,
                FakeData.Products.ToiletPaper
            };
        }

        /// <summary>
        /// Gets the price of a given product
        /// </summary>
        /// <param name="productCode">The product code</param>
        /// <returns>The product price</returns>
        public async Task<decimal> GetProductPrice(string productCode)
        {
            await Task.Delay(1000);
            switch(productCode)
            {
                case FakeData.ProductCodes.DITERGENT:
                    return 250;
                case FakeData.ProductCodes.SOAP:
                    return 350;
                case FakeData.ProductCodes.TOILET_PAPER:
                    return 280;
            }
            return 0;
        }
    }
}
