namespace ArtistBiography.Models
{
    public class Picture
    {
        public Picture(string title, string description, string path)
        {
            Path = path;
            Title = title;
            Description = description;
        }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }



}
