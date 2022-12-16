using Microsoft.AspNetCore.Mvc;

namespace EmployeeData.Models
{
    public class onPost
    {
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
    }
}
