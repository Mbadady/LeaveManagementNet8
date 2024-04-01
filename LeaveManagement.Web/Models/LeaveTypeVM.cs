using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {

        public int Id { get; set; }

        [DisplayName("Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Default number of days")]
        [Required]
        [Range(1, 25)]
        public int DefaultDays { get; set; }


    }
}
