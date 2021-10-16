using MobileDev08.DiscoveryReplica.Models;
using MobileDev08.DiscoveryReplica.StaticResources;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileDev08.DiscoveryReplica.ViewModels
{
    public class HomePageViewModel : BaseViewModel, INavigatedAware
    {
        private MeditationItem _selectedDailyMeditationItem;
        public MeditationItem SelectedMeditationItem
        {
            get
            {
                return _selectedDailyMeditationItem;
            }

            set
            {
                _selectedDailyMeditationItem = value;
                if (_selectedDailyMeditationItem != null)
                {
                    GoToDetailsCommand.Execute(_selectedDailyMeditationItem);
                }
            }
        }

        public DelegateCommand<MeditationItem> GoToDetailsCommand { get; }
        public HomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            GoToDetailsCommand = new DelegateCommand<MeditationItem>(
                async (MeditationItem meditationItem) =>
                {
                    await navigationService.NavigateAsync(NavigationConstants.Paths.DetailsPage, new NavigationParameters()
                    {
                        { NavigationConstants.Parameters.MeditationItem, meditationItem }
                    });
                });
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            
        }
    }
}
