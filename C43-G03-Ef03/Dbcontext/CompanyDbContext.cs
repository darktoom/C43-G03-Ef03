using C43_G03_Ef03.models;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef03.Dbcontext
{
    internal class CompanyDbContext: DbContext
    {
        public CompanyDbContext() : base()
        {



        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Data source=.;Initial catalog= CompanyDb ; intergated security = true");
            optionsBuilder.UseSqlServer("server=.;database= CompanyDb ; trusted_connection = true; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Department>(d => {
                d.ToTable("department");
                d.HasKey(d => d.DeptId);
                d.Property(d=>d.DeptName).HasColumnName("deptname");
                d.Ignore(d => d.Serial);

            
           
            
            });

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithOne(e => e.ManageDept)
                ;


            modelBuilder.Entity<Employee>()
                .HasOne(e => e.ManageDept)
                .WithOne(e => e.Manager)
                .HasForeignKey<Department>(d => d.ManageId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            modelBuilder.Entity<Employee>().OwnsOne(e => e.EmpAddress,Address=>Address.WithOwner());
            //modelBuilder.Entity<Employee>().HasOne<Department>().WithOne().HasForeignKey<Department>(d=>d.ManageId);

        }



        public DbSet<Employee> Employee { get; set; }
       public DbSet<Department> Department { get; set; }

    }
}
