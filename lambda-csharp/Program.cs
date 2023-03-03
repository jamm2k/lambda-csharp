using lambda_csharp;

List<Product> list = new List<Product>();

list.Add(new Product("Cadeira", 200.00));
list.Add(new Product("Armario", 700.00));
list.Add(new Product("PC", 3000.00));

list.Sort();

foreach (Product p in list)
{
    Console.WriteLine(p);
}
