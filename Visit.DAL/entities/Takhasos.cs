namespace Visit.DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Takhasos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public virtual ICollection<Doctor_Takhasos> Doctor_Takhasoses { get; set; }
    }
}
