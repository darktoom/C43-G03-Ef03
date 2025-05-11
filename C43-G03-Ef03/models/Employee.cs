using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_Ef03.models
{
    internal class Employee
    {



        [Key]
            public int EmpId { get; set; } // pk with identity constraint [1,1]
            [Required]


            [MinLength(3, ErrorMessage = "name of employee more than 3 char")]


            public string EmpName { get; set; }
            //nullable reference type
            //string? is mapped to varchar(50)  not allow null
            [Column("EmpSalary")]
            public decimal Salary { get; set; }
            /*value type 
             * not allow null
             * decimal is mapped  to decimal (18,2) not allow null

             */
            [Column("EmpAge")]
            // [Range(20,40)]
            //   [AllowedValues]
            //[DeniedValues(21,22)]
            public int Age { get; set; }
            /*
             value type
            int is mapped to int not null

            */
            [Phone]
            [DataType(DataType.PhoneNumber)]
            [Required]
            public required  string PhoneNumber { get; set; }

            [DataType(DataType.Password)]
            public string  Password { get; set; }
            [EmailAddress]
            [DataType(DataType.EmailAddress)]
            public string EmailAdress { get; set; }
            [NotMapped]
            public string property { get; set; }

        public int EmpolyeeDepartmentId { get; set; }

            public Department? ManageDept { get; set; } 
        public Address? EmpAddress { get; set; }
        public Department empolyeedepartment { get; set; } = null!; 

        }


    }

