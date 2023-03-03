using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace eProject1
{
    [Table("News")]
    public class News
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int news_id { get; set; }
        [Required]
        public string news_title { get; set; }
        [Required]
        public string news_subtitle { get; set; }
        public string news_img { get; set; }
        [Required]
        public string news_text { get; set; }
        [Required]
        public DateTime news_date { get; set; }
    }
}
