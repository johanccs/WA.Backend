using System;

namespace WA.Data.Dtos
{
    public class NewProjectDto
    {
        public string Name { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public decimal Cost { get; set; }
    }
}
