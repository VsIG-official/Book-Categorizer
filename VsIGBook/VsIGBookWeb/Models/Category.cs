using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VsIGBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "Default Name";
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage = "Display Order should be between 1 and 100")]
        public int DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
