namespace WebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
        public IFormFile CoverFile { get; set; }
        public int CategoryId { get; set; }
        public Category Cateyory { get; set; }
    }
}
