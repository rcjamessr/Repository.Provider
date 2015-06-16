using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Provider
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> SelectAll();
        IQueryable<T> GetTable();
        //DataContext GetData();
        IEnumerable<T> Select(Func<T, bool> expression);
        T SelectByID(object id);
        T Inserted();
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
        bool Errors();
        
        List<string> ValidationResults();
    }
}
