using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visit.Shared.Attributes;

namespace Visit.Shared
{
    public class DoctorInfo : UserInfo
    {
        public int DoctorID { get; set; }
        [NezamValidation]
        public string CodeNezamPezeshki { get; set; }
    }
}
