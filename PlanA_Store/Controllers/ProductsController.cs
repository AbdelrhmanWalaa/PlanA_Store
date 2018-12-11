using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlanA_Store.DataContext;
using PlanA_Store.Models;

namespace PlanA_Store.Controllers
{
    public class ProductsController : Controller
    {
        private readonly MyContext _context;

        public ProductsController(MyContext context)
        {
            _context = context;
        }

        // GET: Products
        public  IActionResult Index()
        {
            var myContext = _context.Products.Include(p => p._Admin);
            return View( myContext.ToList());
        }

        // GET: Products/Details/5
        public  IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product =  _context.Products
                .Include(p => p._Admin)
                .FirstOrDefault(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["AdminID"] = new SelectList(_context.Admins, "AdminID", "FirstName");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create([Bind("ProductID,ProductName,UnitPrice,AdminID")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                 _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdminID"] = new SelectList(_context.Admins, "AdminID", "FirstName", product.AdminID);
            return View(product);
        }

        // GET: Products/Edit/5
        public  IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product =  _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["AdminID"] = new SelectList(_context.Admins, "AdminID", "FirstName", product.AdminID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Edit(int id, [Bind("ProductID,ProductName,UnitPrice,AdminID")] Product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                     _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdminID"] = new SelectList(_context.Admins, "AdminID", "FirstName", product.AdminID);
            return View(product);
        }

        // GET: Products/Delete/5
        public  IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product =  _context.Products
                .Include(p => p._Admin)
                .FirstOrDefault(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public  IActionResult DeleteConfirmed(int id)
        {
            var product =  _context.Products.Find(id);
            _context.Products.Remove(product);
             _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }
    }
}
