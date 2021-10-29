using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment1
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(40)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(40)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Mobile Number")]
        [MaxLength(15)]
        public string MobileNumber { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [MaxLength(200)]
        public string Email { get; set; }
        [Required]
        [Display(Name = "City of Residence")]
        [MaxLength(25)]
        public string City { get; set; }
        [Required]
        [MaxLength(25)]
        public string Specialization { get; set; }
    }
}