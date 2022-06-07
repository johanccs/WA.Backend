using System;

namespace WA.Data.Dtos
{
    public class NewEmployeeDto
    {
        public string Name { get; set; }

        public string Surname { get; set; }
      
        public int JobTitleId { get; set; }
     
        public DateTime DateOfBirth { get; set; }
    }
}
