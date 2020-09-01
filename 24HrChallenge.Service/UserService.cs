using _24HrChallenge.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace _24HrChallenge.Service
{
    class UserService
    {
        private readonly Guid _userId;
        
        public UserService(Guid userId)
        {
            _userId = userId;
        }
        
        public bool CreateUser(User model)
        {
            var entity = new User()
            {
                UserId = _userId,
                Name = model.Name,
                Email = model.Email
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Users.Add(entity);
                    return ctx.SaveChanges() == 1; 
            }

        }
    }
}
