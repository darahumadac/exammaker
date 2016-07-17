using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamMaker.Models;
using ExamMaker.Models.Models;
using ExamMaker.Models.Repositories;
using NUnit.Framework;

namespace ExamMaker.Tests
{
    [TestFixture]
    public class SqlRepositoryShould
    {
        private IAppDataSource _sqlDatabase;
        private AppRepository _appRepository;
        private ExamMakerDbContext _dbContext;


        public SqlRepositoryShould()
        {
            _sqlDatabase = new SqlRepository();
            _appRepository = new AppRepository(_sqlDatabase);

            _dbContext = new ExamMakerDbContext();
            
        }

        private User addTestUser(string username, string password)
        {
            User newUser = new User(username, password);
            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();

            return newUser;
        }

        private void deleteAllUsers()
        {
            _dbContext.Users.RemoveRange(_dbContext.Users);
            _dbContext.SaveChanges();
        }

        [Test]
        public void Return_List_Of_Users()
        {
            deleteAllUsers();
            User newUser = addTestUser("username_1", "password_1");

            List<User> userRecords = _appRepository.UserRepository.GetAll();

            Assert.AreEqual(newUser.UserId, userRecords[0].UserId);
            Assert.AreEqual(newUser.Username, userRecords[0].Username);
            Assert.AreEqual(newUser.Password, userRecords[0].Password);
        }

        [Test]
        public void Add_New_Users()
        {
            deleteAllUsers();
            User newUser = new User("add_new_user_1", "add_new_user_pwd_1");

            _appRepository.UserRepository.Add(newUser);
            _appRepository.Save();

            int newUserId = _dbContext.Users.Find(newUser.UserId).UserId;

            Assert.AreEqual(newUserId, newUser.UserId);
        }

        [Test]
        public void Update_User()
        {
            deleteAllUsers();
            User existingUser = addTestUser("edit_user1", "edit_pwd1");
            existingUser.Username = "updated_user1";
            existingUser.Password = "updated_pwd1";

            _appRepository.UserRepository.Update(existingUser);
            _appRepository.Save();

            User updatedUser = _dbContext.Users.Find(existingUser.UserId);

            Assert.AreEqual(existingUser.UserId, updatedUser.UserId);
            Assert.AreEqual(existingUser.Username, updatedUser.Username);
            Assert.AreEqual(existingUser.Password, updatedUser.Password);
        }

        [Test]
        public void Delete_User()
        {
            deleteAllUsers();
            User existingUser = addTestUser("delete_user1", "delete_pwd1");

            _appRepository.UserRepository.Delete(existingUser);
            _appRepository.Save();

            User deletedUser = _dbContext.Users.FirstOrDefault(u => u.UserId == existingUser.UserId);

            Assert.IsNull(deletedUser);
        }

        [Test]
        public void Get_User_ById()
        {
            deleteAllUsers();
            User newUser = addTestUser("search_user1", "search_pwd1");

            User foundUser = _appRepository.UserRepository.GetById(newUser.UserId);

            Assert.IsNotNull(foundUser);
            Assert.AreEqual(newUser.UserId, foundUser.UserId);
        }
    }
}
