using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef03.models
{
    internal class Topic
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Course Course { get; set; }

    }
}
