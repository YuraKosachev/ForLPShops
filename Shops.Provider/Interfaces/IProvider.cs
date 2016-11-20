using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shops.Provider.Interfaces
{
    public interface IProvider<TModel> : IDisposable
        where TModel : class
    {
        IEnumerable<TModel> GetAll();
        TModel GetItem(int id);
        void Delete(int id);
        void Create(TModel model);
        void Update(TModel model);
    }
}
