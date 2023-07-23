using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp
{
    public class Product
    {
            public string ProductName { get; set; }
            public decimal ProductPrice { get; set; }

        public Product(string productName, decimal productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }
    }
}
