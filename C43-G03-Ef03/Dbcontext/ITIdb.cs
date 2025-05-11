using C43_G03_Ef03.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef03.Dbcontext
{
    internal class ITIdb:DbContext
    {
        public ITIdb() : base()
        {



        } // optionsBuilder.UseSqlServer("Data source=.;Initial catalog= CompanyDb ; intergated security = true");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer("server=.;database= iti ; trusted_connection = true; TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Student>()
            //    .HasMany(s => s.Courses)
            //    .WithMany(c => c.Students)
            //    .UsingEntity(rt => rt.ToTable("Stud_Course"));


        }


        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Course_Inst> Course_Inst { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Instructor> instructor { get; set; }




    }
}
