using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ParcialFriend.Models;

namespace ParcialFriend.Controllers
{
    public class JoseCalvimontesFriendsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: JoseCalvimontesFriends
        public ActionResult Index()
        {
            return View(db.JoseCalvimontesFriends.ToList());
        }

        // GET: JoseCalvimontesFriends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JoseCalvimontesFriend joseCalvimontesFriend = db.JoseCalvimontesFriends.Find(id);
            if (joseCalvimontesFriend == null)
            {
                return HttpNotFound();
            }
            return View(joseCalvimontesFriend);
        }

        // GET: JoseCalvimontesFriends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JoseCalvimontesFriends/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FriendId,Name,NickName,Birthdate,Type")] JoseCalvimontesFriend joseCalvimontesFriend)
        {
            if (ModelState.IsValid)
            {
                db.JoseCalvimontesFriends.Add(joseCalvimontesFriend);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(joseCalvimontesFriend);
        }

        // GET: JoseCalvimontesFriends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JoseCalvimontesFriend joseCalvimontesFriend = db.JoseCalvimontesFriends.Find(id);
            if (joseCalvimontesFriend == null)
            {
                return HttpNotFound();
            }
            return View(joseCalvimontesFriend);
        }

        // POST: JoseCalvimontesFriends/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FriendId,Name,NickName,Birthdate,Type")] JoseCalvimontesFriend joseCalvimontesFriend)
        {
            if (ModelState.IsValid)
            {
                db.Entry(joseCalvimontesFriend).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(joseCalvimontesFriend);
        }

        // GET: JoseCalvimontesFriends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JoseCalvimontesFriend joseCalvimontesFriend = db.JoseCalvimontesFriends.Find(id);
            if (joseCalvimontesFriend == null)
            {
                return HttpNotFound();
            }
            return View(joseCalvimontesFriend);
        }

        // POST: JoseCalvimontesFriends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JoseCalvimontesFriend joseCalvimontesFriend = db.JoseCalvimontesFriends.Find(id);
            db.JoseCalvimontesFriends.Remove(joseCalvimontesFriend);
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
