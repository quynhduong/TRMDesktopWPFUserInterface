using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Production_Plan
{
    public class ProductionOrders
    {
        //"product" in "iniplans" class
        public string productid { get; set; }

        //"lotisize" in "iniplans" class
        public int lotsize { get; set; }

        //public long daytime { get; set; }
        //public string process { get; set; }
       // public string station { get; set; }

        //"islot" in "iniplans" class
        public bool aslot { get; set; }
    }
}
