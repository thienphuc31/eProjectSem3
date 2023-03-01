using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace eProject1
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string employee_id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name from 1 to 50")]
        public string employee_name { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Password from 4 to 20")]
        public string employee_password { get; set; }
        [Required]
        public DateTime employee_DOB { get; set; }
        [Required]
        public string employee_email { get; set; }
        [Required]
        public string employee_address { get; set; }
        [Required]
        public string employee_phone { get; set; }
        public int department_id { get; set; }
        [ForeignKey("department_id")]
        public Department Departments { get; set; }
        public List<EmployeeEvent> EmployeeEvents { get; set; }
    }
}
