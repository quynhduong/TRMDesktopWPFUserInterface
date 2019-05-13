using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Details
{
    public class Process
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public float worktime { get; set; }
        public float setup { get; set; }
        public string frequency { get; set; }
        public string inputProcess { get; set; }
        public string outputProcess { get; set; }
        public Input input { get; set; }
        public List<Output> output { get; set; }
        public List<Hyperlink> hyperlinks { get; set; }
        public bool disabled { get; set; }
        public List<Tag> tags { get; set; }
    }
}
