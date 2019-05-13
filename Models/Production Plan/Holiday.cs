using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Production_Plan
{
    public class Holiday
    {
        public long begin { get; set; }
        public long end { get; set; }
        public long behaviorOnTerminate { get; set; }
        public int periodicity { get; set; }
    }
}
