using System.Threading.Tasks;
using TRMDesktopWPFUI.Models;

namespace TRMDesktopWPFUI.Library.Api
{
    public interface IAPIHelper
    {
        Task <AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}