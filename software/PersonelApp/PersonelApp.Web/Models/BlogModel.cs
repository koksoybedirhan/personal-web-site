using System.ComponentModel.DataAnnotations;

namespace PersonelApp.Web.Models
{
    public class BlogModel
    {
        [Required]
        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Date { get; set; }
        public string Img1 { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Img2 { get; set; }
        public string Content3 { get; set; }
        public string Content4 { get; set; }
        public string Content5 { get; set; }
    }
}
