using System.ComponentModel.DataAnnotations;

namespace PersonelApp.Web.Models
{
    public class KurslarModel
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Content { get; set; }
        [MaxLength(200)]
        public string Img { get; set; }
        [MaxLength(50)]
        public string Date { get; set; }
        [MaxLength(200)]
        public string Link { get; set; }
        [MaxLength(3)]
        public int VideoNumber { get; set; }
    }
}
