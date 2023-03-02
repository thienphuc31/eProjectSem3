using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace eProject1
{
    [Table("Bell")]
    public class Bell
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
