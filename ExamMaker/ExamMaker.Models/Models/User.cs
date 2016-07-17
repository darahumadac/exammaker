using System.Collections.Generic;

namespace ExamMaker.Models.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual List<Exam> Exams { get; set; } 

        public User()
        {
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}