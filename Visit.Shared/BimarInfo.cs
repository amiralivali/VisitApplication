using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Visit.Shared.Attributes;

namespace Visit.Shared
{
    public class BimarInfo : UserInfo
    {
        public int BimarID { get; set; }
        [NationalCodeValidation]
        public string NationalCode { get; set; }
    }
}
