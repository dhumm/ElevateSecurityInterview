using ElevateSecurityInterview.Enum;

namespace ElevateSecurityInterview.Response.Incident
{
    public class DenialIncidentResponse : IncidentResponse
    {
        int reported_by { get; set; }
        string source_ip { get; set; }
    }
}
