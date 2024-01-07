namespace Day4_Inheritance.Business;

public class CategoryMsSqlManager : ICategoryRepository
{
    public void Add(Category category)
    {
        Console.WriteLine("Kategori MSSql veri tabanına eklendi.");
        Console.WriteLine(category);
    }
    public void Update(Category category)
    {
        Console.WriteLine("Kategori MSSql veri tabanında güncellendi.");
        Console.WriteLine(category);
    }
    public void Delete(Category category)
    {
        Console.WriteLine("Kategori MSSql veri tabanından silindi.");
        Console.WriteLine(category);
    }

    public void GetAll()
    {
        Console.WriteLine("Kategoriler Listelendi (MsSql)");
    }
}
