namespace Visit.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Doctor
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DoctorID { get; set; }
        [StringLength(5)]
        public required string CodeNezamPezeshki { get; set; }

        public virtual ICollection<Doctor_Takhasos> Doctor_Takhasoses { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
