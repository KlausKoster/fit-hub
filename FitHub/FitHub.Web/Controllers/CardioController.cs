using FitHub.Web.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitHub.Web.Controllers
{
    public class CardioController : Controller
    {
        private static List<CardioWorkout> _workouts = new List<CardioWorkout>();

        // GET: Cardio
        public ActionResult Index()
        {
            for (int i = 0; i < 10; i++)
            {
                _workouts.Add(new CardioWorkout
                {
                    Activity = "Run",
                    Date = DateTime.Now,
                    Distance = 4.6,
                    Duration = TimeSpan.FromHours(i + 1),
                    Id = i
                });

            }
            return View(_workouts);
        }

        // GET: Cardio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cardio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cardio/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cardio/Edit/5
        public ActionResult Edit(int id)
        {
            CardioWorkout model = _workouts.Where(w => w.Id == id).SingleOrDefault();
            if(model == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        // POST: Cardio/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cardio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cardio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
