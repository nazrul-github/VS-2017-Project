using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UniversityManagement.Models;

namespace UniversityManagement.Controllers
{
    public class CourseAssignsController : Controller
    {
        private University_DBEntities db = new University_DBEntities();

        // GET: CourseAssigns
        public ActionResult Index()
        {
            var courseAssigns = db.CourseAssigns.Include(c => c.Course).Include(c => c.Department).Include(c => c.Teacher);
            return View(courseAssigns.ToList());
        }

        // GET: CourseAssigns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseAssign courseAssign = db.CourseAssigns.Find(id);
            if (courseAssign == null)
            {
                return HttpNotFound();
            }
            return View(courseAssign);
        }

        // GET: CourseAssigns/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "DepartmentName");
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseCode");
            ViewBag.TeacherId = new SelectList(db.Teachers, "Id", "Name");
            return View();
        }

        // POST: CourseAssigns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,DepartmentId,TeacherId,CreditToBeTaken,RemainingCredit,CourseId,CourseName")] CourseAssign courseAssign)
        {
            if (ModelState.IsValid)
            {
                db.CourseAssigns.Add(courseAssign);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseCode", courseAssign.CourseId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "DepartmentName", courseAssign.DepartmentId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "Id", "Name", courseAssign.TeacherId);
            return View(courseAssign);
        }

        // GET: CourseAssigns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseAssign courseAssign = db.CourseAssigns.Find(id);
            if (courseAssign == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseCode", courseAssign.CourseId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "DepartmentName", courseAssign.DepartmentId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "Id", "Name", courseAssign.TeacherId);
            return View(courseAssign);
        }

        // POST: CourseAssigns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,DepartmentId,TeacherId,CreditToBeTaken,RemainingCredit,CourseId,CourseName")] CourseAssign courseAssign)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseAssign).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseCode", courseAssign.CourseId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "DepartmentName", courseAssign.DepartmentId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "Id", "Name", courseAssign.TeacherId);
            return View(courseAssign);
        }

        // GET: CourseAssigns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseAssign courseAssign = db.CourseAssigns.Find(id);
            if (courseAssign == null)
            {
                return HttpNotFound();
            }
            return View(courseAssign);
        }

        // POST: CourseAssigns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseAssign courseAssign = db.CourseAssigns.Find(id);
            db.CourseAssigns.Remove(courseAssign);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
