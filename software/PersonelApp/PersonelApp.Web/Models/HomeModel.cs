using System.ComponentModel.DataAnnotations;

namespace PersonelApp.Web.Models
{
    public class HomeModel
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Img { get; set; }
        public string Link1 { get; set; }
        public string Link2 { get; set; }
        public string Link3 { get; set; }
    }
}
