using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KiemtraMVC.Data;
using KiemtraMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace KiemtraMVC.Controllers
{
    public class TinhController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TinhController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Tinh> objList = _db.Tinhs;
            return View(objList);
        }

        //Create Tinh
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tinh obj)
        {
            if (ModelState.IsValid)
            {
                _db.Tinhs.Add(obj);
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
            var b = _db.Tinhs.Find(id);
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
                var b = _db.Tinhs.Find(id);
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
        public IActionResult Update(Tinh tinh)
        {
            if (ModelState.IsValid)
            {
                _db.Update(tinh);
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
        // POST-DELETE
        [HttpPost]
        public IActionResult Delete(Tinh obj)
        {
            _db.Tinhs.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}
