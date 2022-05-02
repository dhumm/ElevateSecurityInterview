using ElevateSecurityInterview.Enum;

namespace ElevateSecurityInterview.Response.Incident
{
    public class IntrusionIncidentResponse : IncidentResponse
    {
        string internal_ip { get; set; }
        string source_ip { get; set; }
    }
}
