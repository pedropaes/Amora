﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eloise.Models;

namespace Eloise.shared
{
    public class UserHandling
    {
        private readonly EloiseContext _context;
        public UserHandling(EloiseContext context)
        {
            _context = context;
        }

        public bool registerUser(User user)
        {
            user.password = MyHelpers.HashPassword(user.password);
            _context.User.Add(user);
            _context.SaveChanges();
            return true;
        }
        public bool validateUser(User user)
        {
            user.password = MyHelpers.HashPassword(user.password);
            var returnedUser = _context.User.Where(b => b.email == user.email && b.password == user.password).FirstOrDefault();

            if (returnedUser == null)
            {
                return false;
            }
            return true;
        }
        public User getUser(string email)
        {
           User u = _context.User.Where(b => b.email == email).FirstOrDefault();
           return u;
        }
        public User[] getUsers()
        {
            return _context.User.ToArray();
        }
    }
}