using System.ComponentModel.DataAnnotations;

namespace PersonelApp.Web.Models
{
    public class YoneticiModel
    {
        [Required]
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Departmant { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Content3 { get; set; }
        public string Content4 { get; set; }
        public string Content5 { get; set; }
        public string Content6 { get; set; }
        public string Mail { get; set; }
        public string Linkedin { get; set; }
        public string Github { get; set; }
    }
}
