using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Provider
{
    public interface IWorker
    {
        void Commit();
        //IRepository<Base> Base { get; }
      

        //Base NewRecord<T>(IRepository<T> repo, T item) where T : Base;

        //Base CreateRecord<T>(IRepository<T> repo, T item) where T : Base;
        //void CreateRecords<T>(IRepository<T> repo, T[] items) where T : Base;
        //Base UpdateRecord<T>(IRepository<T> repo, T item) where T : Base;
        //void Truncate<T>(IRepository<T> repo, int id) where T : Base;

        //void UpdateRecords<T>(IRepository<T> repo, T[] items) where T : Base;
        //void DeleteRecords<T>(IRepository<T> repo, T[] items) where T : Base;
        //void TruncateRecords<T>(IRepository<T> repo, T[] items) where T : Base;

        //void MarkRecordsForDelete<T>(IRepository<T> repo, T[] items) where T : Base;
        //void MarkRecordForDelete<T>(IRepository<T> repo, T item) where T : Base;

        //Base GetWith<T>(string withThis, Func<T, bool> expression) where T : Base;
        //IEnumerable<T> GetRecordsWith<T>(Func<T, bool> expression,string withThis) where T : Base;
        //IEnumerable<T> GetRecordsWith<T>(Func<T, bool> expression, string withThis, string withThis2) where T : Base;
        //IEnumerable<T> GetRecordsWith<T>(Func<T, bool> expression, string withThis, string withThis2, string withThis3) where T : Base;


        //IEnumerable<T> GetAllRecordsWith<T>(string withThis) where T : Base;
        //IEnumerable<T> GetAllRecordsWith<T>(string withThis, string withThis2) where T : Base;
        //IEnumerable<T> GetAllRecordsWith<T>(string withThis, string withThis2, string withThis3) where T : Base;


        //void Dispose();

        //Base Get<T>(Func<T, bool> expression) where T : Base;
        //IEnumerable<T> GetRecords<T>(Func<T, bool> expression) where T : Base;

        //T GetRecordWith<T>(int Id, string withThis) where T : Base;

        //T GetRecordWith<T>(int Id, string withThis, string withThis2) where T : Base;

        //T GetRecordWith<T>(int Id, string withThis, string withThis2, string withThis3) where T : Base;

        //bool ExecuteProcedure(string procedureName, object[] param);

        //IQueryable<T> GetRecords<T>() where T : Base;

        //IEnumerable<T> ExecuteProcedure<T>(string procedureName, object[] parameters) where T : Base;
        //void CatchError(Exception ex);
        //Exception GetError();

    }
}
