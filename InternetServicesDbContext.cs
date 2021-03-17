using Microsoft.EntityFrameworkCore;
using midTerm.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace midTerm.Data
{
    public class InternetServicesDbContext
        : DbContext
    {
        public InternetServicesDbContext(DbContextOptions<InternetServicesDbContext> options)
            : base(options)
        {

        }

        public DbSet<SurveyUser> SurveyUsers { get; set; }

        public DbSet<Answers> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SurveyUser>(SurveyUser =>
            {
                SurveyUser.Property(p => p.Id).IsRequired();
                SurveyUser.HasKey(p => p.Id);
                SurveyUser.Property(p => p.FirstName).IsRequired();
                SurveyUser.Property(p => p.LastName).IsRequired();
                SurveyUser.Property(p => p.Country).IsRequired();
                SurveyUser.HasMany(p => p.Gender);
                SurveyUser.HasMany(p => p.DoB);
            });

            modelBuilder.Entity<Answers>(Answers =>
            {
                Answers.Property(p => p.Id).IsRequired();
                Answers.HasKey(p => p.Id);
                Answers.Property(p => p.UserId).IsRequired();
                Answers.Property(p => p.OptionId).IsRequired();                
                Answers.HasMany(p => p.Option);
                Answers.HasMany(p => p.User);
            });
        }
    }
}
