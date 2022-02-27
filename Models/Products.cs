using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GBC_WebDevelopers.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }

        [Column(TypeName = "decimal(12, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
    }
}
