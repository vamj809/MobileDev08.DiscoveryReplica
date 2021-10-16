using MobileDev08.DiscoveryReplica.Models;
using MobileDev08.DiscoveryReplica.StaticResources;
using Prism.Navigation;
using System.Collections.ObjectModel;

namespace MobileDev08.DiscoveryReplica.ViewModels
{
    public class DetailsPageViewModel : BaseViewModel, IInitialize
    {
        public MeditationItem DailyMeditationItem { get; set; }
        public DetailsPageViewModel(INavigationService navigationService) : base(navigationService) { }
        public void Initialize(INavigationParameters parameters)
        {
            if (parameters.TryGetValue(NavigationConstants.Parameters.MeditationItem, out MeditationItem dailyMeditationItem))
            {
                DailyMeditationItem = dailyMeditationItem;
            }
        }
    }
}
