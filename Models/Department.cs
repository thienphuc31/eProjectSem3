using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace eProject1
{
    [Table("Department")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int department_id { get; set; }
        [Required]
        public string department_name { get; set; }
    }
}
