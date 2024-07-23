using Microsoft.AspNetCore.Mvc;

namespace TrafficAPI.Controllers;

public class TrafficController : Controller
{
    [HttpGet]
    [Route("trafficApi/getUserInformation")]
    public IActionResult GetUserInformation()
    {
        var ipAddress = HttpContext.Connection.RemoteIpAddress?.ToString();
        var userAgent = HttpContext.Request.Headers["User-Agent"].ToString();

        var userInformation = new UserInformation
        {
            IpAddress = ipAddress,
            UserAgent = userAgent,
            RequestDate = DateTime.UtcNow
        };

        return Ok(userInformation);
    }
}