using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Details
{
    public class Product
    {
        public string name { get; set; }
        public List<Process> processes { get; set; }
        public List<Product> product { get; set; }
    }
}
