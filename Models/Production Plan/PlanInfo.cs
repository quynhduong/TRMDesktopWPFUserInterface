using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Production_Plan
{
    public class PlanInfo
    {
        public string product { get; set; }
        public int lotsize { get; set; }
        public string line { get; set; }
        public long daytime { get; set; }
        public string processid { get; set; }
        public string stationid { get; set; }
        public bool islot { get; set; }
    }
}
