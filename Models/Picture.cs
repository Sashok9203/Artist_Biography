namespace ArtistBiography.Models
{
    public class Picture
    {
        public Picture(string title,int year, string description, string path)
        {
            Year = year;
            Path = path;
            Title = title;
            Description = description;
        }
        public int Year { get; set; }

        public string Path { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }



}
