namespace WebTechProject.Models
{
    public class Product
    {
        public string? Name { get; set; }
        public double ? Price { get; set; }
        public bool ? IsFeatured { get; set; }
        public List<Image>? Images { get; set; }
        public Color? Color { get; set; }
        public Category? Category { get; set; }
        public Size? Size { get; set; }
    }
}
