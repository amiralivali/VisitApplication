using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Visit.Shared
{
    public class NationalCodeValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string nc = value.ToString();
            if (string.IsNullOrEmpty(nc))
            {
                return new ValidationResult(string.Format(Messages.Required, Messages.NationalCode));
            }
            bool isDigit = nc.IsDigit();
            if (isDigit)
            {
                if (nc.Length == 10)
                {
                    char[] chArray = nc.ToCharArray();
                    int[] numArray = new int[chArray.Length];
                    for (int i = 0; i < chArray.Length; i++)
                    {
                        numArray[i] = (int)char.GetNumericValue(chArray[i]);
                    }
                    int num2 = numArray[9];
                    switch (nc)
                    {
                        case "0000000000":
                        case "1111111111":
                        case "2222222222":
                        case "3333333333":
                        case "4444444444":
                        case "5555555555":
                        case "6666666666":
                        case "7777777777":
                        case "8888888888":
                        case "9999999999":
                            return new ValidationResult(string.Format(Messages.FalseValidation,Messages.NationalCode));
                    }
                    int num3 = ((((((((numArray[0] * 10) + (numArray[1] * 9)) + (numArray[2] * 8)) + (numArray[3] * 7)) + (numArray[4] * 6)) + (numArray[5] * 5)) + (numArray[6] * 4)) + (numArray[7] * 3)) + (numArray[8] * 2);
                    int num4 = num3 - ((num3 / 11) * 11);
                    if ((((num4 == 0) && (num2 == num4)) || ((num4 == 1) && (num2 == 1))) || ((num4 > 1) && (num2 == Math.Abs((int)(num4 - 11)))))
                    {
                        return ValidationResult.Success;
                    }
                    else
                    {
                        return new ValidationResult(string.Format(Messages.FalseValidation, Messages.NationalCode));
                    }
                }
            } 
            return new ValidationResult(string.Format(Messages.FalseValidation, Messages.NationalCode));
        }
    }
}
