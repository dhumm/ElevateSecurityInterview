using ElevateSecurityInterview.Enum;
using ElevateSecurityInterview.Response.Incident;
using Flurl.Http;

namespace ElevateSecurityInterview.Service.Incident
{
    public class IncidentService : IIncidentService
    {
        public async Task<List<IncidentResponse>> GetIncidentsAsync(IncidentType incidentType)
        {
            var result = await "https://incident-api.use1stag.elevatesecurity.io/incidents/denial/"
                .WithBasicAuth("elevateinterviews", "ElevateSecurityInterviews2021").GetAsync();
            return (await result.GetJsonAsync<IncidentResponseList>()).results;
        }
    }
}
