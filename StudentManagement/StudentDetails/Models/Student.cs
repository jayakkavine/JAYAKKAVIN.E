using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDetails.Models
{
    public class Student
    {
        [Key]
        [Required, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Roll_No { get; set; }
        [Required]
        public string? Student_name { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public long Phone { get; set; }




    }
}
