using System.ComponentModel.DataAnnotations;

namespace PersonelApp.Web.Models
{
    public class LinkModel
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Content { get; set; }
    }
}
