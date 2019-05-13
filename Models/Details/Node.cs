using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Details
{
    public class Node
    {
        public string name { get; set; }
        public bool hidden { get; set; }
        public string color { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public bool standby { get; set; }
        public List<Arc> arcs { get; set; }
    }
}
