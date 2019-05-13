using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Details
{
    public class WorkerPosition
    {
        public string workerid { get; set; }
        public List<List<decimal>> timePositions { get; set; }
    }
}
