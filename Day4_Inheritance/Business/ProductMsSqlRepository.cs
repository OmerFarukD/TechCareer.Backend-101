namespace Day4_Inheritance.Business;
public class ProductMsSqlRepository : IProductRepository
{
    public void Add(Product product)
    {
        Console.WriteLine("Ürünler tablosuna eklendi : (MsSql)");
        Console.WriteLine(product);
    }

    public void Delete(Product product)
    {
        Console.WriteLine("Ürünler tablosundan silindi: (MsSql)");
        Console.WriteLine(product);
    }

    public void GetAll()
    {
        Console.WriteLine("Ürünler listelendi (MsSql)");
    }

    public void GetByProductName()
    {
        Console.WriteLine("Ürün ismine göre getirildi. (MsSql)");
    }

    public void GetByStock()
    {
        Console.WriteLine("Ürün stoğa göre getirildi. (MsSql)");
    }

    public void Update(Product product)
    {
        Console.WriteLine("Ürünler tablosunda güncellendi: (MsSql)");
        Console.WriteLine(product);
    }

}
