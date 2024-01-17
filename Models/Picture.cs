namespace ArtistBiography.Models
{
    public class Picture(string title, int year, string description, string path)
    {
        public int Year { get; set; } = year;

        public string Path { get; set; } = path;

        public string Title { get; set; } = title;

        public string Description { get; set; } = description;
    }



}
