using DotNetCoreProject_Sayed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreProject_Sayed.Interface
{
  public  interface IBookingRepository
    {
        Booking GetBooking(int id);

        IEnumerable<Booking> GetAll();

        Booking Add(Booking booking);
        Booking Update(Booking booking);
        Booking Delete(int id);
    }
}
