using System.ComponentModel.DataAnnotations;

namespace AW_MVC_uppgift_3.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "Fist name")]
        [Required(ErrorMessage = " is required")]
        public string Name { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = " is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
