namespace Visit.DAL
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(11)]
        public string MobileNumber { get; set; }
        public string Picture { get; set; }
        public virtual Bimar Bimar { get; set; }

        public virtual ICollection<Chat> Chats { get; set; }

        public virtual ICollection<Chat> Chats1 { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
