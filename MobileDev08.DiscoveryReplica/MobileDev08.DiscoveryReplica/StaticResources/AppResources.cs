using MobileDev08.DiscoveryReplica.Models;
using System.Collections.ObjectModel;

namespace MobileDev08.DiscoveryReplica.StaticResources
{
    public static class Titles
    {
        public static string QuickHelp { get; } = "Quick Help";
        public static string DailyMeditations { get; } = "Daily Meditations";
        public static string NewMusic { get; } = "New Music";
        public static string Articles { get; } = "Article Title";
    }

    public static class Options
    {
        public static string ViewAll { get; } = "View all";
        public static string Tab1 { get; } = "Today";
        public static string Tab2 { get; } = "Yoga";
        public static string Tab3 { get; } = "Meditation";
        public static string Tab4 { get; } = "Meal";
        public static string Tab5 { get; } = "Profile";
    }

    public static class Icons
    {
        public static string Search { get; } = "Magnifier";
        public static string Export { get; } = "ExportIcon";
        public static string AddToCalendar { get; } = "AddCalendarIcon";
        public static string Favorite { get; } = "HeartIcon";
        public static string Tab1 { get; } = "Calendar";
        public static string Tab2 { get; } = "Video";
        public static string Tab3 { get; } = "Moon";
        public static string Tab4 { get; } = "Disc";
        public static string Tab5 { get; } = "User";
    }

    public static class Data
    {
        public static ObservableCollection<MenuOption> QuickHelpItems { get; } = new ObservableCollection<MenuOption>
        {
            new MenuOption("Wind","Breathe"),
            new MenuOption("SleepingMoon","Sleep"),
            new MenuOption("DistressedEmoji","Anxiety"),
            new MenuOption("NeutralEmoji","Stress")
        };

        public static MeditationItem MainDailyMeditationItem { get; } = new MeditationItem(
            new ObservableCollection<string>(){ "MainRestRelax.jpg" }, "Rest & Relax", "", 30);

        public static ObservableCollection<MeditationItem> DailyMeditationItems { get; } = new ObservableCollection<MeditationItem>
        {
            new MeditationItem(new ObservableCollection<string>(){ "MainRainingSidewalk.jpg", "MainFirstSeason.jpg" },"Raining Sidewalk","",5),
            new MeditationItem(new ObservableCollection<string>(){ "MainSpringMorning.jpg", "MainFirstSeason.jpg" },"Spring Morning","",7),
            new MeditationItem(new ObservableCollection<string>(){ "MainFirstSeason.jpg", "MainFirstSeason.jpg" },"First Season","",30),
            new MeditationItem(new ObservableCollection<string>(){ "MainBlenheimPalace.jpg", "MainFirstSeason.jpg" },"Blenheim Palace",
                "Small batch banjo Cosby sweater, pug " +
                "polaroid Neutra asymmetrical " +
                "chambray. Bespoke Etsy wolf, Carles " +
                "PBR Odd Future ethical keytar fashion " +
                "axe. Polariod artisan wayfarers fap. " +
                "Plaid salvia gluten-free, Inteligentsia " +
                "irony tote bag raw denim selfies organic " +
                "McSweeney's jean shorts ethical.\n" +
                "Leggins mlkshk four loko small batch, " +
                "occupy banh mi semiotics letterpress " +
                "Neither option is too important.",30)
        };
    }
}
