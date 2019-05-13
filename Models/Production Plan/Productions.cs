using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Production_Plan
{
    public class Productions
    {
        public List<ProductionGoals> production_goals { get; set; }
        public List<ProductionOrders> production_orders { get; set; }
    }
}
