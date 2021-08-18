using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class WeddingController : Controller
    {

        private WeddingPlannerContext db;
        public WeddingController(WeddingPlannerContext context)
        {
            db = context;
        }

        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserID");
            }
        }

        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }

        [HttpGet("/dashboard")]
        public IActionResult Dashboard()
        {
            if(!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            List<Wedding> allWeddings = db.Weddings.Include(wed => wed.Attendees).ThenInclude(a => a.User).ToList();
            return View("Dashboard", allWeddings);
        }

        [HttpGet("/new")]
        public IActionResult New()
        {
            if(!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            return View("New");
        }

        [HttpPost("/createwedding")]
        public IActionResult CreateWedding(Wedding newWed)
        {
            if(!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            if(!ModelState.IsValid)
            {
                return View("New");
            }
            if(ModelState.IsValid)
            {
                if(newWed.Date< DateTime.Now)
                {
                    ModelState.AddModelError("Date", "Date must be in the future.");
                    return View("New");
                }
            }
            newWed.UserID = (int)uid;
            db.Weddings.Add(newWed);
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        
        [HttpGet("/view/{weddingID}")]
        public IActionResult View(int weddingID)
        {
            if(!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            Wedding Details = db.Weddings.Include(wed => wed.Attendees).ThenInclude(a => a.User).FirstOrDefault(w => w.WeddingID == weddingID);
            return View("View", Details);
        }

        [HttpPost("/rsvp/{weddingID}")]
        public IActionResult RSVP(int weddingID)
        {
            if(!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Attendance rsvp = db.Attendances.FirstOrDefault(at => at.UserID == (int)uid && at.WeddingID == weddingID);
            
            if(rsvp==null)
            {
                Attendance newGuest = new Attendance()
                {
                    WeddingID = weddingID,
                    UserID = (int)uid
                };
                db.Attendances.Add(newGuest);
            }
            else
            {
                db.Attendances.Remove(rsvp);
            }
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpPost("/delete/{weddingID}")]
        public IActionResult Delete(int weddingID)
        {
            Wedding wedding = db.Weddings.FirstOrDefault(w => w.WeddingID == weddingID && w.UserID == (int)uid);
            db.Weddings.Remove(wedding);
            db.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}