using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Details
{
    public class Layout
    {
        public int id { get; set; }
        public int parentId { get; set; }
        public string moduleName { get; set; }
        public long updated { get; set; }
        public string name { get; set; }
        public string size { get; set; }
        public float cellSize { get; set; }
        public bool selected { get; set; }
        public Background background { get; set; }
        public List<ParentPort> parentPorts { get; set; }
        public List<Module> modules { get; set; }
        public List<Station> stations { get; set; }
        public List<Node> nodes { get; set; }
        public List<Annotation> annotations { get; set; }
        public List<Space> spaces { get; set; }
        public List<Agent> agents { get; set; }

    }
}
