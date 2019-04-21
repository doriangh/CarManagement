﻿using CarManagement.Core.Interfaces;
using CarManagement.Core.Requests;
using CarManagement.Core.Responses;
using CarManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarManagement.Services
{
    public class UserService : IUserService
    {
        readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public AddUserResponse AddUser(AddUserRequest request)
        {

            AddUserResponse response = new AddUserResponse();
            response.Errors = new List<string>();

            //TODO: validari

            if (request.Age < 10)
            {
                response.Success = false;
                response.Errors.Add("Age is lower than 10");
                return response;
            }

            _userRepository.Add(new User()
            {
                Name = request.Name,
                Age = request.Age,
                Username = request.Username,
                Password = request.Password,
                UserImage = request.UserImage
            });

            response.Success = true;
            return response;
        }
        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }
        public AddUserResponse DeleteUser(int id)
        {
            AddUserResponse response = new AddUserResponse
            {
                Errors = new List<string>()
            };

            _userRepository.Delete(id);

            response.Success = true;
            return response;
        }
    }
}
