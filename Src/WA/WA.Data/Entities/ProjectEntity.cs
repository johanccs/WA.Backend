using System;
using System.ComponentModel.DataAnnotations.Schema;
using WA.Data.Base;

namespace WA.Data.Entities
{
    public class ProjectEntity: BaseEntity
    {
        public string Name { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime? Enddate { get; set; }

        [Column(TypeName = "decimal(18,4")]
        public decimal Cost { get; set; }

    }
}
