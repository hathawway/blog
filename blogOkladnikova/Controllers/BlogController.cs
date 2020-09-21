using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace blogOkladnikova.Controllers
{
    /// <summary>
    /// Controller to communicate with the view Blog
    /// </summary>

    public class BlogController : Controller
    {
        /// <summary>
        /// Method for returning a view Blog->Index
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }
    }
}
