using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visit.Shared.Attributes;

namespace Visit.Shared
{
    public class UserInfo : BaseValidation
    {
        [FirstNameValidation]
        public string FirstName { get; set; }
        [LastNameValidation]
        public string LastName { get; set; }
        [MobileValidation]
        public string MobileNumber { get; set; }
        public byte[] Picture { get; set; }
    }
}
