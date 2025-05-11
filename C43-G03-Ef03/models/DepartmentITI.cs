using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef03.models
{
    internal class DepartmentITI
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ins_Id { get; set; }
        public DateOnly HiringDate { get; set; }
        [ForeignKey("Students")]
        public int StudentDepartmentId { get; set; }
        [InverseProperty(nameof(Student.Dept_ID))]
        public ICollection<Student> Students=new HashSet<Student>();
       /// [InverseProperty(nameof(Instructor.Dept_ID))]
        public ICollection<Instructor> Instructors=new HashSet<Instructor>();
    }
}
