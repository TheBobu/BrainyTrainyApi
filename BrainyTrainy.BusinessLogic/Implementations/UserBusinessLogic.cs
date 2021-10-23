﻿using AutoMapper;
using BrainyTrainy.BusinessLogic.Interfaces;
using BrainyTrainy.Domain;
using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Dtos.User;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security;
using System.Security.Claims;
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
            var user = unitOfWork.UserRepository.GetUserByEmail(login.Email);
            if (user != null)
            {
                SecureString password = new NetworkCredential("", login.Password).SecurePassword;
                if (password.Equals(user.Password))
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

        public bool Register(UserDto userDto)
        {
            userDto.Password = new NetworkCredential("", userDto.Password).SecurePassword.ToString();
            unitOfWork.UserRepository.Add(mapper.Map<User>(userDto));
            return false;
        }

        private string GenerateJSONWebToken(UserDto user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>();
            claims.Add(new Claim("email", user.Email));
            claims.Add(new Claim("fullName", user.PersonInfoDto.FullName));
            claims.Add(new Claim("address", user.PersonInfoDto.Address));

            var token = new JwtSecurityToken(config["Jwt:Issuer"],
              config["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}