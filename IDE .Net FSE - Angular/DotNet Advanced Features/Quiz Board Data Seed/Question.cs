using System.ComponentModel.DataAnnotations;

namespace ASPNET6_Template.Models
{
    public class Question
    {
        // Implement code here

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide QuizQuestion")]
        public string QuizQuestion { get; set; }

        [Required(ErrorMessage = "Please provide Option1")]
        public string Option1 { get; set; }
        
        [Required(ErrorMessage = "Please provide Option2")]
        public string Option2 { get; set; }

        [Required(ErrorMessage = "Please provide Option3")]
        public string Option3 { get; set; }

        [Required(ErrorMessage = "Please provide Option4")]
        public string Option4 { get; set; }

        [Required(ErrorMessage = "Please provide Answer")]
        public string Answer { get; set; }
    }
}
