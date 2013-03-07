namespace Enterprise.DALServices.DAL.Repositories.Interfaces
{
    using System.Linq;

    public interface ICrudRepository<TEntity> where TEntity : class
    {
        TEntity GetByID(int id);
        IQueryable<TEntity> GetAll();
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
    }
}
