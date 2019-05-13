using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TRMDesktopUserI.Library.Models;
using TRMDesktopWPFUI.Library.Api;
using TRMDesktopWPFUI.Models;
using System.Web;
using Newtonsoft.Json.Converters;
//using static TRMDesktopUserI.Library.Production.ProductionInfo;
//using TRMDesktopUserI.Library.Models.Production;

namespace TRMDesktopWPFUI.Library.Api
{
    public class APIHelper : IAPIHelper
    {
        public HttpClient apiClient;
        public ILoggedInUserModel _loggedInUser;

       

        public APIHelper(ILoggedInUserModel loggedInUser)
        
        {
            InitializeClient();
            _loggedInUser = loggedInUser;
        }

        public void InitializeClient()
        {
            string api = ConfigurationManager.AppSettings["api"];

            apiClient = new HttpClient();
            apiClient.BaseAddress = new Uri(api);
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

   

        public async Task<AuthenticatedUser> Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
            });

            using (HttpResponseMessage response = await apiClient.PostAsync("token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AuthenticatedUser>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task GetLoggedInUserInfo(string token)
        {
            apiClient.DefaultRequestHeaders.Clear();
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            //Get Project lists
            using (HttpResponseMessage response = await apiClient.GetAsync("v1/Projects"))
            {
              
                if (response.IsSuccessStatusCode)
                {
                    //var data = await response.Content.ReadAsAsync<List<LoggedInUserModel>>();
                    var data = 2;
                    var result = JsonConvert.SerializeObject(data);
                    var Projectinfo = JsonConvert.DeserializeObject(result);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                    
                }
            }

            //Get Production Info
            using (HttpResponseMessage response = await apiClient.GetAsync("v1/Projects/25066/parameters"))
            {

                if (response.IsSuccessStatusCode)
                {

                    var ProductionInfo = await response.Content.ReadAsAsync<ProjectDetail>();
                    var result_production = JsonConvert.SerializeObject(ProductionInfo);
                    var Projectinfo = JsonConvert.DeserializeObject(result_production);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);

                }
            }
            //Get Project Details
            using (HttpResponseMessage response = await apiClient.GetAsync("v1/Projects/35826?target[0]=1&target[1]=2&target[2]=7"))
            {

                if (response.IsSuccessStatusCode)
                {
                    var values = new Dictionary<string, string> { { "target[0]", "1" }, { "target[1]", "2" },{ "target[3]", "3" } };
                    //var ProjectDetail = await response.Content.ReadAsAsync<ProjectDetail>();
                    //var project_detail_jsonconverted = JsonConvert.SerializeObject(ProjectDetail);
                   // var Project_details = JsonConvert.DeserializeObject(project_detail_jsonconverted);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);

                }
            }
        }
    }
}
