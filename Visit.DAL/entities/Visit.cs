namespace Visit.DAL
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Visit
    {
        public int ID { get; set; }

        public int DoctorID { get; set; }

        public int BimarID { get; set; }

        public DateTime DateTime { get; set; }

        public virtual Bimar Bimar { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
