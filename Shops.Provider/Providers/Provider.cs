using System;
using System.Collections.Generic;
using System.Data.Entity;
using Shops.Provider.ShopsProviderContext;

namespace Shops.Provider.Providers
{
    public abstract class Provider<TModel>
        where TModel : class
    {
        public ShopsContext db;
        public Provider()
        {
            db = new ShopsContext();
        }

        public IEnumerable<TModel> GetAll()
        {
            return db.Set<TModel>();
        }
        public TModel GetItem(int id)
        {
            return db.Set<TModel>().Find(id);
        }
        public void Delete(int id)
        {
            var item = db.Set<TModel>().Find(id);
            if (item != null)
                db.Set<TModel>().Remove(item);
            db.SaveChanges();
        }
        public void Create(TModel model)
        {
            db.Set<TModel>().Add(model);
            db.SaveChanges();
        }
        public void Update(TModel model)
        {
            db.Entry<TModel>(model).State = EntityState.Modified;
            db.SaveChanges();
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
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
