using ElevateSecurityInterview.Response.Incident;
using ElevateSecurityInterview.Enum;

namespace ElevateSecurityInterview.Service.Incident
{
    public interface IIncidentService
    {
        public  Task<List<IncidentResponse>> GetIncidentsAsync(IncidentType incidentType);
    }
}
