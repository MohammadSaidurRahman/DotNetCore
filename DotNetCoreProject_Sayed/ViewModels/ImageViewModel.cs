using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreProject_Sayed.ViewModels
{
    public class ImageViewModel
    {
        [Required]
        [Display(Name = "Image")]
        public IFormFile Image { get; set; }
    }
}
