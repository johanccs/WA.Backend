using System;
using System.Collections.Generic;
using System.Linq;
using WA.Contracts;
using WA.Data.Dtos;
using WA.Data.Entities;

namespace WA.Data.Helpers
{
    public class ProjectEmployeeMapping: IProjectEmployeeMapping
    {
        #region Readonly Fields

        private readonly IRecalcProjectCost<EmployeeEntity> _recalcProjectCost;

        #endregion

        #region Fields

        private int id;
        private string projectName;
        private decimal cost;
        private DateTime? startDate;
        private DateTime? endDate;
        private string empNames;

        #endregion

        public ProjectEmployeeMapping(IRecalcProjectCost<EmployeeEntity> recalcProjectCost)
        {
            _recalcProjectCost = recalcProjectCost;
        }

        public List<ProjectEmployeeDto> Map(List<ProjectEmployeeEntity> unmapped)
        {
            var mappedProjectEmployees = new List<ProjectEmployeeDto>();
            var groupedProjects = unmapped.GroupBy(x => x.ProjectID).ToList();

            foreach (var project in groupedProjects)
            { 
                if(project.Count() > 1)
                {
                    foreach(var p in project)
                    {
                        id = p.ProjectID;
                        projectName = p.Project.Name;
                        cost = _recalcProjectCost.Calculate(p.Project.Cost, p.Employee);
                        startDate = p.Project.Startdate;
                        endDate = p.Project.Enddate;
                        empNames += (p.Employee.Name + " " + p.Employee.Surname + ", ");
                    }

                    var projectEmp = new ProjectEmployeeDto()
                    {
                        Id = id,
                        Cost = cost,
                        Employees = empNames,
                        EndDate = endDate,
                        StartDate = (DateTime)startDate,
                        ProjectName = projectName
                    };

                    mappedProjectEmployees.Add(projectEmp);
                    projectEmp = null;
                    ClearFields();
                }
            }

            return mappedProjectEmployees;
         
        }

        private void ClearFields()
        {
            id = 0;
            projectName = string.Empty;
            cost = 0;
            startDate =null;
            endDate = null;
            empNames = string.Empty;
        }
    }
}
