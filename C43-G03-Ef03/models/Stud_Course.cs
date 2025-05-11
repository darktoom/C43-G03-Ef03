using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef03.models
{
    [PrimaryKey(nameof(Stud_ID),nameof(Course_Id))]
    internal class Stud_Course
    {
        [ForeignKey(nameof(Student))]

        public int Stud_ID { get; set; }
        [ForeignKey(nameof(Course))]
        public int Course_Id { get; set; }
        public string? grade { get; set; }

        public Student Student { get; set; } = null!;
        public Course Course { get; set; } = null!;

    }
}
