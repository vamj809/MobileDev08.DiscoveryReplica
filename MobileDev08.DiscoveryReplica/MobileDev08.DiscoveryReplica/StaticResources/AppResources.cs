using MobileDev08.DiscoveryReplica.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MobileDev08.DiscoveryReplica.StaticResources
{
    public static class Titles
    {
        public static string QuickHelp { get; } = "Quick Help";
        public static string DailyMeditations { get; } = "Daily meditations";
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
        public static string Export { get; } = "Export";
        public static string AddToCalendar { get; } = "AddCalendar";
        public static string Favorites { get; } = "Heart";
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
            new MenuOption("AnxiousEmoji","Anxiety"),
            new MenuOption("NeutralEmoji","Stress")
        };

        public static MeditationItem MainDailyMeditationItem { get; } = new MeditationItem(null, "Rest & Relax", "", 30);

        public static ObservableCollection<MeditationItem> DailyMeditationItems { get; } = new ObservableCollection<MeditationItem>
        {
            new MeditationItem(null,"Raining Sidewalk","",30),
            new MeditationItem(null,"Spring Morning","",30),
            new MeditationItem(null,"First Season","",30),
            new MeditationItem(null,"Blenheim Palace",
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
