using System.ComponentModel.DataAnnotations;

namespace PersonelApp.Web.Models
{
    public class IletisimModel
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
