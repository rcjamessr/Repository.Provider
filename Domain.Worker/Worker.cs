using System;
using System.Collections.Generic;

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Provider;


namespace Domain.Worker
{
    //public class Worker: IWorker, IDisposable
    //{
        
    //    //private DataContext _datacontext;
    //    //private IAuthorizedUserProvider _authorization;
    //    //private IRepository<Answer_Lookup> _answer_lookup;
    //    //private IRepository<Answer_Type> _answer_type;
    //    //private IRepository<Answer_Lookup_Value> _answer_lookup_value;
    //    //private IRepository<SurveyReport> _surveyreports;
    //    //private IRepository<SurveyMaster> _surveymasters;
    //    //private IRepository<SurveyMasterRole> _surveymasterroles;
    //    //private IRepository<SurveySection> _surveysections;
    //    //private IRepository<SurveyInfo> _surveyinfoes;
    //    //private IRepository<Acres_Surveyed> _acres_surveyed;
    //    //private IRepository<Question> _questions;
    //    //private IRepository<Questionnaire> _Questionnaires;
    //    //private IRepository<Park> _parks;
    //    //private IRepository<Other_Project> _other_project;
    //    //private IRepository<Museum> _museums;
    //    //private IRepository<Funding> _fundings;
    //    //private IRepository<SurveyFile> _surveyfiles;
    //    //private IRepository<Spending> _spendings;
    //    //private IRepository<Answer> _answers;
    //    //private IRepository<QuestionSection> _questionsections;
    //    //private IRepository<Audit_Question> _audit_question;
    //    //private IRepository<Audit_Answer> _audit_answer;
    //    //private IRepository<Answer_Default> _answer_default;
    //    //private IRepository<SurveyRole> _surveyroles;
    //    //private IRepository<SurveyItem> _surveyitems;
    //    //private IRepository<Query> _queries;
    //    //private IRepository<QueryCriteria> _querycriterias;


    //    //private Base _inserted;
    //    //private Base _record;
    //    //private Base _udpated;
    //    //private Exception _error;
        
