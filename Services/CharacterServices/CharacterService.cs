using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudEntityFramework.Models;

namespace CrudEntityFramework.Services.CharacterServices
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> {
            new Character (),
            new Character {Id = 1, Name = "Cyclops"},
            new Character {Id = 2, Name = "Hayabusa", Class = RpgClass.Mage},
        };

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character character)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            if (character is null)
                throw new ArgumentNullException(nameof(character));
            characters.Add(character);
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            if (character is null)
                throw new Exception("No character found with the provided id");

            serviceResponse.Data = character;
            return serviceResponse;
        }
    }
}