using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Details
{
    public class ProductionProcess
    {
        public int id { get; set; }
        public int componentId { get; set; }
        public List<Product> products { get; set; }
        public List<Process> processes { get; set; }
        public int visibility { get; set; }
        public long updated { get; set; }
    }
}
