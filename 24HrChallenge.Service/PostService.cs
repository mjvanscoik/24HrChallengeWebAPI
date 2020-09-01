using _24HrChallenge.Data;
using _24HrChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _24HrChallenge.Service
{
    public class PostService
    {
        private readonly Guid _userId;
        private readonly User _user;

        public PostService (Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePost(Post model)
        {

            var entity = new Post()
            {

                PostId = model.PostId,
                Title = model.Title,
                Text = model.Text,
                Author = model.Author

            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
