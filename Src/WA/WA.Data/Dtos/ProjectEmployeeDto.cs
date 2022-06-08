using System;

namespace WA.Data.Dtos
{
    public class ProjectEmployeeDto
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Employees { get; set; }
        public decimal Cost { get; set; }

    }
}
