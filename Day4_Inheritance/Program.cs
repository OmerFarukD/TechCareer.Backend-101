// Bir sistemde ürün kategori ve kullanıcı tabloları olsun veri tabanı olduğunu varsayalım ve gerekli
// işlemleri simüle ediniz.
// Bu işlemeleri MsSQL kullanıldığını varsayarak simüle ediniz.
// Bu işlemlerin alternatifi olan PostgreSql operasyonlarını da yazınız.


// Polymorphism
using Day4_Inheritance;
using Day4_Inheritance.Business;

Product product = new Product()
{
    Id = 1,
    Name = "Msi Laptop",
    Price = 35000,
    Stock =100
};

Category category = new Category()
{
    Id = 1,
    Name = "Teknoloji"
};

User user = new User()
{
    Id = 1,
    Name = "İhsan",
    Email = "ihsan0144@gmail.com",
    Password = "123654879"
};
//Console.WriteLine(user);
//Console.WriteLine("*****************************");
//Console.WriteLine(product);
//Console.WriteLine("*****************************");
//Console.WriteLine(category);

ICategoryRepository sqlCategoryManager = new CategoryPostgreSqlManager();
sqlCategoryManager.Add(category);
Console.WriteLine("**********************");
sqlCategoryManager.Update(category);
Console.WriteLine("**********************");
sqlCategoryManager.Delete(category);
Console.WriteLine("**********************");
sqlCategoryManager.GetAll();


IProductRepository productRepository = new ProductMsSqlRepository();
productRepository.Add(product);
Console.WriteLine("**********************");
productRepository.Update(product);
Console.WriteLine("**********************");
productRepository.GetAll();
Console.WriteLine("**********************");
productRepository.Delete(product);
Console.WriteLine("**********************");
productRepository.GetByProductName();
Console.WriteLine("**********************");
productRepository.GetByStock();
Console.WriteLine("**********************");






