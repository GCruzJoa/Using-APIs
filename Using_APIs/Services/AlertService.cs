using System.Threading.Tasks;

namespace Using_APIs.Services
{
    class AlertService : IAlertService
    {
        public Task DisplayAlertAsync(string title, string message)
        {
            return App.Current.MainPage.DisplayAlert(title, message, "Ok");
        }
    }
}
