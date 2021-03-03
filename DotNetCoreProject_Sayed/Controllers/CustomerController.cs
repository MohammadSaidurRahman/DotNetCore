using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreProject_Sayed.Interface;
using DotNetCoreProject_Sayed.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreProject_Sayed.Controllers
{
    public class CustomerController : Controller
    {

        private ICustomerRepository db;

        public CustomerController(ICustomerRepository db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.GetAll());
        }



        // GET:Create
        [Authorize(Policy = "CreateRolePolicy")]

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer customer)
        {

            db.Add(customer);
            return RedirectToAction("Index");

        }
        [Authorize(Policy = "DeleteRolePolicy")]

        public IActionResult Delete(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }

        [Authorize(Policy = "EditRolePolicy")]

        public IActionResult Edit(int id)
        {
            return View(db.GetCustomer(id));
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            db.Update(customer);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(db.GetCustomer(id));
        }

    }
}