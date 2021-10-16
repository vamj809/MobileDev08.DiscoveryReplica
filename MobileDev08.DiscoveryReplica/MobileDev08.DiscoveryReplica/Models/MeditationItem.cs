using System.Collections.ObjectModel;

namespace MobileDev08.DiscoveryReplica.Models
{
    public class MeditationItem
    {
        public string PreferredImage { get => Images.Count > 0 ? Images[0] : null; }
        public string DurationLabel { get => "🕒 " + Duration + " " + DurationMeasure; }
        public ObservableCollection<string> Images { get; }
        public string Title { get; }
        public string Description { get; }
        public int Duration { get; }
        public string DurationMeasure { get; }
        public MeditationItem(ObservableCollection<string> images, string title, string description, int duration, string durationMeasure = "mins.")
        {
            Images = images;
            Title = title;
            Description = description;
            Duration = duration;
            DurationMeasure = durationMeasure;
        }
    }
}
