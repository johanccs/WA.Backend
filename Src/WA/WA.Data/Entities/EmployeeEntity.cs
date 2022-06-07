
using System;
using System.ComponentModel.DataAnnotations;
using WA.Data.CustomValidations;

namespace WA.Data.Entities
{
    public class EmployeeEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field with name {0} is required")]
        [StringLength(15, ErrorMessage = "Invalid name length")]
        [FirstLetterUppercase]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field with surname {0} is required")]
        [FirstLetterUppercase]
        [StringLength(30, ErrorMessage = "Invalid surname length")]
        public string Surname { get; set; }

        [StringLength(80, ErrorMessage = "Invalid job title")]
        [Required(ErrorMessage = "The field with jobtitle is required")]
        public int JobTitleId { get; set; }

        public virtual JobTitleEntity JobTitle { get; set; }

        [StringLength(120, ErrorMessage = "Please enter Date Of Birth")]
        [Required(ErrorMessage = "Please enter Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
