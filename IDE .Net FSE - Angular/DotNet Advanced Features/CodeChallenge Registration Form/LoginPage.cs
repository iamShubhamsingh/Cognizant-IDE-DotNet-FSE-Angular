using System.ComponentModel.DataAnnotations;

namespace ASPNET6_Template.Models
{
    public class LoginPage
    {
        // Implement your code here
        
        [Required(ErrorMessage="Please enter the user name")]
        public string UserName { set; get; }
        
        [Required(ErrorMessage="Please enter the password")]
        [DataType(DataType.Password)]
        public string Password { set; get; }
    }
}