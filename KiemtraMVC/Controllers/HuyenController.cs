using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KiemtraMVC.Data;
using KiemtraMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace KiemtraMVC.Controllers
{
    public class HuyenController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HuyenController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Huyen> objList = _db.Huyens;
            return View(objList);
        }

        //Create Huyen
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Huyen obj)
        {
            if (ModelState.IsValid)
            {
                _db.Huyens.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        //Details
        public IActionResult Details(int id)
        {
            var b = _db.Huyens.Find(id);
            if (b == null)
            {
                return NotFound();
            }
            else
            {
                return View(b);
            }
        }

        //Update
        public IActionResult Update(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                var b = _db.Huyens.Find(id);
                if (b == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(b);
                }
            }
        }
        [HttpPost]
        public IActionResult Update(Huyen huyen)
        {
            if (ModelState.IsValid)
            {
                _db.Update(huyen);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }

        //Delete
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
                return NotFound();
            var b = _db.Huyens.Find(id);
            if (b == null) 
                return NotFound();
            else 
                return View(b);
        }
        [HttpPost]
        public IActionResult Delete(Huyen obj)
        {
            _db.Huyens.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
