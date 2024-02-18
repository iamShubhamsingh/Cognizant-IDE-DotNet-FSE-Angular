using System.Data.Entity;

namespace ExternalTrainerDailyTracker
{
    public class ExternalTrainerContext : DbContext
    {
        //Do not change the context name ExternalTrainerContext or DataConnection name
        public ExternalTrainerContext():base("Name=DataConnection")
        {

        }

        //Fill your code here to create the DbSets
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<DailyActivity> Activities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            /*Fill your code here to map entity to table, create the necessary primary key and required constraints and build the
            one to many relationship among the Trainer and DailyActivity entity.*/
            
            modelBuilder.Entity<Trainer>().ToTable("tblTrainer");

            modelBuilder.Entity<Trainer>().HasMany(t => t.DailyActivityModels).WithRequired(da => da.Trainer).HasForeignKey(da => da.TrainerId);

            modelBuilder.Entity<Trainer>().Property(t => t.TrainerId).IsRequired();

            modelBuilder.Entity<Trainer>().Property(t => t.TrainerName).IsRequired();

            modelBuilder.Entity<Trainer>().Property(t => t.Technology).IsRequired();

            modelBuilder.Entity<DailyActivity>().ToTable("tblDailyActivity");

            modelBuilder.Entity<DailyActivity>().Property(da => da.TrainerId).IsRequired();

            modelBuilder.Entity<DailyActivity>().Property(da => da.ActivityDate).IsRequired();

            modelBuilder.Entity<DailyActivity>().Property(da => da.ActivityType).IsRequired();

            modelBuilder.Entity<DailyActivity>().Property(da => da.TimeSpent).IsRequired();
        }
    }
}
