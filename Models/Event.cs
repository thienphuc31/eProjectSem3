using eProject1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace eProject1
{
    [Table("Event")]
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int event_id { get; set; }
        [Required]
       
        public string event_name { get; set; }
        [Required]
        public string event_request { get; set; }

        public int number { get; set; } = 0;
        [Required]
        public DateTime event_startdate { get; set; }
        [Required]
        public DateTime event_enddate { get; set; }
        [Required]
        public bool status { get; set; } = true;
        public List<EmployeeEvent> EmployeeEvents { get; set; }
        
    }
}
