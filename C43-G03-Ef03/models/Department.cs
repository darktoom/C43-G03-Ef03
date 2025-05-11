using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef03.models
{
    internal class Department
    {

        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public DateOnly DateCreation { get; set; }
        public int Serial { get; set; }
        //navigation property one
        //ef core: depapartment has to have one employee that manage it mandatory
        public Employee Manager { get; set; } = null;
        // [ForeignKey(nameof(Manager))]
        public int ManageId { get; set; }
        public ICollection<Employee> Employees { get; set; }=new HashSet<Employee>();
     
    }
}
