namespace Visit.DAL
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Tbl_Doctor Takhasos")]
    public partial class Doctor_Takhasos
    {
        public int ID { get; set; }

        public int DoctorID { get; set; }

        public byte TakhasosID { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Takhasos Takhasos { get; set; }
    }
}
