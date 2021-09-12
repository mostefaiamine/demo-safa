using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoSafa.Tests
{
    public class OrderServiceTest
    {

        [Fact(DisplayName = "Get All Order")]
        public async Task GetAllTest()
        {
            ITVAService tva = new TVAService();
            IProductService prdS = new ProductService();
            IOrderService orders = new OrderService(prdS, tva);
            var list = await orders.GetAllOrders();
            Assert.NotNull(list);
        }

        [Fact(DisplayName = "Create Order")]
        public async Task GetACreateOrderTestllTest()
        {
            IProductService prdS = new ProductService();
            ITVAService tva = new TVAService();
            IOrderService orders = new OrderService(prdS, tva);
            var list = await orders.GetAllOrders();
            var count = list.Count;
            var order = await orders.CreateOrder(FakeData.ProductCodes.SOAP, 3);
            Assert.NotNull(list);
            Assert.NotNull(order);
            Assert.Equal(1249.5m, order.Amount);
            Assert.Equal(DateTime.Now.Date, order.Date.Date);
            Assert.Equal(1, order.Id);
            Assert.Equal(FakeData.ProductCodes.SOAP, order.Product);
            Assert.Equal(3, order.Quantity);
            Assert.Equal(OrderStatus.Pending, order.Status);
            Assert.Equal(350, order.UnitPrice);
            var list2 = await orders.GetAllOrders();
            Assert.Equal(count + 1, list2.Count);
        }
    }
}
