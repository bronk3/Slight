using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Slight.Models;

namespace Slight.DAL
{
    public class SlightInitializer : DropCreateDatabaseAlways<SlightContext>
    {
        protected override void Seed(SlightContext dbContext)
        {
            var user = new User(){
                Name = "Kari bronson",
                Password = "Programer"
            };
            var post = new Post()
            {
                User = user,
                Text = "I like to Blog about my feelings!"
            };
            var comment = new Comment() { 
                Post = post,
                Text = "This is my First Comment!"
            };
            user.Respects.Add(post);

            dbContext.Users.Add(user);
            dbContext.Posts.Add(post);
            dbContext.Comments.Add(comment);

            base.Seed(dbContext);
        }
    }
}