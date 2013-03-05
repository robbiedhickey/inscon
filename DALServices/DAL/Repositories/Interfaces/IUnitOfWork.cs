namespace Enterprise.DALServices.DAL.Repositories.Interfaces
{
    using System;
    using System.Data.Entity;

    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        void Commit();
        void Rollback();
        TContext Context { get; }
    }
}