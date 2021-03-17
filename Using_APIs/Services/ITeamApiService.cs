using System.Threading.Tasks;

namespace Using_APIs.Services
{
    public interface ITeamApiService
    {
        Task<Team> GetSportsTeamsAsync();
    }
}
