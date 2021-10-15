using MobileDev08.DiscoveryReplica.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MobileDev08.DiscoveryReplica.Helpers
{
    public static class StaticResources
    {
        public static string QuickHelpTitle = "Quick Help";
        public static string DailyMeditationsTitle = "Daily meditations";
        public static string NewMusicTitle = "New Music";
        public static string NewMusicViewAllOption = "View all";

        //Example Data
        public static ObservableCollection<MenuOption> TabPageNames = new ObservableCollection<MenuOption>
        {
            new MenuOption("Calendar", "Today"),
            new MenuOption("Video", "Yoga"),
            new MenuOption("Moon", "Meditation"),
            new MenuOption("Disc", "Meal"),
            new MenuOption("User", "Profile")
        };

        public static ObservableCollection<MenuOption> QuickHelpItems = new ObservableCollection<MenuOption>
        {
            new MenuOption("Wind","Breathe"),
            new MenuOption("SleepingMoon","Sleep"),
            new MenuOption("AnxiousEmoji","Anxiety"),
            new MenuOption("NeutralEmoji","Stress")
        };
        public static ObservableCollection<MeditationItem> DailyMeditationItems = new ObservableCollection<MeditationItem>
        {
            new MeditationItem(null,"Rest & Relax","",30),
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
