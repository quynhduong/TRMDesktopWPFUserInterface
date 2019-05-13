using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Production_Plan
{
    public class Calendar
    {
        public int link { get; set; }
        public string name { get; set; }
        public List<Holiday> holidays { get; set; }
    }
}
