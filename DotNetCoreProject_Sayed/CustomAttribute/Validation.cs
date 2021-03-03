using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace DotNetCoreProject_Sayed.CustomAttribute
{
    public class Validation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string message = value.ToString();
                if (message.Contains("AC"))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Must be field AC or Non AC");
        }
    }
}
