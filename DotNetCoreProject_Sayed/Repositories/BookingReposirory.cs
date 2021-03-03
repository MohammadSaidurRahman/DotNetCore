using DotNetCoreProject_Sayed.Data;
using DotNetCoreProject_Sayed.Interface;
using DotNetCoreProject_Sayed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreProject_Sayed.Repositories
{
    public class BookingReposirory: IBookingRepository
    {
        private readonly ApplicationDbContext db;
        public BookingReposirory(ApplicationDbContext db)
        {
            this.db = db;
        }

        public Booking Add(Booking booking)
        {
            db.Bookings.Add(booking);
            db.SaveChanges();

            return booking;
        }

        public Booking Delete(int id)
        {
            Booking booking = db.Bookings.Find(id);
            if (booking != null)
            {
                db.Bookings.Remove(booking);
                db.SaveChanges();
            }
            return booking;
        }

        public IEnumerable<Booking> GetAll()
        {
            return db.Bookings;
        }

        public Booking GetBooking(int id)
        {
            return db.Bookings.Where(x => x.BookingId == id).SingleOrDefault();
        }

        public Booking Update(Booking booking)
        {
            db.Entry(booking).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return booking;
        }
    }
}
