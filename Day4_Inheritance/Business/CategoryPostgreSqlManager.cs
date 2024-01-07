namespace Day4_Inheritance.Business;

public class CategoryPostgreSqlManager : ICategoryRepository
{
    public void Add(Category category)
    {
        Console.WriteLine("Kategori PostgreSql veri tabanına eklendi.");
        Console.WriteLine(category);
    }
    public void Update(Category category)
    {
        Console.WriteLine("Kategori PostgreSql veri tabanında güncellendi.");
        Console.WriteLine(category);
    }
    public void Delete(Category category)
    {
        Console.WriteLine("Kategori PostgreSql veri tabanından silindi.");
        Console.WriteLine(category);
    }

    public void GetAll()
    {
        Console.WriteLine("Kategoriler Listelendi (PostgreSql)");
    }
}
