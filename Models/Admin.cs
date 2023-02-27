using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
namespace eProject1
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string admin_id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name from 1 to 50")]
        public string admin_name { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "Password from 4 to 20 ")]
        public string admin_password { get; set; }
    }
}
