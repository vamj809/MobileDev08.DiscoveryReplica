using Prism.Navigation;
using System.ComponentModel;

namespace MobileDev08.DiscoveryReplica.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        INavigationService _navigationService;
        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
