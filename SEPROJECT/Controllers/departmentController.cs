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
    public class departmentController : Controller
    {
        dataContext db = new dataContext();
        // GET: department
        public ActionResult Index()
        {
            var departmentdata = db.departments.ToList();
            return View(departmentdata);
        }

        // GET: department/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            department dep = db.departments.Find(id);
            if (dep == null)
            {
                return HttpNotFound();
            }
            return View(dep);
        }

        // GET: department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: department/Create
        [HttpPost]
        public ActionResult Create(department dpt)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.departments.Add(dpt);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(dpt);
            }
            catch
            {
                return View();
            }
        }

        // GET: department/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            department dpt = db.departments.Find(id);
            if (dpt == null)
            {
                return HttpNotFound();
            }
            return View(dpt);
        }

        // POST: department/Edit/5
        [HttpPost]
        public ActionResult Edit(department dpt)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(dpt).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(dpt);
            }
            catch
            {
                return View();
            }
        }

        // GET: department/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            department dpt = db.departments.Find(id);
            if (dpt == null)
            {
                return HttpNotFound();
            }
            return View(dpt);
        }

        // POST: department/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            department dpt = db.departments.Find(id);
            db.departments.Remove(dpt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
