using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef03.models
{
    internal class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Adress { get; set; }
        public int HourRate { get; set; }
        [ForeignKey(nameof(DepartmentITI.Id))]
        public int Dept_ID { get; set; }
        public ICollection<Course_Inst> insts_course {  get; set; }
        [InverseProperty(nameof(DepartmentITI.Instructors))]
        public DepartmentITI department { get; set; }

    }
}
