using GradeReport.Modules.Group;
using GradeReport.Modules.GroupSubjectRef;
using GradeReport.Modules.Student;
using GradeReport.Modules.Subject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport.Common
{
    public class AppDbContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }

        public DbSet<GroupSubjectRef> GroupSubjectRefs { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupSubjectRef>().HasKey(e => new { e.GroupId, e.SubjectId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=data\app.db");
        }
    }
}
