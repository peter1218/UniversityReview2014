using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityReview.Models;

namespace UniversityReview.Controllers
{
    public class HomeController : Controller
    {
        UniRatingDB _db = new UniRatingDB();
        public ActionResult Index(string searchTerm = null)
        {
           // ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var model =
                          _db.Universities
                             .OrderByDescending(r => r.Reviews.Average(review => review.Rating))
                             .Where(r => searchTerm == null || r.Name.StartsWith(searchTerm))

                             .Select(r => new UniversityListViewModel
                             {
                                 Id = r.Id,
                                 Name = r.Name,
                                 City = r.City,

                                 CountOfReviews = r.Reviews.Count()
                             });


            //if (Request.IsAjaxRequest())
            //{
            //    return PartialView("_University", model);
            //}

            return View(model);
       
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";///
            //123
            //aidiotn feature 1 change
            //feature 1.1change
            //command change

            //change after push
            //more change after push
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {

            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
