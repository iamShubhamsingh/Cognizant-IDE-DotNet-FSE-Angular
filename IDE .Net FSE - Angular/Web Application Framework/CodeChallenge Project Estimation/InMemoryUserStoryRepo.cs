using ProjectEstimation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectEstimation.Services
{
    public class InMemoryUserStoryRepo : IUserStory
    {
        public void Add(UserStory story)
        {
            // Call UserstoryList.InsertUserStory by passing the story object
            UserstoryList.InsertUserStory(story);
        }

        public void Delete(int id)
        {
            // Call UserstoryList.DeleteUserStory by passing the id
            UserstoryList.DeleteUserStory(id);
        }

        public UserStory Get(int id)
        {
            // Call UserstoryList.GetUserStories() and iterate through to retrieve the user story by id
            return UserstoryList.GetUserStories().FirstOrDefault(u => u.UserStoryID == id);
        }

        public IEnumerable<UserStory> GetAllUserStories()
        {
            // Call UserstoryList.GetUserStories() to get all user stories
            return UserstoryList.GetUserStories();
        }

        public void Update(UserStory story)
        {
            // Call UserstoryList.UpdateUserStory by passing the story
            UserstoryList.UpdateUserStory(story);
        }
    }
}
