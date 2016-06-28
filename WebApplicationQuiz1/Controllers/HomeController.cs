using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationQuiz1.Models;

namespace WebApplicationQuiz1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Curriculum";

            return View(new partialview() { partialModel = Sampledetails() });
        }

        private List<partialview> Sampledetails()
        {
            List<partialview> model = new List<partialview>();

            model.Add(new partialview()
            {

                Name = "Alexander",
                Description = "Estudiante",
                Details = "Ingieneria en software",
                Date = "27/06/2016"

            });

            model.Add(new partialview()
            {

                Name = "Alexander",
                Description = "Estudiante",
                Details = "Ingieneria en software",
                Date = "27/06/2016"
            });
        

            return model;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

       /* public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}