    //    //public IRepository<Answer_Lookup> Answer_Lookup 
    //    //{
    //    //    get
    //    //    {
    //    //        if (_answer_lookup == null)
    //    //        {
    //    //            _answer_lookup = new Repository<Answer_Lookup>(_datacontext, _authorization);
    //    //        }
    //    //        return _answer_lookup;
    //    //    }
    //    //}
    //    //public IRepository<Answer_Type> Answer_Type
    //    //{
    //    //    get
    //    //    {
    //    //        if (_answer_type == null)
    //    //        {
    //    //            _answer_type = new Repository<Answer_Type>(_datacontext, _authorization);
    //    //        }
    //    //        return _answer_type;
    //    //    }
    //    //}
    //    //public IRepository<Answer_Lookup_Value> Answer_Lookup_Value
    //    //{
    //    //    get
    //    //    {
    //    //        if (_answer_lookup_value == null)
    //    //        {
    //    //            _answer_lookup_value = new Repository<Answer_Lookup_Value>(_datacontext, _authorization);
    //    //        }
    //    //        return _answer_lookup_value;
    //    //    }
    //    //}
    //    //public IRepository<SurveyReport> SurveyReports
    //    //{
    //    //    get
    //    //    {
    //    //        if (_surveyreports == null)
    //    //        {
    //    //            _surveyreports = new Repository<SurveyReport>(_datacontext, _authorization);
    //    //        }
    //    //        return _surveyreports;
    //    //    }
    //    //}
    //    //public IRepository<SurveyMaster> SurveyMasters
    //    //{
    //    //    get
    //    //    {
    //    //        if (_surveymasters == null)
    //    //        {
    //    //            _surveymasters = new Repository<SurveyMaster>(_datacontext, _authorization);
    //    //        }
    //    //        return _surveymasters;
    //    //    }
    //    //}
    //    //public IRepository<SurveyMasterRole> SurveyMasterRoles
    //    //{
    //    //    get
    //    //    {
    //    //        if (_surveymasterroles == null)
    //    //        {
    //    //            _surveymasterroles = new Repository<SurveyMasterRole>(_datacontext, _authorization);
    //    //        }
    //    //        return _surveymasterroles;
    //    //    }
    //    //}
    //    //public IRepository<SurveySection> SurveySections
    //    //{
    //    //    get
    //    //    {
    //    //        if (_surveysections == null)
    //    //        {
    //    //            _surveysections = new Repository<SurveySection>(_datacontext, _authorization);
    //    //        }
    //    //        return _surveysections;
    //    //    }
    //    //}
    //    //public IRepository<SurveyInfo> SurveyInfoes
    //    //{
    //    //    get
    //    //    {
    //    //        if (_surveyinfoes == null)
    //    //        {
    //    //            _surveyinfoes = new Repository<SurveyInfo>(_datacontext, _authorization);
    //    //        }
    //    //        return _surveyinfoes;
    //    //    }
    //    //}
    //    //public IRepository<Acres_Surveyed> Acres_Surveyed
    //    //{
    //    //    get
    //    //    {
    //    //        if (_acres_surveyed == null)
    //    //        {
    //    //            _acres_surveyed = new Repository<Acres_Surveyed>(_datacontext, _authorization);
    //    //        }
    //    //        return _acres_surveyed;
    //    //    }
    //    //}
    //    //public IRepository<Question> Questions
    //    //{
    //    //    get
    //    //    {
    //    //        if (_questions == null)
    //    //        {
    //    //            _questions = new Repository<Question>(_datacontext, _authorization);
    //    //        }
    //    //        return _questions;
    //    //    }
    //    //}
    //    //public IRepository<Questionnaire> Questionnaires
    //    //{
    //    //    get
    //    //    {
    //    //        if (_Questionnaires == null)
    //    //        {
    //    //            _Questionnaires = new Repository<Questionnaire>(_datacontext, _authorization);
    //    //        }
    //    //        return _Questionnaires;
    //    //    }
    //    //}
    //    //public IRepository<Park> Parks
    //    //{
    //    //    get
    //    //    {
    //    //        if (_parks == null)
    //    //        {
    //    //            _parks = new Repository<Park>(_datacontext, _authorization);
    //    //        }
    //    //        return _parks;
    //    //    }
    //    //}
    //    //public IRepository<Other_Project> Other_Project
    //    //{
    //    //    get
    //    //    {
    //    //        if (_other_project == null)
    //    //        {
    //    //            _other_project = new Repository<Other_Project>(_datacontext, _authorization);
    //    //        }
    //    //        return _other_project;
    //    //    }
    //    //}
    //    //public IRepository<Museum> Museums
    //    //{
    //    //    get
    //    //    {
    //    //        if (_museums == null)
    //    //        {
    //    //            _museums = new Repository<Museum>(_datacontext, _authorization);
    //    //        }
    //    //        return _museums;
    //    //    }
    //    //}
    //    //public IRepository<Funding> Fundings
    //    //{
    //    //    get
    //    //    {
    //    //        if (_fundings == null)
    //    //        {
    //    //            _fundings = new Repository<Funding>(_datacontext, _authorization);
    //    //        }
    //    //        return _fundings;
    //    //    }
    //    //}
    //    //public IRepository<SurveyFile> SurveyFiles
    //    //{
    //    //    get
    //    //    {
    //    //        if (_surveyfiles == null)
    //    //        {
    //    //            _surveyfiles = new Repository<SurveyFile>(_datacontext, _authorization);
    //    //        }
    //    //        return _surveyfiles;
    //    //    }
    //    //}
    //    //public IRepository<Spending> Spendings
    //    //{
    //    //    get
    //    //    {
    //    //        if (_spendings == null)
    //    //        {
    //    //            _spendings = new Repository<Spending>(_datacontext, _authorization);
    //    //        }
    //    //        return _spendings;
    //    //    }
    //    //}
    //    //public IRepository<Answer> Answers
    //    //{
    //    //    get
    //    //    {
    //    //        if (_answers == null)
    //    //        {
    //    //            _answers = new Repository<Answer>(_datacontext, _authorization);
    //    //        }
    //    //        return _answers;
    //    //    }
    //    //}
    //    //public IRepository<QuestionSection> QuestionSections
    //    //{
    //    //    get
    //    //    {
    //    //        if (_questionsections == null)
    //    //        {
    //    //            _questionsections = new Repository<QuestionSection>(_datacontext, _authorization);
    //    //        }
    //    //        return _questionsections;
    //    //    }
    //    //}
    //    //public IRepository<Audit_Question> Audit_Question
    //    //{
    //    //    get
    //    //    {
    //    //        if (_audit_question == null)
    //    //        {
    //    //            _audit_question = new Repository<Audit_Question>(_datacontext, _authorization);
    //    //        }
    //    //        return _audit_question;
    //    //    }
    //    //}
    //    //public IRepository<Audit_Answer> Audit_Answer
    //    //{
    //    //    get
    //    //    {
    //    //        if (_audit_answer == null)
    //    //        {
    //    //            _audit_answer = new Repository<Audit_Answer>(_datacontext, _authorization);
    //    //        }
    //    //        return _audit_answer;
    //    //    }
    //    //}
    //    //public IRepository<Answer_Default> Answer_Default
    //    //{
    //    //    get
    //    //    {
    //    //        if (_answer_default == null)
    //    //        {
    //    //            _answer_default = new Repository<Answer_Default>(_datacontext, _authorization);
    //    //        }
    //    //        return _answer_default;
    //    //    }
    //    //}
    //    //public IRepository<SurveyRole> SurveyRoles
    //    //{
    //    //    get
    //    //    {
    //    //        if (_surveyroles == null)
    //    //        {
    //    //            _surveyroles = new Repository<SurveyRole>(_datacontext, _authorization);
    //    //        }
    //    //        return _surveyroles;
    //    //    }
    //    //}
    //    //public IRepository<SurveyItem> SurveyItems
    //    //{
    //    //    get
    //    //    {
    //    //        if (_surveyitems == null)
    //    //        {
    //    //            _surveyitems = new Repository<SurveyItem>(_datacontext, _authorization);
    //    //        }
    //    //        return _surveyitems;
    //    //    }
    //    //}
    //    //public IRepository<Query> Queries
    //    //{
    //    //    get
    //    //    {
    //    //        if (_queries == null)
    //    //        {
    //    //            _queries = new Repository<Query>(_datacontext, _authorization);
    //    //        }
    //    //        return _queries;
    //    //    }
    //    //}
    //    //public IRepository<QueryCriteria> QueryCriterias
    //    //{
    //    //    get
    //    //    {
    //    //        if (_querycriterias == null)
    //    //        {
    //    //            _querycriterias = new Repository<QueryCriteria>(_datacontext, _authorization);
    //    //        }
    //    //        return _querycriterias;
    //    //    }
    //    //}
    //    //public SurveyWorker(DataContext data, IAuthorizedUserProvider authprovider)
    //    //{
    //    //    _datacontext = data;
    //    //    _authorization = authprovider;
    //    //}

