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
    [Table("Event")]
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int  event_id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name from 1 to 50")]
        public string event_name { get; set; }
        [Required]
        public string event_request { get; set; }
        public int number { get; set; }
        [Required]
        public DateTime event_startdate { get; set; }
        [Required]
        public DateTime event_enddate { get; set; }
        [Required]
        public bool status { get; set; }
        public List<EmployeeEvent> EmployeeEvents { get; set; }
    }
}
