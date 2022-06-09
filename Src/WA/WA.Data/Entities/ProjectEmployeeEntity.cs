using WA.Data.Base;

namespace WA.Data.Entities
{
    public class ProjectEmployeeEntity: BaseEntity
    {
        public int ProjectID { get; set; }

        public int EmployeeID { get; set; }

        public virtual EmployeeEntity Employee { get; set; }

        public virtual ProjectEntity Project {get;set;}
    }
}
