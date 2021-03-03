using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace DotNetCoreProject_Sayed.CustomAttribute
{
    public class CustomDate : ValidationAttribute
    {

        public CustomDate() : base("{0} should less than current date")
        {

        }
        public override bool IsValid(object value)
        {
            DateTime propValue = Convert.ToDateTime(value);
            if (propValue <= DateTime.Now)
                return true;
            else
                return false;
        }
    }
}
