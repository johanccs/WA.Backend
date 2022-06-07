namespace WA.Data.Entities
{
    public class ProjectEmployeeEntity
    {
        public int id { get; set; }

        public int ProjectID { get; set; }

        public int EmployeeID { get; set; }

        public virtual EmployeeEntity Employee { get; set; }

        public virtual ProjectEntity Project {get;set;}
    }
}
