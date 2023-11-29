class Program
{
    static void Main(string[] args)
    {
        List<Category> categories = new List<Category>
        {
            new Category{CategoryId=1, CategoryName ="Bilgisayar"},
            new Category{CategoryId=2, CategoryName="Telefon"}
        };

        List<Product> products = new List<Product>
        {
            new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop",QuantityPerUnit="32 GB ram", UnitPrice=10000, UnitsInStock=5},
            new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop",QuantityPerUnit="16 GB ram", UnitPrice=18000, UnitsInStock=3},
            new Product{ProductId=3, CategoryId=1, ProductName="Hp Laptop",QuantityPerUnit="8 GB ram", UnitPrice=6000, UnitsInStock=2},
            new Product{ProductId=4, CategoryId=2, ProductName="Samsung Telefon",QuantityPerUnit="4 GB ram", UnitPrice=5000, UnitsInStock=15},
            new Product{ProductId=5, CategoryId=2, ProductName="Apple Telefon",QuantityPerUnit="4 GB ram", UnitPrice=8000, UnitsInStock=0},

        };

        //Single Line Query

        var result1 = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice);
        foreach (var product in result1)
        {
            Console.WriteLine(product.ProductName);
        }

        Console.WriteLine("Algoritmik...................");
        foreach (var product in products)
        {
            if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
            {
                Console.WriteLine(product.ProductName);

            }
        }
        Console.WriteLine("Linq.........................");

        var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

        foreach (var product in result)
        {
            Console.WriteLine(product.ProductName);
        }

        Console.ReadLine();

    }

    private static Product FindTest(List<Product> products)
    {
        //Lambda
        var result = products.Find(p => p.ProductId == 3);
        Console.WriteLine(result.ProductName);
        return result;
    }

    private static void AnyTest(List<Product> products)
    {
        var result1 = products.Any(p => p.ProductName == "Acer Laptop");
        Console.WriteLine(result1);
    }
}
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
