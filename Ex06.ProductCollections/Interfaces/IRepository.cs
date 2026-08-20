using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06.ProductCollections.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        bool Update(T entity);
        bool Delete(string id);
        T? GetByID(string id);
        IReadOnlyList<T> GetAll();
    }
}
