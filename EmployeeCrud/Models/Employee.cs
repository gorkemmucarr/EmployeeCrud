using System.ComponentModel.DataAnnotations;

namespace EmployeeCrud.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="First name is required")]
        [Display(Name ="First Name")]
        public string? Firstname { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        [Display(Name = "Last Name")]
        public string? Lastname { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Deparment is required")]
        public string? Deparment { get; set; }

    }
}
