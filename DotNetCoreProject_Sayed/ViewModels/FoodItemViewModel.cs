using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreProject_Sayed.ViewModels
{
    public class FoodItemViewModel: EditImageViewModel
    {
        [Required]

        [Display(Name = "Food Name")]
        public string FoodName { get; set; }

        [Required]

        public string Quality { get; set; }

        [Required]

        public int Quantity { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Purchased Date")]
        public DateTime PurchasesDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Purchased Time")]
        public DateTime PurchasesTime { get; set; }
       
        [Required]

        public string Place { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter confirm password")]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
