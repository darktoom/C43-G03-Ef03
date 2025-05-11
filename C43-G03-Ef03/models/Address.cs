using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef03.models
{
    [Owned]
    
    internal class Address
    {
     
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? street { get; set; } 

    }
}
