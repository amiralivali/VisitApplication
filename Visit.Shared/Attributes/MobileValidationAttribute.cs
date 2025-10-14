using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit.Shared
{
    internal class MobileValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string num = value.ToString();
            if (string.IsNullOrEmpty(num))
            {
                return new ValidationResult(string.Format(Messages.Required, Messages.Mobile));
            }
            bool isDigit = num.IsDigit();
            if (isDigit)
            {
                 if (num.Length == 11)
                 {
                     if (num.StartsWith("09"))
                         return ValidationResult.Success;
                 }
                 else if (num.Length == 10)
                 {
                     if (num.StartsWith("9"))
                         return ValidationResult.Success;
                 }
            }
            return new ValidationResult(string.Format(Messages.FalseValidation, Messages.Mobile));
        }
       
    }
}
