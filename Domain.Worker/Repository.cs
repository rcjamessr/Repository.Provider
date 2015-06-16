
using System;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Domain.Provider;

namespace Domain.Worker
{
    //public class Repository<T> : IRepository<T>, IDisposable where T : Base
    //{

    //    //private DataContext data;
    //    //public DataContext GetData() { return data; }
    //    ////private DbSet<T> table = null;
    //    //private IQueryable<T> table = null;
    //    //private List<string> validationResults;
    //    //private T inserted = null;
    //    //private IAuthorizedUserProvider authorization;
    //    //public IAuthorizedUserProvider Authorization { get { return authorization; } }
    //    //public DataContext Data { get { return data; } }
    //    //private IUserInfo userInfo;
    //    //public IUserInfo UserInfo { get { return userInfo; } }
    //    //public IAuthorizedUserProvider GetAuthorization() { return authorization; }
    //    //public void Dispose() 
    //    //{
    //    //    Dispose(true);
    //    //}
    //    //protected virtual void Dispose(bool disposing)
    //    //{
    //    //    if (disposing)
    //    //    {
    //    //        data.Dispose();
    //    //    }
    //    //}
    //    //public Repository(DataContext database, IAuthorizedUserProvider authorizationProvider)
    //    //{
    //    //    this.data = database;
    //    //    table = data.Set<T>();
    //    //    authorization = authorizationProvider;
    //    //    //authorization.SetDataContext(this.data);
    //    //    userInfo = authorization.GetUserInfo();
    //    //}
    //    ////public DbSet<T> Table() { return table; }
    //    //public IQueryable<T> GetTable() { return table; }
    //    //public IQueryable<T> Table() { return table; }
    //    //public IUserInfo GetUserInfo()
    //    //{
    //    //    return userInfo;
    //    //}
    //    //public IEnumerable<T> SelectAll()
    //    //{
    //    //    return this.table.ToList();
    //    //}
    //    //public IEnumerable<T> Select(Func<T, bool> expression)
    //    //{
    //    //    return table.Where(expression);
    //    //}
    //    //public IEnumerable<T> SelectRecords(Expression<Func<T, bool>> expression)
    //    //{
    //    //    return table.Where(expression);
    //    //}
    //    //public T SelectByID(object id)
    //    //{
    //    //    return table.Where(m => m.Id == (int)id).FirstOrDefault();
    //    //    //return table.Find(id);
    //    //}
    //    //public void Insert(T obj)
    //    //{
    //    //    inserted = obj;
    //    //    //table.Add(inserted);

    //    //    var entry = data.Entry<T>(obj);
    //    //    entry.State = EntityState.Added;


    //    //}
    //    //public T Inserted()
    //    //{
    //    //    return inserted;
    //    //}
    //    //public void Update(T obj)
    //    //{
    //    //    var entry = data.Entry<T>(obj);
            
            
            

    //    //    if (entry.State == EntityState.Detached)
    //    //    {
    //    //        T attachedEntity = table.SingleOrDefault(e => e.Id == obj.Id);
    //    //        if (attachedEntity != null)
    //    //        {
    //    //            var attachedEntry = data.Entry(attachedEntity);
    //    //            attachedEntry.CurrentValues.SetValues(obj);
    //    //        }
    //    //        else
    //    //        {
    //    //            entry.State = EntityState.Modified;
    //    //        }
    //    //    }

    //    //}
    //    //public void Delete(object id)
    //    //{
    //    //    //T existing = table.Find(id);
    //    //    //table.Remove(existing);

    //    //    T attachedEntity = table.SingleOrDefault(e => e.Id == (int)id);
    //    //    var entry = data.Entry<T>(attachedEntity);
    //    //    entry.State = EntityState.Deleted;

    //    //}
    //    //public void Save() 
    //    //{
    //    //    try
    //    //    {
    //    //        data.SaveChanges(); 
    //    //    }
    //    //    catch (DbEntityValidationException ex)
    //    //    {
    //    //        this.error(ex);
    //    //    }
            
    //    //}
    //    //private void error(DbEntityValidationException ex)
    //    //{
    //    //    var errorMessages = ex.EntityValidationErrors
    //    //            .SelectMany(x => x.ValidationErrors)
    //    //            .Select(x => x.ErrorMessage);

    //    //    // Join the list to a single string.
    //    //    var fullErrorMessage = string.Join("; ", errorMessages);

    //    //    // Combine the original exception message with the new one.
    //    //    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

    //    //    // Throw a new DbEntityValidationException with the improved exception message.
    //    //    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
    //    //}
    //    //public bool Errors() { throw new NotImplementedException(); }
    //    //public List<string> ValidationResults() { return validationResults; }
    //    //public bool Valid()
    //    //{
    //    //    return GetValidationResultsList().Count == 0;
    //    //}
    //    //public List<string> GetValidationResultsList()
    //    //{
    //    //    if (validationResults == null) validationResults = new List<string>();
    //    //    addValidationResult();
    //    //    return validationResults;
    //    //}
    //    //private void addValidationResult()
    //    //{
    //    //    List<System.Data.Entity.Validation.DbEntityValidationResult>
    //    //        results = data.GetValidationErrors().ToList();
    //    //    foreach (DbEntityValidationResult result in results)
    //    //    {
    //    //        List<DbValidationError> errors = result.ValidationErrors.ToList();
    //    //        foreach (DbValidationError e in errors)
    //    //        {
    //    //            validationResults.Add(e.ErrorMessage);
    //    //        }
    //    //    }
    //    //    //SessionData.Add_ValidationResults(validationResults);
    //    //}
    //}
}
