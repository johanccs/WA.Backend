using System;

namespace WA.Data.Entities
{
    public class ProjectEntity
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public decimal Cost { get; set; }

    }
}
