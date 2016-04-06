using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using SampleCRUD.Models;

namespace SampleCRUD.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        DatabaseContext db = new DatabaseContext();
        public ActionResult Index()
        {
            var x = db.users.ToList();
            return View(x);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Users user)
        {
            if (ModelState.IsValid)
            {
                db.users.Add(user);
                db.SaveChanges();
            }
            TempData["Message"] = "Successfully add employee";
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var x = db.users.Find(id);
            if (x == null)
            {
                return HttpNotFound();
            }
            return View(x);
        }
        [HttpPost]
        public ActionResult Edit(Users user)
        {
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();
            TempData["Message"] = "Successfully edit employee";
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var x = db.users.Find(id);
            if (x == null)
            {
                return HttpNotFound();
            }
            return View(x);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Users user = db.users.Find(id);
            db.users.Remove(user);
            db.SaveChanges();
            TempData["Message"] = "Successfully delete employee";
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var x = db.users.Find(id);
            if (x == null)
            {
                return HttpNotFound();
            }
            return View(x);
        }
    }
}
