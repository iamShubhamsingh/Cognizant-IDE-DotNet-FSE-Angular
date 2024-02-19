using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectEstimation.Models
{
    public class UserStory
    {
        [Key]
        public int UserStoryID { get; set; }

        [Required(ErrorMessage = "Please provide a user story name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide the user story description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please define the complexity")]
        public StoryType Complexity { get; set; }

        [Required(ErrorMessage = "The Story Point field is required.")]
        [Range(1, 5, ErrorMessage = "Please provide the correct story point: Story Point Ranges [1,5]")]
        public int StoryPoint { get; set; }
    }
}
