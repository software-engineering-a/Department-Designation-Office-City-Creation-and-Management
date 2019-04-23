using SEPROJECT.Context;
using SEPROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SEPROJECT.Controllers
{
    public class officeController : Controller
    {
        dataContext db = new dataContext();
        // GET: office
        public ActionResult Index()
        {
            var officedata = db.offices.ToList();
            return View(officedata);
        }

        // GET: office/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            office off = db.offices.Find(id);
            if (off == null)
            {
                return HttpNotFound();
            }
            return View(off);
        }

        // GET: office/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: office/Create
        [HttpPost]
        public ActionResult Create(office off)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.offices.Add(off);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(off);
            }
            catch
            {
                return View();
            }
        }

        // GET: office/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            office off = db.offices.Find(id);
            if (off == null)
            {
                return HttpNotFound();
            }
            return View(off);
        }

        // POST: office/Edit/5
        [HttpPost]
        public ActionResult Edit(office off)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(off).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(off);
            }
            catch
            {
                return View();
            }
        }

        // GET: office/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            office off = db.offices.Find(id);
            if (off == null)
            {
                return HttpNotFound();
            }
            return View(off);
        }

        // POST: office/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            office off = db.offices.Find(id);
            db.offices.Remove(off);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
