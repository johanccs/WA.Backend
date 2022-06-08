using System.Collections.Generic;
using System.Linq;

namespace WA.Services.Helpers.CostCalculation
{
    public static class ProjectCosts
    {
        private static List<CostType> _costTypes;

        static ProjectCosts()
        {
            _costTypes = new List<CostType>()
            {
                new CostType{JobItem = 1, Name = "Developer",  Cost = 2500 },
                new CostType{JobItem = 2, Name = "DBA", Cost = 3000 },
                new CostType{JobItem = 3, Name = "Tester", Cost = 1000 },
                new CostType{JobItem = 4, Name = "Business Analyst", Cost = 4500 }
            };
        }

        public static CostType GetCostByJobTitle(int id)
        {
            return _costTypes.FirstOrDefault(x => x.JobItem == id);
        }
    }
}
