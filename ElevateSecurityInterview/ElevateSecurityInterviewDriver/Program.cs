// See https://aka.ms/new-console-template for more information
using ElevateSecurityInterview.Enum;
using ElevateSecurityInterview.Service.Incident;

var service = new IncidentService();
await service.GetIncidentsAsync(IncidentType.denial);

//var json = Newtonsoft.Json.JsonConvert.SerializeObject();
Console.WriteLine("");
