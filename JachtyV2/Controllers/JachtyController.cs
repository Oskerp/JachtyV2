using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;


namespace JachtyV2.Controllers
{
    public class JachtyController : Controller
    {
        JachtyContext db = new JachtyContext();


        public ActionResult JM() {
            return View(db.Jachty2.ToList());
        }

        public ActionResult Zarezerwowano()
        {
            return View(db.Jachty2.ToList());
        }

        public ActionResult Zamowienia()
        {
            ViewBag.id = System.Web.HttpContext.Current.User.Identity.GetUserId();
            return View(db.Wypozyczenie2.ToList());
        }


        public ActionResult JSL()
        {
            return View(db.Jachty2.ToList());
        }

        public ActionResult Blad()
        {
            return View();
        }



        [HttpGet]
        public ActionResult Wypo(int? id) {
            ViewBag.id = id;
            return View();
        }



       [HttpPost]
        public ActionResult Wypo(Wypozyczenie2 ID) {
            if (ModelState.IsValid)
            {
                string _UserID = System.Web.HttpContext.Current.User.Identity.GetUserId();
                if (ID.UserID != null)
                {
                    
                    ID.UserID = _UserID;
                    db.Wypozyczenie2.Add(ID);
                    db.SaveChanges();
                    return RedirectToAction("Zamowienia");
                }

                else {
                    return RedirectToAction("Blad");
                }
                
            }
            else {
                return RedirectToAction("Wypo");
            }
        }
    }
}