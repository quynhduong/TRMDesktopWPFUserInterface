using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Details
{
    public class Agent
    {
        public string id { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public int icon { get; set; }
        public string operationArea { get; set; }
        public List<Property> properties { get; set; }
        public List<Table> table { get; set; }
        public List<Unit> units { get; set; }
    }
}
