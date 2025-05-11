using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef03.models
{
    internal class Course
    {

        [Key]
        public int Id { get; set; }
        public int duration { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey(nameof(Topic.Id))]
        public string Top_Id { get; set; }
       
        public ICollection<Stud_Course> coursesStudent { get; set; }
        public ICollection<Course_Inst> Course_Insts { get; set; }
        
        public ICollection<Topic> Topic_crs { get; set; } = new HashSet<Topic>();
        

    }
}
