using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreProject_Sayed.Data;
using DotNetCoreProject_Sayed.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static DotNetCoreProject_Sayed.Helper;

namespace DotNetCoreProject_Sayed.Controllers
{
    public class RoomController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rooms.ToListAsync());
        }
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Room());
            else
            {
                var RoomModel = await _context.Rooms.FindAsync(id);
                if (RoomModel == null)
                {
                    return NotFound();
                }
                return View(RoomModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("RoomId,RoomNumber,AreaName,HotelName,SecurityCode,Cost,BookingDate")] Room RoomModel)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                   // RoomModel.BookingDate = DateTime.Now;
                    _context.Add(RoomModel);
                    await _context.SaveChangesAsync();

                }
                else
                {
                    try
                    {
                        _context.Update(RoomModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!RoomModelExists(RoomModel.RoomId))
                        { return NotFound(); }
                        else
                        { throw; }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Rooms.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", RoomModel) });
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var RoomModel = await _context.Rooms
                .FirstOrDefaultAsync(m => m.RoomId == id);
            if (RoomModel == null)
            {
                return NotFound();
            }

            return View(RoomModel);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var RoomModel = await _context.Rooms.FindAsync(id);
            _context.Rooms.Remove(RoomModel);
            await _context.SaveChangesAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Rooms.ToList()) });
        }

        private bool RoomModelExists(int id)
        {
            return _context.Rooms.Any(e => e.RoomId == id);
        }
    }
}
