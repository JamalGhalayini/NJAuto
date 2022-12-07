using System.ComponentModel.DataAnnotations;


namespace NJAuto.Shared.Models
{
    public class Employee : RegisterUser
    { 
        [Required]
        public int EmployeeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
