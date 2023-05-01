using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CrudEntityFramework.Dtos.Character;
using CrudEntityFramework.Models;

namespace CrudEntityFramework.Profiles.Characters
{
    public class ProfilesCharacter : Profile
    {
        public ProfilesCharacter()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<GetCharacterDto, Character>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
        }
    }
}