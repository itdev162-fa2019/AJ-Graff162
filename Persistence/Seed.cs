using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First post!",
                        Date = DateTime.Now.AddDays(-10),
                        Body = "Semper auctor neque vitae tempus quam pellentesque. Nec nam aliquam sem et tortor consequat id porta."
                    },
                    new Post {
                        Title = "This is my second post",
                        Date = DateTime.Now.AddDays(-7),
                        Body = "Et sollicitudin ac orci phasellus egestas tellus rutrum tellus."
                    },
                    new Post {
                        Title = "Another day, another post",
                        Date = DateTime.Now.AddDays(-4),
                        Body = "In nisl nisi scelerisque eu ultrices vitae. Vel fringilla est ullamcorper eget"
                    }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}