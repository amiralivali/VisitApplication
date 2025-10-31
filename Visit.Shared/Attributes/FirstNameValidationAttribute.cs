using System.ComponentModel.DataAnnotations;

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
                bool isParsian = firstName.IsPersian();
                bool isEnglish=firstName.IsEnglish();
                if (isParsian)
                {
                    return ValidationResult.Success;
                }
                else if (isEnglish)
                {
                    return new ValidationResult(string.Format(Messages.WrongLanguage, Messages.FirstName));
                }
            }
            return new ValidationResult(string.Format(Messages.FalseValidation, Messages.FirstName));
        }
    }
}
