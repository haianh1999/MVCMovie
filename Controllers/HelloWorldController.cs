using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCMOVIE.Controllers
{
    public class HelloWorldController : Controller
    {
        //action index
        public IActionResult Index(){
            return View();
        }

        public IActionResult Demo(){
            return View();
        }
    }
}