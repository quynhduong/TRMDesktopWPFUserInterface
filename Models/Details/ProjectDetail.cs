using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDesktopUserI.Library.Models.Details;
using static TRMDesktopUserI.Library.Models.ProjectDetail;

namespace TRMDesktopUserI.Library.Models
{
    public class ProjectDetail
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public int access { get; set; }
        public long updated { get; set; }
        public string version { get; set; }
        public string owner { get; set; }
        public float worktime { get; set; }
        public List<ProductionProcess> productionProcess { get; set; }
        public List<Material> Material { get; set; }
        public List<Layout> layouts { get; set; }
        // public productionProcess productionProcess { get; set;}
        //   public List<productionProcess> productionProcesses{ get; set; }
        //   public layouts layouts { get; set; }
        //public List<stations> stations { get; set; }

    }//end project Detail

}




