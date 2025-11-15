using System;
using System.Collections.Generic;

namespace Visit.Shared
{
    public class DoctorDto
    {
        public int DoctorID { get; set; }
        public string FullName { get; set; }
        public List<TakhasosInfo> Takhasos { get; set; }
        public string Picture {  get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        ///
    }
}