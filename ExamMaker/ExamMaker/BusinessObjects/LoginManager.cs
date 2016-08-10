using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamMaker.Models.Models;
using ExamMaker.Models.Repositories;

namespace ExamMaker.BusinessObjects
{
    public class LoginManager
    {
        private readonly Repository<User> _userRepository;

        public LoginManager(Repository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public User Authenticate(string username, string password)
        {
            User user = _userRepository.GetAll().Find(u => u.Username.Equals(username) && u.Password.Equals(password));

            if (user != null)
            {
                return user;
            }

            user = new User();
            return user;
        }
    }
}
