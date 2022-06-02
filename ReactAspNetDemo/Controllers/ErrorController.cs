using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReactAspNetDemo.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error/{statusCode}")]
        public ActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage("Resource could not be found.");
                    break;
            }
            return View("Error");
        }
    }
}
