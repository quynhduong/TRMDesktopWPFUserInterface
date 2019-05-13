using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopWPFUI.Models
{
    public class AuthenticatedUser
    {
        public string Access_Token { get; set; }

        [Required(ErrorMessage = "This field is required!!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="This field is required!!")]
        [DisplayName("User Name:")]
        public string UserName { get; set; }
        
        public string LoginErrorMessage { get; set; }
    }
}
