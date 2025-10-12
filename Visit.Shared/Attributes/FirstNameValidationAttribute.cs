using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit.Shared.Attributes
{
    public class FirstNameValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string firstName = value.ToString();
            if (string.IsNullOrEmpty(firstName))
            { 
                return new ValidationResult(string.Format(Messages.Required, Messages.FirstName));
            }
            if (firstName.Length >= 2 && firstName.Length <= 20)
            {
                foreach (var letter in firstName)
                {
                    if ((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))
                    {
                        return new ValidationResult(string.Format(Messages.WrongLanguage, Messages.FirstName));
                    }
                    else if (!((letter >= 'ا' && letter <= 'ی')||letter==' '))
                    {
                        return new ValidationResult(string.Format(Messages.FalseValidation, Messages.FirstName));
                    }
                }
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(string.Format(Messages.FalseValidation, Messages.FirstName));
            }
        }
    }
}
