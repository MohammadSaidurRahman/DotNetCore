using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreProject_Sayed.ViewModels
{
    public class EditImageViewModel: ImageViewModel
    {
        public int Id { get; set; }
        public string ExistingImage { get; set; }
    }
}
