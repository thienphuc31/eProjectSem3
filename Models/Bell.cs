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
    [Table("Bell")]
    class Bell
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bell_id { get; set; }
        [Required]
        public string text { get; set; }
        public string employee_id { get; set; }
        [ForeignKey("employee_id")]
        public Employee? employees { get; set; }
    }
}
