using System.Data.Entity;
using ExamMaker.Models.Models;

namespace ExamMaker.Models.Repositories
{
    public class ExamMakerDbContext : DbContext
    {
        public ExamMakerDbContext()
            : base("ExamMakerDbContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Option> Options { get; set; }
    }

    
}
