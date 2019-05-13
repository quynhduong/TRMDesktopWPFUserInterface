using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDesktopUserI.Library.Models.Results;

namespace TRMDesktopUserI.Library.Models.Details.Results
{
    public class ReactorResult
    {
        //Return code of simulation (0: success)
        public int code { get; set; }

        //Simulation process time.
        public int processTime { get; set; }

        //Text data for log
        public string data { get; set; }

        //Total production number
        public int production { get; set; }

        //Average operation rate of all stations
        public decimal stationOpRate { get; set; }

        //Average operation rate of all workers
        public int workerOpRate { get; set; }

        //Rendering time(min)
        public int rendertime { get; set; }

        //Total inventory
        public decimal inventory { get; set; }

        //Production time(min)
        public int worktime { get; set; }

        public List<string> flowdata { get; set; }

        public List<string> partsdata { get; set; }

        //Start and finish time of each lot(in planning order
        public  List<List<decimal>> startFinishTimes { get; set; }

        public List<WorkerPosition> workerPositions { get; set; }

        public ReactorStatisticalResult statisticalResult { get; set; }

        public  ReactorCostResult costResult { get; set; }
    }
}
