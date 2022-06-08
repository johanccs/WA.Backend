using System;
using System.Collections.Generic;
using System.Linq;
using WA.Data.Dtos;
using WA.Data.Entities;

namespace WA.Data.Helpers
{
    public static class ProjectEmployeeMapping
    {
        private static int id;
        private static string projectName;
        private static decimal cost;
        private static DateTime? startDate;
        private static DateTime? endDate;
        private static string empNames;

        public static IEnumerable<ProjectEmployeeDto> Map(List<ProjectEmployeeEntity> unmapped)
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
                        cost = p.Project.Cost;
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

        private static void ClearFields()
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
