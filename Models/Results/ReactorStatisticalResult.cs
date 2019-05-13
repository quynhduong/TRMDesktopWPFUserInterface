using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUserI.Library.Models.Results
{
    public class ReactorStatisticalResult
    {
        public string project { get; set; }
        public List<string> products { get; set; }
        public List<string> stations { get; set; }
        public List<string> process { get; set; }
        public List<string> timeCourseOfProduction { get; set; }
        public List<string> inventoryQuantity { get; set; }
        public List<string> rateOfWorkerOperation { get; set; }
        public List<string> rateOfStationOperation { get; set; }
        public List<string> workLoadChartOfWorker { get; set; }
        public List<string> workLoadChartOfStation { get; set; }
    }
}
