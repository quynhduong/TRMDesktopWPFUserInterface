using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Production_Plan
{
    public class ProductionGoals
    {
        // "product" in "goals" class
        public string productid { get; set; }

        //"production" in "goals" class
        public int target { get; set; }
        public string product { get; set; }

        //"completed" in "goals" class
        public int production { get; set; }

        //"rush" in "goals" class
        public bool rush { get; set; }
    }
}
