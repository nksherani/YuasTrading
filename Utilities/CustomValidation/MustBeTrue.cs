using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.CustomValidation
{
    public class MustBeTrue : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if (Convert.ToBoolean( value))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(validationContext.DisplayName + " must be true");
                }
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
