using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Details
{
    public class Port
    {
        public string name { get; set; }
        public bool hidden { get; set; }
        public string color { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public string pn { get; set; }
        public float nx { get; set; }
        public float ny { get; set; }
        public string src { get; set; }
        public string dest { get; set; }
        public List<Arc> arcs { get; set; }
    }
}
