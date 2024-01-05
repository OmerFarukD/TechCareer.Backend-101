//senaryo : bir e ticaret sistemindeki ürünleri ve kategorileri listeleyen
// uygulama yapınız.

using Day3_OOP;
// 1. Yöntem
Product product = new Product()
{
    Name = "Msi Laptop",
    Price = 25000,
    Stock = 250
};

Product product1 = new Product();
product1.Name = "Monster Laptop";
product1.Price = 29000;
product1.Stock = 260;

ProductManager manager = new ProductManager();
manager.Add(product);
manager.Add(product1);
manager.GetAll();
Console.WriteLine("********************************************");
manager.GetByName("Ap");







