class ProductManager
{
    private readonly string _catalogFilePath;
    private List<string> Lines { get; set; }
    public ProductManager(string catalogPath)
    {
        _catalogFilePath = catalogPath;
        Lines = File.ReadAllLines(_catalogFilePath).ToList();
    }

    public void PrintAllProductsToConsole()
    {
        System.Console.WriteLine("");
        System.Console.WriteLine(_catalogFilePath.ToUpper());
        int count = 1;
        foreach (var line in Lines)
        {
            System.Console.WriteLine($"#{count}. {line}");
            count++;
        }
    }

    public void AddProduct(string name, double price, int qty)
    {
        Lines.Add($"{name}, {price}, {qty}");
    }
    
    public void AddProduct(Product p)
    {
        Lines.Add($"{p.Name}, {p.Price}, {p.Quantity}");
    }
    
    
    // public static void PrintAllProductsToConsole()
    // {
    //     System.Console.WriteLine("DEPRECATED");
    //     string[] lines = File.ReadAllLines("catalog.csv");
    //     foreach (string line in lines)
    //     {
    //         System.Console.WriteLine(line);
    //     }
    // }
}

// class Console
// {
//     public static void WriteLine(string line){
//         //...
//     }
// }

// class Calculator
// {
//     public static int CalculateSevenMinusTwo()
//     {
//         return 7-2;
//     }
// }