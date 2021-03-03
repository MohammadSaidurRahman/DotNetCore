using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreProject_Sayed.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public long Id { get; set; }

        [Required, Display(Name = "Food Name")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [DataType(DataType.Date)]

        public DateTime BuyingDate { get; set; }

        [Required]
        public long Quantity { get; set; }

        [ForeignKey("Tourist")]
        public long TouristID { get; set; }


        public virtual Tourist Category { get; set; }
    }
}
