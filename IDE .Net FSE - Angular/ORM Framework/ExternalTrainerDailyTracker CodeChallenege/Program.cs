using System;

namespace ExternalTrainerDailyTracker
{
    class Program
    {
        //Do not change any code under this class
        static void Main(string[] args)
        {
            TrackerRepository trackerRepository = new TrackerRepository();
            Trainer trainerModel;
            DailyActivity dailyActivityModel;
            string loopInput = string.Empty;

            do
            {
                try
                {
                    trainerModel = new Trainer();
                    Console.WriteLine("Enter Trainer Id:");
                    trainerModel.TrainerId = Console.ReadLine();
                    Console.WriteLine("Enter Trainer Name:");
                    trainerModel.TrainerName = Console.ReadLine();

                    Console.WriteLine("Technologies: \n1.Dotnet\n2.FSD Dotnet\n3. Java\n4. FSD Java\n5. Testing");
                    Console.WriteLine("Input Technology Name from the above available options:");
                    trainerModel.Technology = Console.ReadLine();

                    if (string.IsNullOrEmpty(trainerModel.TrainerId) || string.IsNullOrEmpty(trainerModel.TrainerName) || string.IsNullOrEmpty(trainerModel.Technology))
                        throw new Exception();
                    else
                    {
                        Trainer newTrainer = trackerRepository.AddTrainerDetails(trainerModel);
                        Console.WriteLine("New trainer details added successfully");
                    }

                    Console.WriteLine("Input YES to add a new trainer..any other key to terminate");
                    loopInput = Console.ReadLine();
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Insertion Failed. Either trainer already exists in database or wrong application logic");
                    Console.WriteLine("Input YES to try again..any other key to terminate");
                    loopInput = Console.ReadLine();
                }
            } while (loopInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));

            do
            {
                try
                {
                    dailyActivityModel = new DailyActivity();
                    Console.WriteLine("Enter Activity Date:");
                    dailyActivityModel.ActivityDate = DateTime.ParseExact(Console.ReadLine(), "yyyy/MM/dd", null);
                    Console.WriteLine("Enter Trainer Id:");
                    dailyActivityModel.TrainerId = Console.ReadLine();
                    Console.WriteLine("Activities: \n1. Webex\n2.HandsOn\n3. CC\n4.ICT\n5. Leave");
                    Console.WriteLine("Enter Activity Name from the above options:");
                    dailyActivityModel.ActivityType = Console.ReadLine();
                    Console.WriteLine("Enter Activity Duration (in hours):");
                    dailyActivityModel.TimeSpent = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Your Comment or NA if you do not have any comment");
                    dailyActivityModel.Comment = Console.ReadLine();
                    DailyActivity newActivity = trackerRepository.AddDailyActivityDetails(dailyActivityModel);
                    Console.WriteLine("Trainer Daily Activity saved successfully");
                    Console.WriteLine("Input YES to add a new activity..any other key to terminate");
                    loopInput = Console.ReadLine();
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Insertion Failed Please check data and application logic");
                    Console.WriteLine("Input YES to try again..any other key to terminate");
                    loopInput = Console.ReadLine();
                    Console.WriteLine();
                }
            } while (loopInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("\nDisplay Daily Activity Details:");
            var dailyActivityList = trackerRepository.DailyActivityInformation();

            if (dailyActivityList.Count > 0)
            {
                Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5}", "Trainer Id", "Trainer Name", "Technology", "Activity Date", "Activity Type", "Duration");
                foreach (var tracker in dailyActivityList)
                {
                    Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5}", tracker.TrainerId, tracker.Trainer.TrainerName, tracker.Trainer.Technology,
                                      tracker.ActivityDate.ToString("dd-MM-yyyy"), tracker.ActivityType, tracker.TimeSpent);
                }
            }
            else
            {
                Console.WriteLine("No items in DailyActivity table or wrong implementation logic");
            }

            Console.WriteLine("\nDisplay Daily Tracker By Trainer Id");
            Console.WriteLine("Enter Trainer Id:");
            string searchTrainerId = Console.ReadLine();
            var listByTrainerId = trackerRepository.ActivityByTrainerId(searchTrainerId);

            if (listByTrainerId.Count > 0)
            {
                Console.WriteLine("\n{0,-20}{1,-20}{2,-20}{3,-20}{4}", "Trainer Name", "Activity Date", "Activity Type", "Duration", "Comment");
                foreach (var tracker in listByTrainerId)
                {
                    Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4}", tracker.Trainer.TrainerName, tracker.ActivityDate.ToString("dd-MM-yyyy"),
                                      tracker.ActivityType, tracker.TimeSpent, tracker.Comment);
                }
            }
            else
            {
                Console.WriteLine("No records for the searched trainer id found");
            }

            Console.WriteLine("\nThank you. Have a nice day");
        }
    }
}
