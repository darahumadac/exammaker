using System.Collections.Generic;
using System.ComponentModel;

namespace ExamMaker.Models.Models
{
    public class User
    {
        [DisplayName("User Id")]
        public int UserId { get; set; }
        public string Username { get; set; }
        [Browsable(false)]
        public string Password { get; set; }
        [DisplayName("Administrator?")]
        public bool IsAdmin { get; set; }
        public virtual List<Exam> Exams { get; set; } 

        public User()
        {
        }

        public User(string username, string password, bool isAdmin)
        {
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}