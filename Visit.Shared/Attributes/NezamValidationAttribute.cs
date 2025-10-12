using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit.Shared.Attributes
{
    public class NezamValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string codeNezamPezeshki = value.ToString();
            if (string.IsNullOrEmpty(codeNezamPezeshki))
            {
                return new ValidationResult(string.Format(Messages.Required, Messages.Nezam));
            }
            if (codeNezamPezeshki.Length == 5)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(string.Format(Messages.FalseValidation, Messages.Nezam));
            }
        }
    }
}
