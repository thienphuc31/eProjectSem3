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
    [Table("EmployeeEvent")]
    public class EmployeeEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EE_id { get; set; }
        public string employee_id { get; set; }
        [ForeignKey("employee_id")]
        public Employee employees { get; set; }
        public int event_id { get; set; }
    }
}
