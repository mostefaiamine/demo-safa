using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSafa
{
    /// <summary>
    /// This class exposes fake data
    /// </summary>
    public static class FakeData
    {
        /// <summary>
        /// Product codes
        /// </summary>
        public static class ProductCodes
        {
            /// <summary>
            /// Ditergent
            /// </summary>
            public const string DITERGENT = "DIT";

            /// <summary>
            /// Soap
            /// </summary>
            public const string SOAP = "SOA";

            /// <summary>
            /// Toilet paper
            /// </summary>
            public const string TOILET_PAPER = "TP";
        }

        /// <summary>
        /// This class exposes a list of fake products
        /// </summary>
        public static class Products
        {
            /// <summary>
            /// Ditergent product
            /// </summary>
            public static readonly Product Ditergent = new Product { Code = ProductCodes.DITERGENT, Name = "Ditergent" };

            /// <summary>
            /// Soap product
            /// </summary>
            public static readonly Product Soap = new Product { Code = ProductCodes.SOAP, Name = "Soap" };

            /// <summary>
            /// Toilet paper
            /// </summary>
            public static readonly Product ToiletPaper = new Product { Code = ProductCodes.TOILET_PAPER, Name = "Toilet Paper" };
        }
    }
}
