namespace Visit.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Bimar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BimarID { get; set; }

        [Required]
        [StringLength(10)]
        public string NationalCode { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
