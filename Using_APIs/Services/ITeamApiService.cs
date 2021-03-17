using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Using_APIs.Services
{
    public interface ITeamApiService
    {
        Task<Team> GetSportsTeamsAsync();
    }
}
