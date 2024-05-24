using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EmployeeCrud.Dto
{
    public class EmployeeDto
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string? Firstname { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string? Lastname { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Deparment is required")]
        public string? Deparment { get; set; }
    }
}
