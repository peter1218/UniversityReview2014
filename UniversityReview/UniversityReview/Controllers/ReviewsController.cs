using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityReview.Models;

namespace UniversityReview.Controllers
{  
    public class ReviewsController : Controller
    {
        UniRatingDB _db = new UniRatingDB();
        //
        // GET: /Reviews/

        public ActionResult Index([Bind(Prefix = "id")] int restaurantId)
        {
            var university = _db.Universities.Find(restaurantId);
            if (university != null)
            {
                return View(university);
            }
            return HttpNotFound();
        }
          protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
