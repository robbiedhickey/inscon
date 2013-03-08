namespace Enterprise.DALServices.DAL.Repositories
{
    using System;

    using Enterprise.DALServices.DAL.Models;
    using Enterprise.DALServices.DAL.Repositories.Interfaces;

    public class EfUnitOfWork : IUnitOfWork<EnterpriseDbContext>
    {
        private bool disposed;

        public EnterpriseDbContext Context { get; private set; }

        public EfUnitOfWork()
            : this(new EnterpriseDbContext())
        {
        }

        public EfUnitOfWork(EnterpriseDbContext context)
        {
            Context = context;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Rollback()
        {
            Context.Dispose();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}