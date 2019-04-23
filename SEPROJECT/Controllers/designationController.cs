using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SEPROJECT.Context;
using SEPROJECT.Models;

namespace SEPROJECT.Controllers
{
    public class designationController : Controller
    {
        dataContext db = new dataContext();
        // GET: designation
        public ActionResult Index()
        {
            var designationdata = db.designations.ToList();
            return View(designationdata);
        }

        // GET: designation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            designation des = db.designations.Find(id);
            if (des == null)
            {
                return HttpNotFound();
            }
            return View(des);
        }

        // GET: designation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: designation/Create
        [HttpPost]
        public ActionResult Create(designation desg)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.designations.Add(desg);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(desg);
            }
            catch
            {
                return View();
            }
        }

        // GET: designation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            designation des = db.designations.Find(id);
            if (des == null)
            {
                return HttpNotFound();
            }
            return View(des);
        }

        // POST: designation/Edit/5
        [HttpPost]
        public ActionResult Edit(designation dsg)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(dsg).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(dsg);
            }
            catch
            {
                return View();
            }
        }

        // GET: designation/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            designation dsg = db.designations.Find(id);
            if (dsg == null)
            {
                return HttpNotFound();
            }
            return View(dsg);
        }

        // POST: designation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            designation dsg = db.designations.Find(id);
            db.designations.Remove(dsg);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
