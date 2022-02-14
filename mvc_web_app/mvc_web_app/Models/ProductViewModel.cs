namespace mvc_web_app.Models
{
    public class ProductViewModel
    {
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public List<Category> Categories { get; set; }
    }
}
