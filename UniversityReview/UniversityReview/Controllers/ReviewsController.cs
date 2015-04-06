using System;
using System.Collections.Generic;
using System.Data;
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
        //22
        public ActionResult Index([Bind(Prefix = "id")] int restaurantId)
        {
            var university = _db.Universities.Find(restaurantId);
            if (university != null)
            {
                return View(university);
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create(int UniversityId)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(UniversityReviews review)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.UniversityId });
            }
            return View(review);
        }
        [HttpPost]
        public ActionResult Edit(UniversityReviews review)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(review).State = EntityState.Modified;

                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.UniversityId });
            }
            return View(review);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = _db.Reviews.Find(id);
            return View(model);
        }
          protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
