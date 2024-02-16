// See https://aka.ms/new-console-template for more information

using ProductDetailsConsoleAppAssignment;

SortedList<string, Product> obj = new SortedList<string, Product>()
{
    {
        "Hp|Laptop",
        new Product()
        {
            Pname="Laptop",
            Pprice=90998,
            PBrand="Hp",
            ManufacturingDate=new DateTime(2022, 2, 1),
            ExpiryDate=new DateTime(2023, 1, 1)
        }
    },
    {"Television|Sony",
    new Product()
    {
       Pname="Television",
       Pprice=78000,
       PBrand="Sony",
       ManufacturingDate=new DateTime(2021,2,2),
       ExpiryDate=new DateTime(2023,9,9)
    }
    },
     {"HeadPhones|Bose",
    new Product()
    {
       Pname="HeadPhones",
       Pprice=78000,
       PBrand="Bose",
       ManufacturingDate=new DateTime(2021,2,2),
       ExpiryDate=new DateTime(2023,9,9)
    }
    } };
Console.WriteLine("Product List:");
foreach (var product in obj)
{
    string[] keyParts = product.Key.Split('|');
    string brand = keyParts[0];
    string name = keyParts[1];
    Console.WriteLine($"Brand: {brand}, Name: {name}, Price: {product.Value.Pprice}, Manufacturing Date: {product.Value.ManufacturingDate.ToShortDateString()}, Expiry Date: {product.Value.ExpiryDate.ToShortDateString()}");
}
        
