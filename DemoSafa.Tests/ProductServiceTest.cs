using System;
using System.Threading.Tasks;
using Xunit;

namespace DemoSafa.Tests
{
    public class ProductServiceTest
    {
        /// <summary>
        /// Tests that all products works
        /// </summary>
        [Fact(DisplayName = "Get All Products")]
        public async Task GetAllTest()
        {
            IProductService prdS = new ProductService();
            var products = await prdS.GetAllProducts();
            Assert.NotEmpty(products);
        }

        /// <summary>
        /// Tests that price providing works
        /// </summary>
        /// <returns></returns>
        [Fact(DisplayName = "Get Product Price")]
        public async Task GetPriceTest()
        {
            IProductService prdS = new ProductService();
            var price = await prdS.GetProductPrice(FakeData.ProductCodes.DITERGENT);
            Assert.Equal(250, price);
        }
    }
}
