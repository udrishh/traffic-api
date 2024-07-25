using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using TrafficAPI.Models;

namespace TrafficAPI.Controllers;

public class TrafficController : Controller
{
    [HttpGet]
    [Route("trafficApi/getUserInformation")]
    public async Task<IActionResult> GetUserInformation()
    {
        var ipAddress = HttpContext.Connection.RemoteIpAddress?.ToString();
        var userAgent = HttpContext.Request.Headers["User-Agent"].ToString();

        if (ipAddress == null)
        {
            return Empty;
        }

        var userInformation = await GetIpLocalization(ipAddress);

        userInformation.IpAddress = ipAddress;
        userInformation.UserAgent = userAgent;
        userInformation.RequestDate = DateTime.UtcNow;

        return Ok(userInformation);
    }

    private async Task<UserInformation> GetIpLocalization(string ipAddress)
    {
        var userInformation = new UserInformation();

        using var client = new HttpClient();
        var apiUrl = $"http://ip-api.com/json/{ipAddress}";
        var response = await client.GetAsync(apiUrl);

        if (!response.IsSuccessStatusCode) return userInformation;
        
        var json = await response.Content.ReadAsStringAsync();
        userInformation = JsonSerializer.Deserialize<UserInformation>(json);

        return userInformation ?? new UserInformation();

    }
}