using System.Collections.Generic;
using ExamMaker.Models.Models;
using ExamMaker.Models.Repositories;

namespace ExamMaker.Models.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExamMakerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExamMakerDbContext context)
        {
            context.Users.AddOrUpdate(u => u.UserId, new User("User1", "User123", false));

            context.Exams.AddOrUpdate(e => e.ExamId, new Exam()
            {
                ExamName = "Exam 1",
                ExamPassword = "Exam12",
                ScheduledExamDate = DateTime.Now,
                Type = ExamType.Quiz,
                UserId = context.Users.First().UserId,
                ExamItems = new List<ExamItem>()
                {
                    new ExamItem()
                    {
                        ItemType = ItemType.Identification,
                        Question = "What is a Question?",
                        Answer = "This is an answer",
                        Options = new List<Option>()
                        {
                            new Option()
                            {
                                OptionName = "Option 1"
                            }
                        }
                    }

                }


            });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
