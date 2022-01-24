using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegisterAPI.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string Occupation { get; set; }

        public string ImageName { get; set; }




    }
}
