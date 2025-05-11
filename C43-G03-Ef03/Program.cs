using C43_G03_Ef03.Dbcontext;
using C43_G03_Ef03.models;

using Microsoft.EntityFrameworkCore;

namespace C43_G03_Ef03
{
    internal class Program
    {
        static void Main(string[] agrs)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();

            /////  dbContext.ChangeTracker.QueryTrackingBehavior=QueryTrackingBehavior.NoTracking;
            #region insert 
            Employee employee01 = new Employee()
            {
                EmpName = "hatem",
                Age = 30,
                EmailAdress = "hatem@gmail.com",
                Password = "p@ssw0rd",
                Salary = 4000,
                PhoneNumber = "01022"

            };

            //Console.WriteLine(dbContext.Entry<Employee>(employee01).State);

            //employee01.EmpName = "amr";

            ///add new record in database
            ///    dbContext.Employee.Add(employee01);
            ///    dbContext.Set<Employee>().Add(employee01);
            ///    dbContext.Add(employee01);
            ///    dbContext.Entry<Employee>(employee01).State =EntityState.Added;
            ///    Console.WriteLine(dbContext.Entry<Employee>(employee01).State);//added
            ///    Console.WriteLine($"{employee01.EmpId}");
            ///  dbContext.SaveChanges();
            ///    Console.WriteLine("after save changes");
            ///   Console.WriteLine(dbContext.Entry<Employee>(employee01).State);//added
            ///    Console.WriteLine($"{employee01.EmpId}");
            ///
            /// 
            #endregion

            #region select
            var emp1 =dbContext.Employee.Where(e=>e.EmpId==1).FirstOrDefault();
            Console.WriteLine(emp1);
            Console.WriteLine(dbContext.Entry<Employee>(employee01).State);
            #endregion

         
        }
    }
}
