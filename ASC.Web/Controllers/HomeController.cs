using ASC.Utilities;
using ASC.Web.Configuration;
using ASC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace ASC.Web.Controllers
{
    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;*/

        private IOptions<ApplicationSettings> _settings;

        /*private IOptions<ApplicationSettings> @object;*/

        public HomeController(IOptions<ApplicationSettings> settings)
        {
            /*_logger = logger;*/
            _settings = settings;
        }

        /*public HomeController(IOptions<ApplicationSettings> @object)
        {
            this.@object = @object;
        }*/

        public IActionResult Index()
        {

            HttpContext.Session.SetSession("Test", _settings.Value);


            var settings = HttpContext.Session.GetSession<ApplicationSettings>("Test");


            ViewBag.Title = _settings.Value.ApplicationTitle;

            //// Test fail test case
            /*ViewData.Model = "Test";
            throw new Exception("Login Fail!!!");*/

            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
