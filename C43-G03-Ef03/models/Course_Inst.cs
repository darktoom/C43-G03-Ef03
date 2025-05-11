using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef03.models
{
    [PrimaryKey(nameof(Idinst_ID),nameof(Course_ID))]
    internal class Course_Inst
    {
        [ForeignKey(nameof(Instructor))]
        public int Idinst_ID { get; set; }
        [ForeignKey(nameof(Course))]
        public int Course_ID { get; set; }
        public string evaluate { get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }



    }
}
