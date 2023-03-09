using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace eProject1
{
    [Table("Contact")]
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int contact_id { get; set; }
        
        public string contact_title { get; set; }
        
        public string contact_text { get; set; }
        public DateTime createdate { get; set; }
        public string answer { get; set; } = null;
        public int status { get; set; } = 1;
        public string employee_id { get; set; }
        [ForeignKey("employee_id")]
        public Employee employees { get; set; }
    }
}
