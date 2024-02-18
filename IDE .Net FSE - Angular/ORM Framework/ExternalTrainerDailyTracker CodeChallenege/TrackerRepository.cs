using System;
using System.Collections.Generic;
using System.Linq;

namespace ExternalTrainerDailyTracker
{
    public class TrackerRepository
    {
        ExternalTrainerContext trainerContext = new ExternalTrainerContext();

        //Fill your code here
        private readonly ExternalTrainerContext _context;

        public TrackerRepository()
        {
            _context = new ExternalTrainerContext();
        }

        public Trainer AddTrainerDetails(Trainer trainer)
        {
            _context.Trainers.Add(trainer);
            _context.SaveChanges();
            return trainer;
        }

        public DailyActivity AddDailyActivityDetails(DailyActivity dailyActivity)
        {
            _context.Activities.Add(dailyActivity);
            _context.SaveChanges();
            return dailyActivity;
        }

        public List<DailyActivity> DailyActivityInformation()
        {
            return _context.Activities.ToList();
        }

        public List<DailyActivity> ActivityByTrainerId(string trainerId)
        {
            return _context.Activities.Where(da => da.TrainerId == trainerId).ToList();
        }
    }
}
