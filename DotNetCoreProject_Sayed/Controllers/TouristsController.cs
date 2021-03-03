using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DotNetCoreProject_Sayed.Data;
using DotNetCoreProject_Sayed.Models;

namespace DotNetCoreProject_Sayed.Controllers
{
    public class TouristsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public readonly IHostingEnvironment _hostingEnvironment;

        public TouristsController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
        public async Task<ActionResult> Index()
        {
            ViewBag.CategoryID = new SelectList(_context.Tourists, "Id", "Name");
            return View(await _context.Tourists.ToListAsync());
        }
        public ActionResult TouristOrder(long? id)
        {
            if (id == null)
            {
                NotFound();
            }

            ViewData["id"] = id;
            List<Order> orders = _context.Orders.Where(e => e.TouristID == id).ToList();

            if (orders == null)
            {
                NotFound();
            }

            return PartialView("TouristOrder", orders);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order orders, Tourist tourist, IFormFile[] Image)
        {
            try
            {

                if (Image != null)
                {
                    if (tourist.Orders.Count == Image.Count())
                    {
                        for (int i = 0; i < tourist.Orders.Count; i++)
                        {

                            string picture = System.IO.Path.GetFileName(Image[i].FileName);
                            var file = picture;
                            var uploadFile = Path.Combine(_hostingEnvironment.WebRootPath, "images", picture);

                            using (MemoryStream ms = new MemoryStream())
                            {
                                Image[i].CopyTo(ms);
                                tourist.Orders[i].Image = ms.GetBuffer();
                            }
                        }
                    }
                    _context.Tourists.Add(tourist);
                    _context.SaveChanges();
                    TempData["id"] = tourist.Id;
                    return RedirectToAction("Index");
                }

                return View(tourist);
            }
            catch (Exception)
            {
                return View(tourist);
            }
        }

       
        public IActionResult Delete(long id)
        {
            Tourist tourist = _context.Tourists.Find(id);
            if (tourist != null)
            {
                _context.Tourists.Remove(tourist);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteItem(long id)
        {
            Order order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");
        }
    }
}