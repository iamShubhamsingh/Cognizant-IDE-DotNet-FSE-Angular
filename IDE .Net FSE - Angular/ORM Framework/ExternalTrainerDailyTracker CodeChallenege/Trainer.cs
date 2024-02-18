using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExternalTrainerDailyTracker
{
    //Fill your code here
    public class Trainer
    {
        [Key]
        public string TrainerId { get; set; }
        
        [Required]
        public string TrainerName { get; set; }
        
        [Required]
        public string Technology { get; set; }
        
        public virtual ICollection<DailyActivity> DailyActivityModels { get; set; }
    }
}
