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

        [MaxLength(500)]
        public string Content { get; set; }

        public string Img { get; set; }

        [MaxLength(50)]
        public string Date { get; set; }

        // DersAyrinti için tek nesne referansı (bire bir ilişki)
        public DerslerAyrintiModel DersAyrintilar { get; set; }
    }
}
