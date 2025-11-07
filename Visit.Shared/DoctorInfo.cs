using System;
using Visit.Shared.Attributes;

namespace Visit.Shared
{
    public class DoctorInfo : UserInfo
    {
        public int DoctorID { get; set; }
        [NezamValidation]
        public string CodeNezamPezeshki { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
