using System.Text.Json.Serialization;

namespace TrafficAPI.Models;

public class UserInformation
{
    public string IpAddress { get; set; } = "";
    public string UserAgent { get; set; } = "";
    public DateTime RequestDate { get; set; }
    [JsonPropertyName("country")]
    public string Country { get; set; } = "";
    [JsonPropertyName("regionName")]
    public string RegionName { get; set; } = "";
    [JsonPropertyName("city")]
    public string City { get; set; } = "";
    [JsonPropertyName("zip")]
    public string Zip { get; set; } = "";
    [JsonPropertyName("lat")]
    public float Lat { get; set; }
    [JsonPropertyName("lon")]
    public float Lon { get; set; }
    [JsonPropertyName("timezone")]
    public string TimeZone { get; set; } = "";
    [JsonPropertyName("isp")]
    public string Isp { get; set; } = "";
}