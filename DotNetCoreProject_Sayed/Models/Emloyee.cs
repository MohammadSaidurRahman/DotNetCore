namespace DotNetCoreProject_Sayed.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class Emloyee
    {
        public int EmloyeeID { get; set; }

        [Required(ErrorMessage = "This Field is Required!")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "You Must be Give Minimum 2 and Maximum 30 Chrecter")]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This Field is Required!")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field must be requird")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "This Field is Required!")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Your Mobile Number Must be 11 Digit!")]
        [Display(Name = "Phone Number")]
        public string ContactNo { get; set; }

        //public string ImagePath { get; set; }
        //[NotMapped]
        ////public HttpPostedFileBase ImageUpload { get; set; }
        ////public Emloyee()
        ////{
        ////    ImagePath = "~/AppFiles/Images/Upload.png";
        ////}
    }
}
