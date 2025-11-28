namespace Visit.DAL
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Chat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }

        public int FromID { get; set; }

        public int ToID { get; set; }
        [MaxLength(1000)]
        [Required]
        public string Text { get; set; }

        public DateTime DateTime { get; set; }

        public bool IsRead { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