    //    //public void Dispose()
    //    //{
    //    //    Dispose(true);
    //    //    GC.SuppressFinalize(this);
    //    //}

    //    //protected virtual void Dispose(bool disposing)
    //    //{
    //    //    if (disposing)
    //    //    {
    //    //        if (_datacontext != null)
    //    //        {
    //    //            _datacontext.Dispose();
    //    //        }
    //    //    }
    //    //}

    //    //public void Commit()
    //    //{
    //    //    _datacontext.SaveChanges();
    //    //}

    //    //public Base NewRecord<T>(IRepository<T> repo, T item) where T : Base
    //    //{
    //    //    item.Created_BY_FirstName = repo.GetUserInfo().GetFirstName();
    //    //    item.Created_BY_LastName = repo.GetUserInfo().GetLastName();
    //    //    item.Updated_BY_FirstName = repo.GetUserInfo().GetFirstName();
    //    //    item.Updated_BY_LastName = repo.GetUserInfo().GetLastName();
    //    //    item.Created_By_UserId = repo.GetUserInfo().GetUserId();
    //    //    item.Updated_By_UserId = repo.GetUserInfo().GetUserId();
    //    //    item.Created_Date = DateTime.Now;
    //    //    item.Updated_Date = DateTime.Now;

    //    //    return item;
    //    //}

    //    //public Base CreateRecord<T>(IRepository<T> repo, T item) where T : Base
    //    //{
    //    //    //item.Created_BY_FirstName = repo.GetUserInfo().GetFirstName();
    //    //    //item.Created_BY_LasttName = repo.GetUserInfo().GetLastName();
    //    //    //item.Updated_BY_FirstName = repo.GetUserInfo().GetFirstName();
    //    //    //item.Updated_BY_LasttName = repo.GetUserInfo().GetLastName();
    //    //    //item.Created_By_UserId = repo.GetUserInfo().GetUserId();
    //    //    //item.Updated_By_UserId = repo.GetUserInfo().GetUserId();
    //    //    item = (T)NewRecord(repo, item);
    //    //    item.Created_Date = DateTime.Now;
    //    //    item.Updated_Date = DateTime.Now;
    //    //    repo.Insert(item);
    //    //    Commit();
    //    //    item = repo.Inserted();
    //    //    return item;
    //    //}
    //    //public void CreateRecords<T>(IRepository<T> repo, T[] items) where T : Base
    //    //{


    //    //    items.ToList().ForEach(delegate(T item)
    //    //    {
    //    //        item = (T)NewRecord(repo, item);
    //    //        item.Created_Date = DateTime.Now;
    //    //        item.Updated_Date = DateTime.Now;
    //    //        repo.Insert(item);
    //    //    });
    //    //    Commit();
            
