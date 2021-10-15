﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDev08.DiscoveryReplica.Models
{
    public class MeditationItem
    {
        public string[] Images { get; }
        public string Title { get; }
        public string Description { get; }
        public int Duration { get; }
        public string DurationMeasure { get; }
        public MeditationItem(string[] images, string title, string description, int duration, string durationMeasure = "mins.")
        {
            Images = images;
            Title = title;
            Description = description;
            Duration = duration;
            DurationMeasure = durationMeasure;
        }
    }
}
