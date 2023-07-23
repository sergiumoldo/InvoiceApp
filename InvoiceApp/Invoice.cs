using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp
{


    public class Invoice
    {
        const decimal TaxRate = 0.19M;
        private static int lastInvoiceNumber = 0;

        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; }
        public decimal TaxAmount {
            get
            {
                return Subtotal * TaxRate;
            }
        }
        public decimal Subtotal
        {
            get
            {
                decimal subtotal = 0;
                foreach (var item in Products)
                {
                    subtotal += item.ProductPrice;
                }
                return subtotal;
            }
        }
        public decimal Total
        {
            get
            {
                return Subtotal + (Subtotal * TaxRate);
            }
        }

        public Invoice(string customerName, List<Product> products)
        {
            lastInvoiceNumber++;
            InvoiceNumber = lastInvoiceNumber;
            InvoiceDate = DateTime.Now;
            CustomerName = customerName;
            Products = products;
        }

        public List<Product> AllSelledProducts()
        {
            List<Product> list = new List<Product>();

            foreach (var item in Products)
            {
                list.Add(item);
            }
            return list;
        }

        public void GetInvoice()
        {
            var productsDetails = AllSelledProducts();

            Console.WriteLine
            (
            $"Invoice Number: {InvoiceNumber}\n" +
            $"Invoice Date: {InvoiceDate:yyyy-MM-dd}\n" +
            $"Customer Name: {CustomerName}\n"
            );

            foreach (var item in productsDetails)
            {
                Console.WriteLine($"ProductName: {item.ProductName} ProductPrice: {item.ProductPrice}\n");
            }

            Console.WriteLine
            (
            $"Subtotal: {Subtotal:C}\n" +
            $"Tax Rate({TaxRate}): {TaxAmount:C}\n" +
            $"Total Amount: {Total:C}"
            );
        }
    }
}
