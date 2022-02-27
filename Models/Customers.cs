using System.ComponentModel.DataAnnotations;
namespace GBC_WebDevelopers.Models
{
    public class Customers
    {
        public int Id { get; set; }

        [StringLength(20, ErrorMessage = "Your First Name can contain only 20 characters")]
        [Display(Name = "First Name")]
        public string? Firstname { get; set; }

        [StringLength(20, ErrorMessage = "Your Last Name can contain only 20 characters")]
        [Display(Name = "Last Name")]
        public string? Lastname { get; set; }

        
        public string? Address { get; set; }

      
        public string? City { get; set; }
       
        public string? State { get; set; }

       
        [Display(Name = "Postal Code")]
        public string? PostalCode { get; set; }

        
        public string? Country { get; set; }
        public string? Email { get; set; }

        public string? Phone { get; set; }
    }
}
