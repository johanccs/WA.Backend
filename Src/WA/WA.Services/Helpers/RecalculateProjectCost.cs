using WA.Contracts;
using WA.Data.Entities;
using WA.Services.Helpers.CostCalculation;

namespace WA.Services.Helpers
{
    public class RecalculateProjectCost : IRecalcProjectCost<EmployeeEntity>
    {
        public decimal Calculate(decimal projectCost, EmployeeEntity employeeEntity)
        {
            var jobTitleId = employeeEntity.JobTitleId;
            var costType = ProjectCosts.GetCostByJobTitle(jobTitleId);

            return projectCost + costType.Cost;
        }
    }
}
