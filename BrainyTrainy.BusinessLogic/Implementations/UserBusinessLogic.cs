﻿using AutoMapper;
using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Domain;
using BrainyTrainy.Dtos.User;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace BrainyTrainy.BusinessLogic.Implementations
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;
        private IConfiguration config;

        public UserBusinessLogic(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration config)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.config = config;
        }

        public AccountDto AuthenticateUser(LoginDto login)
        {
            var user = unitOfWork.UserRepository.GetUserByEmail(login.EmailAddress);
            if (user != null)
            {
                if (login.Password.Equals(user.Password))
                {
                    return new AccountDto
                    {
                        User = mapper.Map<UserDto>(user),
                        AuthorizationToken = GenerateJSONWebToken(mapper.Map<UserDto>(user))
                    };
                }
            }
            return null;
        }

        private string GenerateJSONWebToken(UserDto user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(config["Jwt:Issuer"],
              config["Jwt:Issuer"],
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}