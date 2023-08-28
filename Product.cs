class Product {
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product()
    {
        
    }

    public Product(string name, double price, int qty = 0)
    {
        Name = name;
        Price = price;
        Quantity = qty;
    }

    public void AddToProductManager(ProductManager pm)
    {
        pm.AddProduct(this);
    }
}