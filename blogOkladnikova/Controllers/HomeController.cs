using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using blogOkladnikova.Models;
using Microsoft.Extensions.Options;
using blogOkladnikova.Options;

namespace blogOkladnikova.Controllers
{
    /// <summary>
    /// Controller to communicate with the views Home
    /// </summary>

    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;
        private readonly IOptions<ServerInformation> _serverinformation;

        /// <summary>
        /// Constructer for class HomeController <see cref="HomeController"/>
        /// </summary>
        /// ILogger service used for logging is passed
        /// IOptions service used to implement the server side
        public HomeController(ILogger<HomeController> logger, IOptions<ServerInformation> serverinformation)  
        {
            _logger = logger;
            _serverinformation = serverinformation;
        }

        /// <summary>
        /// Method for returning a view Home->Index
        /// </summary>

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Method for returning a view Home->Privacy
        /// </summary>

        public IActionResult Privacy()
        {
            return View();
        }
        /// <summary>
        /// Method for returning error Models->ErrorViewModels
        /// </summary>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
