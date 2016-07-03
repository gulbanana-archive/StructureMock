using Lib.Common;
using Microsoft.AspNetCore.Mvc;

namespace Lib.Web
{
    [Route("api/[controller]")]
    public class PrintController : Controller
    {
        private readonly IFormatter _formatter;

        public PrintController(IFormatter formatter)
        {
            _formatter = formatter;
        }

        [HttpGet]
        public string Get()
        {
            return Printer.Print(_formatter);
        }
    }
}
