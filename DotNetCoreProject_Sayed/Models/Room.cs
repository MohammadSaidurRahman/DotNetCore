using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DotNetCoreProject_Sayed.CustomAttribute;

namespace DotNetCoreProject_Sayed.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Room Number")]
        [Required(ErrorMessage = "Must be filled Room number")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only")]
        public string RoomNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Area Name")]
        [Required(ErrorMessage = "Please input Area name")]
        public string AreaName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Hotel Name")]
        [Required(ErrorMessage = "Please input Hotel name")]
        public string HotelName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("Security Code")]
        [Required(ErrorMessage = "please input your Security code.")]
        [MaxLength(11)]
        public string SecurityCode { get; set; }

        [DisplayName("Cost")]
        [Required(ErrorMessage = "must be filled Cost.")]
        public int Cost { get; set; }
        [CustomDate]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime BookingDate { get; set; }
    }
}
