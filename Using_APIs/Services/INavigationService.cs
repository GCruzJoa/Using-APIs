using System.Threading.Tasks;
using Xamarin.Forms;

namespace Using_APIs.Services
{
    public interface INavigationService
    {
        Task PushAsync(Page page);
        Task PushModalAsync(Page page);
        Task PopAsync();
        Task PopModalAsync();
    }
}
