using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit.Shared
{
    public class BaseValidation
    {
        public bool IsValid
        {
            get
            {
                var vc = new ValidationContext(this);
                var result = new List<ValidationResult>();
                var check = Validator.TryValidateObject(this, vc, result, true);
                return check;
            }
        }
        public string Message
        {
            get
            {
                var vc = new ValidationContext(this);
                var result = new List<ValidationResult>();
                var check = Validator.TryValidateObject(this, vc, result, true);
                if (check)
                {
                    return string.Empty;
                }
                else
                {
                    string message = string.Join(Environment.NewLine, result.Select(x => x.ErrorMessage));
                    return message;
                }
            }
        }
    }
}
