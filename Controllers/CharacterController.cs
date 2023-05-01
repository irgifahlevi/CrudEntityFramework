using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudEntityFramework.Models;
using CrudEntityFramework.Services.CharacterServices;
using Microsoft.AspNetCore.Mvc;

namespace CrudEntityFramework.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
        {
            var characters = await _characterService.GetAllCharacters();
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetById(int id)
        {
            try
            {
                var character = await _characterService.GetCharacterById(id);
                return Ok(character);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> CreateCharacter(Character character)
        {
            var createCharacter = await _characterService.AddCharacter(character);
            return Ok(createCharacter);
        }
    }
}