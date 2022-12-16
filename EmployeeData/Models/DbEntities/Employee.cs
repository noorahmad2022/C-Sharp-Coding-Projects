using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeData.Models.DbEntities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string firstName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string lastName { get; set; }

        [Required]
        [DisplayName("Date of Birth")]
        public DateTime dateOfBirth { get; set; }

        public Status Status { get; set; }

        [Required]
        [DisplayName("E-Mail Address")]
        public string Email { get; set; }
        
        [DisplayName("Phone Number")]
        public string contactNumber { get; set; }
        public double Salary { get; set; }

        //we use Fullname just for display purpose, to display in the View and not pass any data
        [DisplayName("Full Name")]
        public string FullName { 
            get {return lastName +", " + firstName; }
                }
    }

    public enum Status
    {
        Male,
        Female,
        Transgender,
        Other
    }
}
