namespace Visit.DAL
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Doctor_Takhasos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }

        public int DoctorID { get; set; }

        public byte TakhasosID { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual Takhasos Takhasos { get; set; }
    }
}
