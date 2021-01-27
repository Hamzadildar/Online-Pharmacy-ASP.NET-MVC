﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using project.Models;

namespace project.Controllers
{
    public class LoginsController : Controller
    {
        private MedicineContext db = new MedicineContext();

        // GET: Logins
        //public ActionResult Index()
        //{
        //    return View(db.Logins.ToList());
        //}

        //// GET: Logins/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Login login = db.Logins.Find(id);
        //    if (login == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(login);
        //}

        // GET: Logins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Logins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,UserName,Password")] Login login)
        {
            if (ModelState.IsValid)
            {
                SignUp user = db.SignUps.FirstOrDefault(x => x.Password == login.Password && x.UserName == login.UserName);
                if (user!=null)
                {
                    Session["ID"] = user.Id;
                    return RedirectToAction("index", "AdminView");
                }
            }

            return View(login);
        }

        // GET: Logins/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Login login = db.Logins.Find(id);
        //    if (login == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(login);
        //}

        //// POST: Logins/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,UserName,Password")] Login login)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(login).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(login);
        //}

        //// GET: Logins/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Login login = db.Logins.Find(id);
        //    if (login == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(login);
        //}

        //// POST: Logins/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Login login = db.Logins.Find(id);
        //    db.Logins.Remove(login);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
