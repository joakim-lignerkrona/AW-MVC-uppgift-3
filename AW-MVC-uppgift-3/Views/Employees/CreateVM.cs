using System.ComponentModel.DataAnnotations;

namespace AW_MVC_uppgift_3.Views.Employees
{
    public class CreateVM
    {
        [Display(Name = "First name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Display(Name = "What is 2+2")]
        [Required(ErrorMessage = "Validate that you are not a robot")]
        [Range(4, 4, ErrorMessage = "01101110 01101111")]
        public int BotCheck { get; set; }

    }
}
