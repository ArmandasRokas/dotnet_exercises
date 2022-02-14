namespace mvc_web_app.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
    }
}
