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
    [Table("News")]
    class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int news_id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Title from 1 to 50")]
        public string news_title { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "Name from 10 to 150")]
        public string news_subtitle { get; set; }
        public string news_img { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "Name from 1 to 1000")]
        public string news_text { get; set; }
        [Required]
        public DateTime news_date { get; set; }
    }
}
