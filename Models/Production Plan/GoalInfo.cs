using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Production_Plan
{
    public class GoalInfo
    {
        public string product { get; set; }
        public int production { get; set; }
        public int completed { get; set; }
        public bool rush { get; set; }
    }
}
