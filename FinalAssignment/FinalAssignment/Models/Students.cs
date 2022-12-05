using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalAssignment.Models
{
    public class Students
    {
        [Key]   //I want to be my student ID has the Primary Key
        [DisplayName("Student ID")] // change Colunm display name
        public int studentID { get; set; }


        [Required(ErrorMessage = "First Name Required")]
        [DisplayName("First Name")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        [DisplayName("Last Name")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Final Score Required")]
        [DisplayName("Final Score")]
        public decimal finalScore { get; set; }
        public string Note { get; set; }
    }

    public class EFCodeFirtsEntieis : DbContext
    {
        public DbSet<Students> Students { get; set; }    // calling student class here

        // Go to Web.Config file and change the server name.
    }
}