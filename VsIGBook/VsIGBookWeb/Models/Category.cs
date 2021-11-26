namespace VsIGBookWeb.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Default Name";
        public int DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
