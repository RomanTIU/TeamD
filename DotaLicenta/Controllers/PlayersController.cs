using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DotaLicenta.Models;
using ElectronicLicenta.Models;

namespace DotaLicenta.Controllers
{
    public class PlayersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
         

        // GET: Players
        public ActionResult Index()
        {
            return View(db.Players.ToList());
        }

        // GET: Players/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // GET: Players/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NickName,FirstName,SurName,Email,Adress,Role,Rating,Age,ImagePath,Country,Nationality,City,AboutMe,Owner")] Player player,HttpPostedFileBase uploadImage)
        {
            if (ModelState.IsValid)
            {
                if (uploadImage != null)
                {
                    if (uploadImage.ContentType == "image/jpg" ||
                        uploadImage.ContentType == "image/png" ||
                        uploadImage.ContentType == "image/jpeg" ||
                        uploadImage.ContentType == "image/gif")
                    {
                        uploadImage.SaveAs(Server.MapPath("/") + "/Content/Image/" + uploadImage.FileName);
                        player.ImagePath = uploadImage.FileName;
                    }
                    else
                        return View();
                }
                else return View();

                
                db.Players.Add(player);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(player);
        }

        // GET: Players/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NickName,FirstName,SurName,Email,Adress,Role,Rating,Age,ImagePath,Country,Nationality,City,AboutMe")] Player player,HttpPostedFileBase uploadImage)
        {
            if (ModelState.IsValid)
            {
                if (uploadImage != null)
                {
                    if (uploadImage.ContentType == "image/jpg" ||
                        uploadImage.ContentType == "image/png" ||
                        uploadImage.ContentType == "image/jpeg" ||
                        uploadImage.ContentType == "image/gif")
                    {
                        uploadImage.SaveAs(Server.MapPath("/") + "/Content/Image/" + uploadImage.FileName);
                        player.ImagePath = uploadImage.FileName;
                    }
                    else
                        return View();
                }
                else return View();


                db.Entry(player).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(player);
        }

        // GET: Players/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return HttpNotFound();
            }
            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
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
