using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExternalTrainerDailyTracker
{
    //Fill your code here
    public class DailyActivity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActivityNumber { get; set; }

        [Required]
        public string TrainerId { get; set; }
        
        [ForeignKey("TrainerId")]
        public virtual Trainer Trainer { get; set; }
        
        [Required]
        public DateTime ActivityDate { get; set; }
        
        [Required]
        public string ActivityType { get; set; }
        
        [Required]
        public int TimeSpent { get; set; }
        
        public string Comment { get; set; }
    }
}
