using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreProject_Sayed.Data;
using DotNetCoreProject_Sayed.Interface;
//using DotNetCoreProject_Sayed.Interfaces;
using DotNetCoreProject_Sayed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreProject_Sayed.Controllers
{
    public class BookingController : Controller
    {
        private IBookingRepository db;

        private ICustomerRepository db2;

        private readonly ApplicationDbContext _context;


        public BookingController(IBookingRepository db, ICustomerRepository db2, ApplicationDbContext _context)
        {
            this.db = db;
            this.db2 = db2;

            this._context = _context;
        }
        public IActionResult Index()
        {            
            var applicationDbContext = _context.Customers.ToList();

            return View(db.GetAll());
        }
        
        // GET:Create
        public IActionResult Create()
        {
            ViewBag.CustomerId = db2.GetAll();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Booking booking)
        {
            ViewBag.CustomerId = db2.GetAll();
            db.Add(booking);
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var applicationDbContext = _context.Bookings.ToList();
            ViewBag.CustomerId = db2.GetAll();

            return View(db.GetBooking(id));
        }

        [HttpPost]
        public IActionResult Edit(Booking booking)
        {
            ViewBag.CustomerId = db2.GetAll();
            db.Update(booking);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(db.GetBooking(id));
        }
    }
}