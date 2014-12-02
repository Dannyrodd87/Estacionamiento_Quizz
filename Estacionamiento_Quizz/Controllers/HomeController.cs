using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Estacionamiento_Quizz.Models;

namespace Estacionamiento_Quizz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet] 
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Carros car)
        {
            
            Call lugares = new Call(
                @"C:\Users\Vanessa\Documents\Visual Studio 2012\Projects\DAW\Estacionamiento_Quizz\Models\Placass.csv");
         
            
            var usuario = lugares.GetEmployeeById(car.Matricula);

        

            return View("Datos", usuario);
         }

    }
}
