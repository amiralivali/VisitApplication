using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visit.Shared
{
    public class VisitInfo
    {
        public int ID { get; set; }
        public int BimarID { get; set; }
        public int DoctorID { get; set; }
        public TimeSpan Time { get; set; }
        public DateTime Date { get; set; }
    }
}
