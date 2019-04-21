﻿using CarManagement.Core.Interfaces;
using CarManagement.Infrastructure.Data;
using CarManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManagement.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {

        private AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Users.Remove(GetById(id));
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Update(int id, User user)
        {
            var oldUser = GetById(id);
            oldUser.Id = user.Id;
            oldUser.Name = user.Name;
            oldUser.Age = user.Age;
            oldUser.Username = user.Username;
            oldUser.Password = user.Password;
            oldUser.UserImage = user.UserImage;
            _context.SaveChanges();
        }

        
    }
}