    //    //}
    //    //public Base UpdateRecord<T>(IRepository<T> repo, T item) where T : Base
    //    //{


    //    //    _update(repo, item);
    //    //    //Base _record = (Base)repo.SelectByID(item.Id);
    //    //    //item.Created_BY_FirstName = _record.Created_BY_FirstName;
    //    //    //item.Created_BY_LasttName = _record.Created_BY_LasttName;
    //    //    //item.Updated_BY_FirstName = repo.GetUserInfo().GetFirstName();
    //    //    //item.Updated_BY_LasttName = repo.GetUserInfo().GetLastName();
    //    //    //item.Created_By_UserId = _record.Created_By_UserId;
    //    //    //item.Updated_By_UserId = repo.GetUserInfo().GetUserId();
    //    //    //item.Created_Date = _record.Created_Date;
    //    //    //item.Updated_Date = DateTime.Now;
    //    //    Commit();
    //    //    repo.Update(item);
            
    //    //    return item;
    //    //}
    //    //private void _update<T>(IRepository<T> repo,T item) where T : Base 
    //    //{
    //    //    //Base _record = (Base)repo.SelectByID(item.Id);
    //    //    _prep_update(repo, item);
    //    //    //item.Created_BY_FirstName = _record.Created_BY_FirstName;
    //    //    //item.Created_BY_LasttName = _record.Created_BY_LasttName;
    //    //    item.Updated_BY_FirstName = repo.GetUserInfo().GetFirstName();
    //    //    item.Updated_BY_LastName = repo.GetUserInfo().GetLastName();
    //    //    //item.Created_By_UserId = _record.Created_By_UserId;
    //    //    item.Updated_By_UserId = repo.GetUserInfo().GetUserId();
    //    //    //item.Created_Date = _record.Created_Date;
    //    //    item.Updated_Date = DateTime.Now;
    //    //}
    //    //private void _prep_update<T>(IRepository<T> repo, T item) where T : Base
    //    //{
    //    //    item.Updated_BY_FirstName = repo.GetUserInfo().GetFirstName();
    //    //    item.Updated_BY_LastName = repo.GetUserInfo().GetLastName();
    //    //    item.Updated_By_UserId = repo.GetUserInfo().GetUserId();
    //    //    item.Updated_Date = DateTime.Now;
    //    //}
    //    //public void Truncate<T>(IRepository<T> repo, int id) where T : Base
    //    //{
    //    //    repo.Delete(id);
    //    //    Commit();
    //    //}
    //    //public void TruncateRecords<T>(IRepository<T> repo, T[] items) where T : Base
    //    //{
    //    //    List<T> _items = new List<T>();
    //    //    _items.AddRange(items);
    //    //    _items.FindAll(delegate(T item)
    //    //    {
    //    //        repo.Delete(item.Id);
    //    //        return true;
    //    //    });
    //    //    Commit();
    //    //}

        
    //    //public void UpdateRecords<T>(IRepository<T> repo, T[] items) where T : Base
    //    //{
    //    //    List<T> _items = new List<T>();
    //    //    _items.AddRange(items);

    //    //    List<DbEntityEntry> modifiedEntries = _datacontext.ChangeTracker.Entries()
    //    //            .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified).ToList();

            


    //    //    if (modifiedEntries.ToList().Count == 0) return;

    //    //    //if (modifiedEntries.ToList().Join(items.ToList(),m=>(T)m.Entity.Id

    //    //    _items.FindAll(delegate(T item)
    //    //    {

    //    //        var entries = (from e in modifiedEntries where ((T)e.Entity).Id==item.Id select e);
    //    //        if(entries.ToList().Count>0)
    //    //            _update<T>(repo, item);
    //    //        return true;
    //    //    });
    //    //    Commit();
    //    //}

    //    //public void DeleteRecords<T>(IRepository<T> repo, T[] items) where T : Base
    //    //{
    //    //    MarkRecordsForDelete<T>(repo, items);
    //    //    Commit();
    //    //}
    //    //public void MarkRecordsForDelete<T>(IRepository<T> repo, T[] items) where T : Base
    //    //{

    //    //    foreach (T o in items)
    //    //    {
    //    //        o.Deleted = true;
    //    //        _prep_update<T>(repo, o);
    //    //    }

