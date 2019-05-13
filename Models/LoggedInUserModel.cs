using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Web.Http;

namespace TRMDesktopUserI.Library.Models
{
  
    public class  LoggedInUserModel : ILoggedInUserModel
    {
     
        public int ID { get; set; }

      
        public string name { get; set; }

        // public string desc { get; set; }


        //  public int access { get; set; }


        //public long updated { get; set; }

        //    public string version { get; set; }


        //    public string owner { get; set; }


        //   public string Token { get; set; }
        //

        public bool IsChecked { get; set; }
    }
    

    public class ProjectModel
    {
        
        public List<LoggedInUserModel> Projects { get; set; }
        public bool IsChecked { get; set; }

    }
    


}


