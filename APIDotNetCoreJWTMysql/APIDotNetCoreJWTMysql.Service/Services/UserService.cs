﻿using System.Collections.Generic;
using APIDotNetCoreJWTMysql.Data.DapperORM.Interface;
using APIDotNetCoreJWTMysql.Model;
using APIDotNetCoreJWTMysql.Service.Interface;

namespace APIDotNetCoreJWTMysql.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetUserList()
        {
            var obj = new List<User>();
            return obj;
        }

        public User GetToken(string username, string password)
        {
            var passwordHash = Utils.HashUtil.GetSha256FromString(password);

            var ret = _userRepository.ValidateUser(username, passwordHash);

            if (ret != null)
            {
                //ret.Token = Utils.JwtManager.GenerateToken(username).Value;
            }
            return ret;
        }

        public void InsertUser(string username, string password)
        {
            var passwordHash = Utils.HashUtil.GetSha256FromString(password);

            _userRepository.InsertUser(username, passwordHash);
        }
    }
}