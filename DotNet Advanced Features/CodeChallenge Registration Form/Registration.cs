using System.ComponentModel.DataAnnotations;

namespace ASPNET6_Template.Models
{
    public class Registration
    {
        // Implement your code here
        
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage="Please enter the user name")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage="Please enter the password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required(ErrorMessage="Please re-enter the password")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        
        [Required(ErrorMessage="Please enter the email id")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        
        [Required(ErrorMessage="Please enter the age")]
        [Range(19, int.MaxValue, ErrorMessage="Age must be greater than 18")]
        public int Age { get; set; }
        
        [Required(ErrorMessage="Please enter the contact details")]
        public long Contact { get; set; }
        
        [Required(ErrorMessage="Please enter the location")]
        public string Location { get; set; }
    }
}
