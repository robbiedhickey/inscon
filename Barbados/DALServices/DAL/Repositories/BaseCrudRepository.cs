namespace Enterprise.DALServices.DAL.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    using Enterprise.DALServices.DAL.Models;
    using Enterprise.DALServices.DAL.Repositories.Interfaces;


    /// <summary>
    /// BaseRepository to encapsulate common CRUD functionality. Members are virtual and designed to be overriden
    /// for special use cases. 
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public abstract class BaseCrudRepository<TEntity> : IBaseCrudRepository<TEntity> where TEntity : class
    {
        protected IUnitOfWork<EnterpriseDbContext> UnitOfWork { get; private set; }
        protected IDbSet<TEntity> EntitySet { get; private set; }
        protected EnterpriseDbContext Context { get; private set; }

        protected BaseCrudRepository(IUnitOfWork<EnterpriseDbContext> unitOfWork)
        {
            UnitOfWork = unitOfWork;
            EntitySet = unitOfWork.Context.Set<TEntity>();
            Context = unitOfWork.Context;
        }

        public virtual TEntity GetByID(int id)
        {
            return EntitySet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return EntitySet;
        }

        public virtual IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> predicate)
        {
            return EntitySet.Where(predicate);
        }

        public virtual void Add(TEntity entity)
        {
            EntitySet.Add(entity);
        }

        public virtual void Remove(TEntity entity)
        {
            EntitySet.Remove(entity);
        }

        public virtual void Update(TEntity entity)
        {
            UnitOfWork.Context.Entry(entity).State = EntityState.Modified;
        }

    }
}