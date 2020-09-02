using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24HrChallenge.Data
{
    public class User
    {
        /*public User(ApplicationUser user)
        {
            _user = user;
        }*/

        private ApplicationUser _user;

        [Key]
        public Guid UserId
        {
            get
            {
                return Guid.Parse(_user.Id);
            }
        }

        [Required]
        public string Name => _user.UserName;

        [Required]
        public string Email => _user.Email;
    }
}
