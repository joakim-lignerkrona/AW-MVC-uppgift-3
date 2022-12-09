using System.ComponentModel.DataAnnotations;

namespace AW_MVC_uppgift_3.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "Fist name")]

        [Required(ErrorMessage = "Incorrect Username")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress]

        public string Email { get; set; }

    }
}
