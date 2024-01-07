

namespace Day4_Inheritance.Business;

public interface IProductRepository : IBaseEntityRepository<Product>
{
    public void GetByProductName();
    public void GetByStock();

}
