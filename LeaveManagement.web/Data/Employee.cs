using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.web.Data
{
    public class Employee : IdentityUser

    {
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime JoiningDate { get; set; }
        public int TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
