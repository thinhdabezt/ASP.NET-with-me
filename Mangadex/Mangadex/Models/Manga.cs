namespace Mangadex.Models
{
    public class Manga
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public float Rating { get; set; }
        public DateOnly PublicDate { get; set; }
    }
}
