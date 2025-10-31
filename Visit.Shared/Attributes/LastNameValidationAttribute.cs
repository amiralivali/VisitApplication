using System.ComponentModel.DataAnnotations;

namespace Visit.Shared.Attributes
{
    public class LastNameValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string lastName = value.ToString();
            if (string.IsNullOrEmpty(lastName))
            {
                return new ValidationResult(string.Format(Messages.Required, Messages.LastName));
            }
            if (lastName.Length >= 2 && lastName.Length <= 20)
            {
                bool isParsian = lastName.IsPersian();
                bool isEnglish = lastName.IsEnglish();
                if (isParsian)
                {
                    return ValidationResult.Success;
                }
                else if (isEnglish)
                {
                    return new ValidationResult(string.Format(Messages.WrongLanguage, Messages.LastName));
                }
            }
            return new ValidationResult(string.Format(Messages.FalseValidation, Messages.LastName));
        }
    }
}
