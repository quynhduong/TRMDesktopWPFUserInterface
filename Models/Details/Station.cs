using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Details
{
    public class Station
    {
        public string name { get; set; }
        public bool hidden { get; set; }
        public string color { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public int parallel { get; set; }
        public float h { get; set; }
        public float v { get; set; }
        public string desc { get; set; }
        public string workingHourGroup { get; set; }
        public int totalBufferSize { get; set; }
        public int inputBufferSize { get; set; }
        public int outputBufferSize { get; set; }
        public List<Port> port { get; set; }
        public List<Hyperlink> hyperlinks { get; set; }
    }
}
