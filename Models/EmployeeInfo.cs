using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Models
{
    public class EmployeeInfo
    {
        [Key]

        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }
        [Display(Name = "Employee Number")]
        public int EmployeeNum { get; set; }
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Employee Date")]
        public DateTime EmployeeDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Terminated")]
        public DateTime Terminated { get; set; }
    }
}
