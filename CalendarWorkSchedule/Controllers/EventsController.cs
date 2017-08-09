using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalendarWorkSchedule.Models;

namespace CalendarWorkSchedule.Controllers
{
    public class EventsController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Events
        public ActionResult Index()
        {
            var listevents = db.Events.ToList();
            return View(listevents);
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Event events)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(events);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(events);
        }

        public ActionResult SingleEvent(long id)
        {
            var eventId = db.Events.Find(id);
            return View(eventId);
        }

        [HttpPost]
        public ActionResult SingleEvent(long id, Comment newComment)
        {
            if (ModelState.IsValid)
            {
                newComment.Event = db.Events.Find(id);
                db.Comment.Add(newComment);
                db.SaveChanges();
                return RedirectToAction("SingleEvent", new { Id = id });
            }
            return SingleEvent(id);

        }
    }
}