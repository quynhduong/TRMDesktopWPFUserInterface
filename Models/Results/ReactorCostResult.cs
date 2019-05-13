using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Results
{
    public class ReactorCostResult
    {
        public string project { get; set; }
        public string simulationPeriod { get; set; }
        public List<string> processInformation { get; set; }
        public List<string> indirectOperationAverageTime { get; set; }
    }
}
