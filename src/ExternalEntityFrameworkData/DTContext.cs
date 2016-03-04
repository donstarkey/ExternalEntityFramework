using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using DTModels;

namespace DocuTrackerEF7.DAL
{
    public class DTContext : DbContext
    {
        public DTContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionAnswer>().HasKey(x => new { x.QuestionID, x.AnswerID });
        }

        public DbSet<InternalAnswer> InternalAnswers { get; set; }
        public DbSet<AnswerType> AnswerTypes { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
    }
}
