namespace Day4_Inheritance.Business;

public class ProductPostgreSqlRepository : IProductRepository
{
    public void Add(Product product)
    {
        Console.WriteLine("Ürünler tablosuna eklendi : (PostgreSql)");
        Console.WriteLine(product);
    }

    public void Delete(Product product)
    {
        Console.WriteLine("Ürünler tablosundan silindi: (PostgreSql)");
        Console.WriteLine(product);
    }

    public void GetAll()
    {
        Console.WriteLine("Ürünler listelendi (PostgreSql)");
    }

    public void GetByProductName()
    {
        Console.WriteLine("Ürün ismine göre getirildi. (PostgreSql)");
    }

    public void GetByStock()
    {
        Console.WriteLine("Ürün stoğa göre getirildi. (PostgreSql)");
    }

    public void Update(Product product)
    {
        Console.WriteLine("Ürünler tablosunda güncellendi: (PostgreSql)");
        Console.WriteLine(product);
    }
}
