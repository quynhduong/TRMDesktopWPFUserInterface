using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Production_Plan
{
    public class MiningParams
    {
        public List<GoalInfo> goals { get; set; }
        public List<PlanInfo> iniplans { get; set; }
        public PatternCondition patternCondition { get; set; }
    }
}
