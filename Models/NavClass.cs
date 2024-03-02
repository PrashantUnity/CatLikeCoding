using MudBlazor;

namespace CatLikeCoding.Models
{
    public class NavClass
    {
        public List<NavClass>? ListOfNavClass { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string IconImage { get; set; } = string.Empty;
        public Color IconImageColor { get; set; } = Color.Success;
    }
}
