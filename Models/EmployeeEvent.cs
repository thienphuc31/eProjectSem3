﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [ForeignKey("event_id")]
        public Event events { get; set; }
        public bool status { get; set; }
    }
}
