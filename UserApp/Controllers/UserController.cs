using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace UserApp.Controllers
{
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly string connectionString;

        public UserController(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("SqlDb");
        }

        public IActionResult Index()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}