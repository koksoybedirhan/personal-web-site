using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PersonelApp.Web.Models
{
    public class DerslerAyrintiModel
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int DersId { get; set; }
        [MaxLength(3)]
        public int Semestr { get; set; }
        [MaxLength(200)]
        public string Link { get; set; }
        public string Details { get; set; }
        public string DersImg { get; set; }

        // Dersler için tek nesne referansı (bire bir ilişki)
        [ForeignKey("DersId")]
        public DerslerModel Dersler { get; set; }
    }

}
