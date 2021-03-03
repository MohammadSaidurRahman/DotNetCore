using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreProject_Sayed.Models
{
    

    public partial class Stuff
    {
        public int StuffID { get; set; }       
        public string StuffName { get; set; }       
        public int Age { get; set; }        
        public string State { get; set; }        
        public string Country { get; set; }
    }
}
