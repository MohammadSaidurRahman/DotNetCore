using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreProject_Sayed.Models
{
    [Table("Tourist")]
    public class Tourist
    {
        [Key]
        public long Id { get; set; }

        [Required, Display(Name = "Tourist")]
        public string Name { get; set; }

        public virtual IList<Order> Orders { get; set; }
    }
}
