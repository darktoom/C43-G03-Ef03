using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef03.models
{
    internal class Student
    {

        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        [ForeignKey("StudentdeptId")]
        public int Dept_ID { get; set; }
        [InverseProperty(nameof(DepartmentITI.Students))]
        public DepartmentITI steduntdeptId { get; set;}
        public ICollection<Stud_Course> StudentCourses { get; set; } = new HashSet<Stud_Course>();





    }
}
