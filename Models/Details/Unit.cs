using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Details
{
    public class Unit
    {
        public string name { get; set; }
        public string target { get; set; }
        public List<Property> properties { get; set; }
        public List<Table> tables { get; set; }

    }
}
