using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBC_WebDevelopers.Models
{
    public class Incidents
    {
        public int Id { get; set; }

        [Required]
        public string? Customer { get; set; }

        [Required]
        public string? Product { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "Your Description can contain only 300 characters")]
        public string? Description { get; set; }
        public string? Technician { get; set; }

        [Display(Name = "Date Opened")]
        [DataType(DataType.Date)]
        public DateTime DateOpened { get; set; }


        [Required]
        [Display(Name = "Date Closed")]
        [DataType(DataType.Date)]
        public DateTime DateClosed { get; set; }
    }
}
