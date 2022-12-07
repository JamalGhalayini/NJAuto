using System.ComponentModel.DataAnnotations;

namespace NJAuto.Shared.Models
{
    public class CreateEmployee : RegisterUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
