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
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name from 1 to 50")]
        public string contact_title { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "Name from 10 to 150")]
        public string contact_text { get; set; }

        public string employee_id { get; set; }
        [ForeignKey("employee_id")]
        public Employee employees { get; set; }
    }
}
