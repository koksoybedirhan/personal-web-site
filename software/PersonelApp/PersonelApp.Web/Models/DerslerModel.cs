using System.ComponentModel.DataAnnotations;

namespace PersonelApp.Web.Models
{
    public class DerslerModel
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Content1 { get; set; }
        [MaxLength(200)]
        public string Content2 { get; set; }
        public string Img { get; set; }
        [MaxLength(50)]
        public string Date { get; set; }
        [MaxLength(200)]
        public string Link { get; set; }
        [MaxLength(3)]
        public int Semestr { get; set; }
    }
}