    //    //}
    //    //public void MarkRecordForDelete<T>(IRepository<T> repo, T item) where T : Base
    //    //{
    //    //    item.Deleted = true;
    //    //    _update<T>(repo, item);
    //    //}
    //    //public Base GetWith<T>(string withThis, Func<T, bool> expression) where T : Base 
    //    //{
    //    //    return (from o in _datacontext.Set<T>().Include(withThis).Where(expression) select o).FirstOrDefault();
    //    //}
    //    //public IEnumerable<T> GetRecordsWith<T>(Func<T, bool> expression, string withThis) where T : Base
    //    //{
    //    //    return (from o in _datacontext.Set<T>().Include(withThis).Where(expression) select o);
    //    //}
    //    //public IEnumerable<T> GetRecordsWith<T>(Func<T, bool> expression, string withThis, string withThis2) where T : Base
    //    //{
    //    //    return (from o in _datacontext.Set<T>()
    //    //                .Include(withThis)
    //    //                .Include(withThis2).Where(expression) select o);
    //    //}
    //    //public IEnumerable<T> GetRecordsWith<T>(Func<T, bool> expression, string withThis, string withThis2, string withThis3) where T : Base
    //    //{
    //    //    return (from o in _datacontext.Set<T>()
    //    //                .Include(withThis)
    //    //                .Include(withThis2)
    //    //                .Include(withThis3).Where(expression)
    //    //            select o);
    //    //}
    //    //public Base Get<T>(Func<T, bool> expression) where T : Base 
    //    //{
    //    //    return (from o in _datacontext.Set<T>().Where(expression) select o).FirstOrDefault();
    //    //}

    //    //public IEnumerable<T> GetRecords<T>(Func<T, bool> expression) where T : Base
    //    //{
    //    //    return (from o in _datacontext.Set<T>().Where(expression) select o);
    //    //}


    //    //public IEnumerable<T> GetAllRecordsWith<T>(string withThis) where T : Base
    //    //{
    //    //    return (from o in _datacontext.Set<T>().Include(withThis) select o);
    //    //}
    //    //public IEnumerable<T> GetAllRecordsWith<T>(string withThis, string withThis2) where T : Base
    //    //{
    //    //    return (from o in _datacontext.Set<T>()
    //    //                .Include(withThis)
    //    //                .Include(withThis2) 
    //    //            select o);
    //    //}
    //    //public IEnumerable<T> GetAllRecordsWith<T>(string withThis, string withThis2, string withThis3) where T : Base
    //    //{
    //    //    return (from o in _datacontext.Set<T>()
    //    //                .Include(withThis)
    //    //                .Include(withThis2)
    //    //                .Include(withThis3) 
    //    //            select o);
    //    //}
    //    //public T GetRecordWith<T>(int Id, string withThis) where T : Base
    //    //{
    //    //    return (from o in _datacontext.Set<T>().Include(withThis) where o.Id == Id && o.Deleted == false select o).FirstOrDefault();
    //    //}
    //    //public T GetRecordWith<T>(int Id, string withThis, string withThis2) where T : Base
    //    //{
    //    //    return (from o in _datacontext.Set<T>().Include(withThis).Include(withThis2) where o.Id == Id && o.Deleted == false select o).FirstOrDefault();
    //    //}

    //    //public T GetRecordWith<T>(int Id, string withThis, string withThis2, string withThis3) where T : Base
    //    //{
    //    //    return (from o in _datacontext.Set<T>().Include(withThis).Include(withThis2).Include(withThis3) 
    //    //            where o.Id == Id && o.Deleted == false select o).FirstOrDefault();
    //    //}
    //    //public bool ExecuteProcedure(string procedureName, object[] param)
    //    //{
    //    //    _datacontext.Database.ExecuteSqlCommand(procedureName, param);
    //    //    return true;
    //    //}

    //    //public IEnumerable<T> ExecuteProcedure<T>(string procedureName, object[] parameters) where T : Base
    //    //{
    //    //    try
    //    //    {
    //    //        var result = _datacontext.Database
    //    //                .SqlQuery<T>(procedureName, parameters)
    //    //                .ToList<T>();
    //    //        //var result = data.Database
    //    //        //    .SqlQuery<ASPNetUserInfo>("GetASPNetUserInfo @UserId", clientIdParameter)
    //    //        //    .FirstOrDefault();

    //    //        if (result == null) return null;
    //    //        return (IEnumerable<T>)result;
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        CatchError(ex);
    //    //    }
    //    //    return null;
    //    //}
    //    //public IQueryable<T> GetRecords<T>() where T : Base
    //    //{
    //    //    return _datacontext.Set<T>().AsQueryable();
    //    //}
    //    //public void CatchError(Exception ex)
    //    //{
    //    //    _error = ex;
    //    //}
    //    //public Exception GetError()
    //    //{
    //    //    return _error;
    //    //}
    //}
}
