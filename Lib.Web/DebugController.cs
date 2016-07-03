using Lib.Common;
using Microsoft.AspNetCore.Mvc;

namespace Lib.Web
{
    [Route("api/[controller]")]
    public class DebugController : Controller
    {
        private readonly IFormatter _formatter;

        public DebugController(IFormatter formatter)
        {
            _formatter = formatter;
        }

        // GET api/value
        [HttpGet]
        public string Get()
        {
            Printer.Print(_formatter);
            return "Check output window for result.";
        }
    }
}
