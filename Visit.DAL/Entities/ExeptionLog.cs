namespace Visit.DAL
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ExceptionLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")] 
        public string Message { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } 

        [Column(TypeName = "nvarchar(max)")] // مسیر خطا
        public string StackTrace { get; set; }

        [StringLength(200)]
        public string ExceptionType { get; set; } // SqlExeption نوع خطا مثل

        [StringLength(200)]
        public string Source { get; set; } // منبع خطا مثلاً کلاس یا لایه
    }
}
