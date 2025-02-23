

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MA.Controllers
{
    public class PresenceController : Controller
    {
        private readonly ILogger<PresenceController> _logger;

        public PresenceController(ILogger<PresenceController> logger)
        {
            _logger = logger;
        }

        public IActionResult Presence()
        {
            return View();
        }
    }
}
