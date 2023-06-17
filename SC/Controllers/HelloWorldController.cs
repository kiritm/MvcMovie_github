using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}
        public IActionResult Index()
        {
            return View();
        }
        //Output using this URL https://localhost:7223/HelloWorld
        // 
        // GET: /HelloWorld/Welcome/ 
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
        // Output using this URL https://localhost:7223/HelloWorld/Welcome/3?name=Rick


        // GET: /HelloWorld/WelcomeParam/ 
        // Requires using System.Text.Encodings.Web;
        public string WelcomeParam(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        //Output using this URL https://localhost:7223/HelloWorld/WelcomeParam?name=Rick&numtimes=4


        public IActionResult WelcomeParam2View(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
