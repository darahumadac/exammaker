using System.Collections.Generic;

namespace ExamMaker.Models.Repositories
{
    public interface IAppDataSource
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        List<T> GetAll<T>() where T : class;
        T GetById<T>(object id) where T : class;
        void Save();
    }
}