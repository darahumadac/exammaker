using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ExamMaker.Models.Repositories
{
    public class SqlRepository : IAppDataSource
    {
        private ExamMakerDbContext _dbContext;

        public SqlRepository()
        {
            _dbContext = new ExamMakerDbContext();
        }
        public void Add<T>(T entity) where T : class
        {
            _dbContext.Set<T>().Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete<T>(T entity) where T : class
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                _dbContext.Set<T>().Attach(entity);
            }
            _dbContext.Set<T>().Remove(entity);
        }

        public List<T> GetAll<T>() where T : class
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById<T>(object id) where T : class
        {
            return _dbContext.Set<T>().Find(id);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}