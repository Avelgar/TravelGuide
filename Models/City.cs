namespace TravelGuide.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
        public string History { get; set; }
        public string PhotoPath { get; set; } // Путь к изображению герба/фото города
        public ICollection<Attraction> Attractions { get; set; } = new List<Attraction>();
    }
}
