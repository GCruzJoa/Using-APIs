using System.Collections.ObjectModel;
using System.Windows.Input;
using Using_APIs.Models;
using Using_APIs.Services;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Using_APIs.ViewModels
{
    public class TeamViewModel : BaseViewModel
    {
        public ObservableCollection<Datum> Teams { get; set; }
        public ICommand GetTeams { get; }

        private ITeamApiService teamApiService;

        public bool IsBusy { get; set; }
        public bool IsNotBusy => !IsBusy;

        public TeamViewModel(IAlertService alertService) : base(alertService)
        {
            teamApiService = new TeamApiService();
            GetTeams = new Command(LoadTeams);
        }

        private async void LoadTeams()
        {
            IsBusy = true;
            if (!(Connectivity.NetworkAccess == NetworkAccess.Internet))
            {
                await AlertService.DisplayAlertAsync("Error", "No internet connection, try later.");
            }
            else
            {
                var teams = await teamApiService.GetSportsTeamsAsync();
                Teams = teams.Data;
            }
            IsBusy = false;
        }
    }
}
