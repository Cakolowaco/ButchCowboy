using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Projects.Any()) return;
            
            var projects = new List<Project>
            {
                new Project
                {
                    Title = "Past Project 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Project 2 months ago",
                    Tags = "drinks"
                },
                new Project
                {
                    Title = "Past Project 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Project 1 month ago",
                    Tags = "culture"
                },
                new Project
                {
                    Title = "Future Project 1",
                    Date = DateTime.Now.AddMonths(1),
                    Description = "Project 1 month in future",
                    Tags = "culture"
                },
                new Project
                {
                    Title = "Future Project 2",
                    Date = DateTime.Now.AddMonths(2),
                    Description = "Project 2 months in future",
                    Tags = "music"
                },
                new Project
                {
                    Title = "Future Project 3",
                    Date = DateTime.Now.AddMonths(3),
                    Description = "Project 3 months in future",
                    Tags = "drinks"
                },
                new Project
                {
                    Title = "Future Project 4",
                    Date = DateTime.Now.AddMonths(4),
                    Description = "Project 4 months in future",
                    Tags = "drinks"
                },
                new Project
                {
                    Title = "Future Project 5",
                    Date = DateTime.Now.AddMonths(5),
                    Description = "Project 5 months in future",
                    Tags = "drinks"
                },
                new Project
                {
                    Title = "Future Project 6",
                    Date = DateTime.Now.AddMonths(6),
                    Description = "Project 6 months in future",
                    Tags = "music"
                },
                new Project
                {
                    Title = "Future Project 7",
                    Date = DateTime.Now.AddMonths(7),
                    Description = "Project 2 months ago",
                    Tags = "travel"
                },
                new Project
                {
                    Title = "Future Project 8",
                    Date = DateTime.Now.AddMonths(8),
                    Description = "Project 8 months in future",
                    Tags = "film"
                }
            };

            await context.Projects.AddRangeAsync(projects);
            await context.SaveChangesAsync();
        }
    }
}