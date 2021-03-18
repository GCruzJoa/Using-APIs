using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Using_APIs.Services
{
    public class TeamApiService : ITeamApiService
    {
        ISerializerService serializerService = new SerializerService();

        public async Task<Team> GetSportsTeamsAsync()
        {
            Team SportsTeams = null;
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://sportscore1.p.rapidapi.com/teams"),
                Headers =
                {
                    { "x-rapidapi-key", "" },
                    { "x-rapidapi-host", "sportscore1.p.rapidapi.com" },
                },
            };
            var client = new HttpClient();
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                SportsTeams = serializerService.Deserialize<Team>(await response.Content.ReadAsStringAsync());
            }
            return SportsTeams;
        }
    }
}
