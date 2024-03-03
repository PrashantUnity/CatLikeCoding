namespace CatLikeCoding.Models.Chapter
{
    public class ChapterHead
    {
        public string Heading { get; set; } = string.Empty;

        public string SubHeading { get; set; } = string.Empty;

        public string DateCreated { get; set; } = string.Empty;

        public List<string> Steps { get; set; } = new();

        public List<string> DescriptionList { get; set; } = new();

        public string ImageUrl { get; set; } = string.Empty;

        public string ImageAltName { get; set; } = "Cat Like Coding Image";

        public string ImageCaption { get; set; } = string.Empty;

        public List<(string, string)> ReferenceList { get; set; } = new();
    }
}
