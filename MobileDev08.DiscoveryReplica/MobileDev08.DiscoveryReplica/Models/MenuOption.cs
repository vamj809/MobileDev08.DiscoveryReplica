namespace MobileDev08.DiscoveryReplica.Models
{
    public class MenuOption
    {
        public string Image { get; }
        public string Title { get; }
        public MenuOption(string image, string title)
        {
            Image = image;
            Title = title;
        }
    }
}
