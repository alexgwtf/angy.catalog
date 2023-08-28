// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Worldddd!");


using System.ComponentModel;

ProductManager shoes = new ProductManager("shoes.csv");
shoes.PrintAllProductsToConsole();

shoes.AddProduct("aaaaa", 42D, 10);

shoes.PrintAllProductsToConsole();

string name = "shoes";
double price = 55D;
int qty = 5;

shoes.AddProduct(name, price, qty);
shoes.PrintAllProductsToConsole();



// declare drink-related product manager
var drinks = new ProductManager("drinks.csv");

// print all drinks
drinks.PrintAllProductsToConsole();

// add a new drink
string drinkName = "wine";
double drinkiPrice = 15D;
int drinkQuantity = 100;

drinks.AddProduct(drinkName, drinkiPrice, drinkQuantity);


// print all drinks again
drinks.PrintAllProductsToConsole();

// declare a Product
Product whiskey;

// assign value to the Product
whiskey = new Product();

// int a = 5;
// int a = 7 - 2;

// above is same as
// Product whiskey = new Product();

// assign values to the Product properties
whiskey.Name = "Jack";
whiskey.Price = 150D;
whiskey.Quantity = 12;

// add the product to the product manager
drinks.AddProduct(whiskey);

drinks.PrintAllProductsToConsole();


// declare a Product variable for a new product

Product lavazza = new Product("Lavazza", 7D, 5);
Product dolceGusto = new Product("Dolce gusto", 7D);

// add the new product to the drinks catalog
drinks.AddProduct(lavazza);
drinks.AddProduct(dolceGusto);


// print all drinks again
drinks.PrintAllProductsToConsole();



// ---------------------- alex
var juice = new Product("Cappy Orange", 4.5D, 700);
juice.AddToProductManager(drinks);
drinks.PrintAllProductsToConsole();

// ----------------------------------------------

shoes.AddProduct("Quesqua", 150D, 2);
shoes.PrintAllProductsToConsole();

// ------------------------------------

var decathlon = new Product();

decathlon.Name = "Decathlon";
decathlon.Price = 100;
decathlon.Quantity = 11;

shoes.AddProduct(decathlon);
shoes.PrintAllProductsToConsole();

// --------------------------
shoes.AddProduct(new Product("Convers", 15, 1));
shoes.PrintAllProductsToConsole();