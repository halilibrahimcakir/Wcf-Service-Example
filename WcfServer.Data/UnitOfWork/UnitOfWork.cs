using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServer.Data.Context;
using WcfServer.Data.Repository;

namespace WcfServer.Data.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {

        #region Variable
        private readonly MarketBarkodDBEntities _contex;

        private ProductsRepository _productsRepository = null;
     
        #endregion


        #region Ctor
        public UnitOfWork()
        {
            _contex = new MarketBarkodDBEntities();
        }

        #endregion

        #region Repository
        public ProductsRepository ProductsRepository
        {
            get
            {
                if (_productsRepository == null)
                {
                    _productsRepository = new ProductsRepository(_contex);
                }
                return _productsRepository;
            }
        }

        #endregion

        #region Transactions
        public void BeginTransaction()
        {
            _contex.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _contex.Database.CurrentTransaction.Commit();
        }

        public void RollbackTransaction()
        {
            _contex.Database.CurrentTransaction.Rollback();
        }

        public int SaveChanges()
        {
            try
            {
                return _contex.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        #endregion

        #region Disposable
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            disposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion
    }
}
