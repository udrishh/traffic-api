using System.Text.Json.Serialization;

namespace TrafficAPI.Models;

public class UserInformation
{
    public string IpAddress { get; set; } = "";
    public string UserAgent { get; set; } = "";
    public DateTime RequestDate { get; set; }
    public string Country { get; set; } = "";
    public string Region { get; set; } = "";
    public string City { get; set; } = "";
    public string Zip { get; set; } = "";
    public float Lat { get; set; }
    public float Lon { get; set; }
    public string TimeZone { get; set; } = "";
    public string Isp { get; set; } = "";
}