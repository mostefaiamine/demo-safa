using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoSafa.Tests
{
    public class TVAServiceTest
    {
        [Fact(DisplayName = "Tester TVA")]
        public void TVATest()
        {
            ITVAService ser = new TVAService();
            var taux = ser.GetTaux();
            Assert.Equal(19, taux);
        }
    }
}
