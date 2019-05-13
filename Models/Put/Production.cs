using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Put
{
    public class Production
    {
       // public int link { get; set; }

        public List<Goal> production_goals { get; set; }

        public List<Order> production_orders { get; set; }
    }
}
