using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDesktopUserI.Library.Models.Details;

namespace TRMDesktopUserI.Library.Models
{
    public class Output
    {
        public string dest { get; set; }
        public List<Material> materials { get; set; }
    }
}
