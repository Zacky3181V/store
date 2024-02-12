namespace WebTechProject.Models
{
    public class StoreImage
    {
        public string? Id { get; set; }
        public string? StoreId { get; set; }
        public string? Label { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
