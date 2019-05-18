
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eloise.Models;

namespace Eloise.shared
{
    public class UserHandling
    {
        private readonly UserContext _context;
        public UserHandling(UserContext context)
        {
            _context = context;
        }

        public User[] getUsers()
        {
            return _context.User.ToArray();
        }
    }
}