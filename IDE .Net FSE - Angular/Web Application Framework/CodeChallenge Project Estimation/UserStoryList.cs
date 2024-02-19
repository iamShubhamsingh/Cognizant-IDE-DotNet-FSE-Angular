using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectEstimation.Models
{
    public static class UserstoryList
    {
        static List<UserStory> usList = null;

        static UserstoryList()
        {
            usList = new List<UserStory>();
        }

        public static List<UserStory> GetUserStories()
        {
            return usList;
        }

        public static void InsertUserStory(UserStory userStory)
        {
            usList.Add(userstory);
        }

        public static void UpdateUserStory(UserStory userStory)
        {
            // Find the user story in the list and update it
            var existingUserStory = usList.FirstOrDefault(u => u.UserStoryID == userStory.UserStoryID);
            if (existingUserStory != null)
            {
                existingUserStory.Name = userStory.Name;
                existingUserStory.Description = userStory.Description;
                existingUserStory.Complexity = userStory.Complexity;
                existingUserStory.StoryPoint = userStory.StoryPoint;
            }
        }

        public static void DeleteUserStory(int id)
        {
            // Find the user story in the list and remove it
            var userStoryToDelete = usList.FirstOrDefault(u => u.UserStoryID == id);
            if (userStoryToDelete != null)
            {
                usList.Remove(userStoryToDelete);
            }
        }
    }
}
