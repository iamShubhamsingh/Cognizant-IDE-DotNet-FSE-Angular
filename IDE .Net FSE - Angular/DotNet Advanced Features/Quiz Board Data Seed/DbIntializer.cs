using ASPNET6_Template.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNET6_Template.Data
{
    public class DbIntializer : IDbIntializer
    {
        // Implement code here - Inject QuizDbContext

        private readonly QuizDbContext _context;

        public DbIntializer(QuizDbContext context)
        {
            _context = context;
        }
        
        public void Initialize()
        {
           // Implement code here - Default data insertion logics
           try
           {
            if(_context.Database.GetPendingMigrations().Count() > 0)
            {
                _context.Database.Migrate();
            }
           }
           catch (Exception ex)
           { 
           }

           if(!_context.Questions.Any())
           {
            var questions = new List<Question>()
            {
                new Question()
                {
                    QuizQuestion = "The first metal used by the man was",
                    Option1 = "Iron",
                    Option2 = "Copper",
                    Option3 = "Aluminium",
                    Option4 = "Gold",
                    Answer = "Copper"
                },
                new Question()
                {
                    QuizQuestion = "Which of the following is a balanced fertiliser for plants ?",
                    Option1 = "Urea",
                    Option2 = "Ammonia Sulphate",
                    Option3 = "Nitrates",
                    Option4 = "Compost",
                    Answer = "Compost"
                }
            };

            _context.Questions.AddRange(questions);
            _context.SaveChanges();
           }

        }

        
    }
}
