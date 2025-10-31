using System.ComponentModel.DataAnnotations;

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
            bool isDigit = codeNezamPezeshki.IsDigit();
            if (isDigit)
            {
                if (codeNezamPezeshki.Length == 5)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(string.Format(Messages.FalseValidation, Messages.Nezam));
        }
    }
}
