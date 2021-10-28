﻿using AutoMapper;
using BrainyTrainy.Domain.Entities;
using BrainyTrainy.Domain.Enums;
using BrainyTrainy.Dtos.Game;
using BrainyTrainy.Dtos.User;
using System;

namespace BrainyTrainy.BusinessLogic
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<PersonInfo, PersonInfoDto>();
            CreateMap<PersonInfoDto, PersonInfo>();
            CreateMap<GameHistoryDto, GameHistory>();
            CreateMap<GameHistory, GameHistoryDto>();
            CreateMap<GameDto, Game>()
                .ForMember(d => d.Id, s => s.MapFrom(src => Enum.Parse(typeof(GameType), src.Name)))
                .ForMember(d => d.Name, s => s.MapFrom(src => src.Name));
            CreateMap<Game, GameDto>()
                .ForMember(d => d.Id, s => s.MapFrom(src => (int)src.Id));
        }
    }
}