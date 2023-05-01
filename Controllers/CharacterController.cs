using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudEntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudEntityFramework.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character (),
            new Character {Id = 1, Name = "Cyclops"},
            new Character {Id = 2, Name = "Hayabusa", Class = RpgClass.Mage},
        };


        [HttpGet]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult<List<Character>> GetById(int id)
        {
            var character = characters.Where(p => p.Id == id).FirstOrDefault();
            return Ok(character);
        }

        [HttpPost]
        public ActionResult<List<Character>> CreateCharacter(Character character)
        {
            characters.Add(character);
            return Ok(characters);
        }
    }
}