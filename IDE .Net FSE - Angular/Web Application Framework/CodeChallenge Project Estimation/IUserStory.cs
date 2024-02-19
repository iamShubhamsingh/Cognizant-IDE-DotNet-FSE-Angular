using ProjectEstimation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEstimation.Services
{
    public interface IUserStory
    {
        IEnumerable<UserStory> GetAllUsersStories();
        UserStory Get(int id);
        void Add(UserStory userstory);
        void Update(UserStory userstory);
        void Delete(int id);
    }
}