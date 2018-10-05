using asp_ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace asp_ajax.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            TablesViewModel tables= new TablesViewModel();

            tables.Independent = _context.Independent.ToList();
            tables.Responses = _context.Responses.ToList();
            tables.MathFunctions = _context.MathFunction.ToList();
         

            return View(tables);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page";

            return View();
        }
        [HttpPost]
        public JsonResult GetIndependent(int id)
        {
            var ind = _context.Independent.SingleOrDefault(s=>s.Id==id) as Independent;
            return Json(ind);
        }
        [HttpPost]
        public JsonResult GetResponse(int id)
        {
            var ind = _context.Responses.SingleOrDefault(s => s.Id == id) as Responses;
            return Json(ind);
        }

        [HttpPost]
        public JsonResult GetMathFunction(int id)
        {
            var ind = _context.MathFunction.SingleOrDefault(s => s.Id == id) as MathFunction;
            return Json(ind);
        }

    }
}