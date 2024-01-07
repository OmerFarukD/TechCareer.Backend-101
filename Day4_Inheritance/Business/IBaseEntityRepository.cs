namespace Day4_Inheritance.Business;

public interface IBaseEntityRepository<TEntity>
{
    public void Add(TEntity entity);
    public void Update(TEntity entity);
    public void Delete(TEntity entity);
    public void GetAll();

}
