using System.Threading.Tasks;

namespace Using_APIs.Services
{
    public interface IAlertService
    {
        Task DisplayAlertAsync(string title, string message);
    }
}
