
using InvoiceApp;

Console.WriteLine("How many products are you selling ?\n");
var numberOfProducts = int.Parse(Console.ReadLine());

List<Product> products = new List<Product>();

for (var i = 0; i < numberOfProducts; i++)
{
    Console.WriteLine($"Insert product {i + 1} name: ");
    var name = Console.ReadLine();
    Console.WriteLine($"Insert product {i + 1} price: ");
    var price = decimal.Parse(Console.ReadLine());

    Product product = new Product(name, price);
    products.Add(product);
}

Console.WriteLine("Insert name of the company: ");
var companyName = Console.ReadLine();

if (companyName == "" || companyName == null)
{
    Console.WriteLine("Please insert name of the company: ");
    companyName = Console.ReadLine();
}
else
{
    Invoice invoice = new Invoice(companyName, products);

    invoice.GetInvoice();
}

