using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Using_APIs.Services
{
    public class NavigationService : INavigationService
    {
        public Task PopAsync()
        {
            return App.Current.MainPage.Navigation.PopAsync();
        }

        public Task PopModalAsync()
        {
            return App.Current.MainPage.Navigation.PopModalAsync();
        }

        public Task PushAsync(Page page)
        {
            return App.Current.MainPage.Navigation.PushAsync(page);
        }

        public Task PushModalAsync(Page page)
        {
            return App.Current.MainPage.Navigation.PushModalAsync(page);
        }
    }
}
