using DotNetCoreProject_Sayed.CustomAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DotNetCoreProject_Sayed.Models
{


    public partial class Booking
    {
        public int BookingId { get; set; }
       // [CustomHireDate(ErrorMessage = "Hire Date must be less than or equal to Today's Date")]
        //[DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]

            [CustomDate]
        public DateTime BookingDate { get; set; }
        public int RoomNo { get; set; }
       
       [Validation]
        public string RoomType { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
