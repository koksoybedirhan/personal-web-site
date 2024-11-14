using System.ComponentModel.DataAnnotations;

namespace PersonelApp.Web.Models
{
    public class DuyurularModel
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
    }
}
