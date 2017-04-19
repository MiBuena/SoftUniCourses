using System.Runtime.Remoting.Contexts;
using LearningSystem.Data.Migrations;
using LearningSystem.Models.EntityModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LearningSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LearningSystemContext : IdentityDbContext<ApplicationUser>
    {
        public LearningSystemContext()
            : base("name=LearningSystem", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LearningSystemContext, Configuration>());
        }

        public static LearningSystemContext Create()
        {
            return new LearningSystemContext();
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Article> Articles { get; set; }

        public virtual DbSet<CourseGrade> CourseGrade { get; set; }

    }

}