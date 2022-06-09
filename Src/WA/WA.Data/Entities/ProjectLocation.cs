using System.ComponentModel.DataAnnotations;

namespace WA.Data.Entities
{
    public class ProjectLocationsEntity
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Invalid Name length")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "Invalid Location length")]
        public string Location { get; set; }
    }
}
