using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ExamMaker.Models.Repositories
{
    public class NoSQLRepository : IAppDataSource
    {
        private IMongoDatabase _noSqlDbContext;

        public NoSQLRepository()
        {
            _noSqlDbContext = new MongoClient(ConfigurationManager
                .ConnectionStrings["ExamMakerNoSQLContext"].ConnectionString).GetDatabase("EXAMMAKERD");
        }
        public void Add<T>(T entity) where T : class
        {
            var entityBsonDocument = entity.ToBsonDocument();

            _noSqlDbContext.GetCollection<BsonDocument>(entity.GetType().Name + "s")
                .InsertOne(entityBsonDocument);
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(object id) where T : class
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Revert()
        {
            throw new NotImplementedException();
        }
    }
}
