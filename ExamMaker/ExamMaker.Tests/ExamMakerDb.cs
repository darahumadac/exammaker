using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamMaker.Models.Models;

namespace ExamMaker.Tests
{
    public class ExamMakerDb : DbContext
    {
        public ExamMakerDb()
            : base("ExamMakerDbContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Exam> Exams { get; set; }
    }
}
