using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ip.kyteks.com.Controllers
{
    public class RawController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            IPAddress remoteIp = Request.HttpContext.Connection.RemoteIpAddress;
            return Content(remoteIp.ToString());
        }
    }
}
